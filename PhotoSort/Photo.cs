using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace PhotoSort
{
    public class Photo : IComparable<Photo>
    {
        public string FilePath { get; private set; }
        public Photo(string filePath)
        {
            FilePath = filePath;
            RefreshFromFile();
        }

        private void RefreshFromFile()
        {
            //assume jpg for now and fix later
            using (var tfile = TagLib.File.Create(FilePath))
            {
                string title = tfile.Tag.Title;
                var tag = tfile.Tag as TagLib.Image.CombinedImageTag;
                Date = tag?.Exif.DateTime;
            }
                
        }

        /// <summary>
        /// Determine likely date bounds by relationships with photos that have known dates
        /// </summary>
        public void RefreshFromRelationships()
        {
            var bounds = Relationships.Values.Where(x => x.Other.Date.HasValue);
            foreach(var p in bounds)
            {
                // other appears newer so it could be an upper bound for this photo
                if (p.OwnerAppearsNewer )
                {
                    // update upper bound if there is non currently or if this narrows the bounds (lower date)
                    // HasValue check is already covered by linq, but having it here apparently needed to satisfy compliler nullability check
                    if (p.Other.Date.HasValue && (UpperBoundFromRelationships == null || p.Other.Date.Value < UpperBoundFromRelationships))
                    {
                        UpperBoundFromRelationships = p.Other.Date.Value;
                    }
                }
                // Other appears older, so could be a lower bound for this photo
                else
                {
                    
                    // update lower bound if there is non currently or if this narrows the bounds (higher date)
                    // HasValue check is already covered by linq, but having it here apparently needed to satisfy compliler nullability check
                    if (p.Other.Date.HasValue && (LowerBoundFromRelationships == null || p.Other.Date.Value > LowerBoundFromRelationships))
                    {
                        LowerBoundFromRelationships = p.Other.Date.Value;
                    }
                }
            }
        }

        public PhotoRelation AddRelationship(Photo other, bool otherIsNewer)
        {
            if(Relationships.TryGetValue(other,out var rel))
            {
                // relationship already exists so return it
                return rel;
            }
            
            rel = new PhotoRelation(this, other, otherIsNewer);
            Relationships.Add(other, rel);
            RefreshFromRelationships();

            return rel;
        }

        public DateTime? UpperBoundFromRelationships { get; private set; }
        public DateTime? LowerBoundFromRelationships { get; private set; }

        public DateTime? MidpointOfRelationshipInferredBounds()
        {
            if (UpperBoundFromRelationships.HasValue && LowerBoundFromRelationships.HasValue)
            {
                return LowerBoundFromRelationships + (UpperBoundFromRelationships - LowerBoundFromRelationships) / 2;
            }

            return null;
        }

        public DateTime? Date { get; private set; }

        public bool UnknownDay { get; set; }

        public bool UnknownMonth { get; set; }

        public void SetDate(DateTime date, bool unknownDay = false, bool unknownMonth = false)
        {
            if(!unknownMonth && !unknownDay)
            {
                Date = date;
                UncertainDate = null;
            }
            else
            {
                Date = null;

                if (unknownMonth)
                {
                    // unknownMonth includes unknownDay, assume middle of the year
                    UncertainDate = new DateTime(date.Year, 6, 1);
                }
                else
                {
                    // assume middle day
                    UncertainDate = new DateTime(date.Year, date.Month, 15);
                }


            }

            UnknownDay = unknownDay;
            UnknownMonth = unknownMonth;
        }

        public string ExplainDate()
        {
            
            if (Date.HasValue)
            {
                return Date.Value.ToShortDateString();
            }

            if (UncertainDate.HasValue)
            {
                if (UnknownMonth) { return $"Estimated to be in {UncertainDate.Value.Year}"; }
                if (UnknownDay) { return $"Estimated to be in {UncertainDate.Value.Year}, {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(UncertainDate.Value.Year)}"; }
            }

            if(LowerBoundFromRelationships.HasValue || UpperBoundFromRelationships.HasValue)
            {
                var msg = "";

                if (LowerBoundFromRelationships.HasValue)
                {
                    msg = $"Inferred to be later than {LowerBoundFromRelationships.Value.ToShortDateString()}.  ";
                }

                if (UpperBoundFromRelationships.HasValue)
                {
                    msg += $"Inferred to be before than {UpperBoundFromRelationships.Value.ToShortDateString()}.  ";
                }

                return msg;
            }

            return "No date";
        }

        public DateTime? EitherDate => Date.HasValue ? Date : UncertainDate;

        /// <summary>
        /// When exact date is not known use this, and ignore day if UnknownDay, and ignore month if UnknownMonth
        /// </summary>
        public DateTime? UncertainDate { get; set; }

        public Dictionary<Photo, PhotoRelation> Relationships { get; } = new Dictionary<Photo, PhotoRelation>();

        //maybe move this out to an IComparer class
        public int CompareTo([AllowNull] Photo other)
        {
            // A null value means that this object is greater.
            if (other == null)
            {
                return 1;
            }

            // Default sort only uses known dates
            if (Date.HasValue && other.Date.HasValue)
            {
                return DateTime.Compare(Date.Value, other.Date.Value);
            }


            // Otherwise, cannot determine
            return 0;
        }
    }
}
