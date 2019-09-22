using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PhotoSort
{
    /// <summary>
    /// Everything here should be refactored out and this class removed after I figure out what I'm doing
    /// </summary>
    public class Prototype
    {
        PhotoCollection photos;

        public Photo ReferencePhoto { get; private set; }
        public Photo TargetPhoto { get; private set; }

        public Prototype()
        {
            photos = LoadFolder();
            ReferencePhoto = NewReferencePhoto();
            TargetPhoto = NewTargetPhoto();
        }

        public static PhotoCollection LoadFolder()
        {
            return PhotoCollection.FromFolder(@"C:\Photos\Box2-1997\NEGS\7816");
        }

        public Photo NewReferencePhoto()
        {
            // in order of preference consider photos with date, photos with estimated date, all photos
            var pool = photos.Where(x => x.Date.HasValue);
            if (!pool.Any()) { pool = photos.Where(x => x.UncertainDate.HasValue); }
            if (!pool.Any()) { pool = photos; }

            // then pick a random one
            var index = new Random().Next(0, pool.Count());
            ReferencePhoto = pool.ToArray()[index];
            return ReferencePhoto;
        }

        public Photo NewTargetPhoto()
        {
            // in order of preference consider photos without date or estimated date, photos without date, all photos
            var pool = photos.Where(x => !x.EitherDate.HasValue);
            if (!pool.Any()) { pool = photos.Where(x => !x.Date.HasValue); }
            if (!pool.Any()) { pool = photos; }

            // then pick a random one
            var index = new Random().Next(0, pool.Count());
            TargetPhoto = pool.ToArray()[index];
            return TargetPhoto;
        }

        public void ConfirmCurrentRelationship(bool targetIsNewer)
        {
            ReferencePhoto.AddRelationship(TargetPhoto, targetIsNewer);
            TargetPhoto.AddRelationship(ReferencePhoto, !targetIsNewer);
            NewTargetPhoto();
        }

        public void SetTargetDate(DateTime date, bool unknownDay = false, bool unknownMonth = false)
        {
            TargetPhoto.SetDate(date, unknownDay, unknownMonth);
            NewTargetPhoto();
        }

        public string Stats()
        {
            if(photos.Count<1) { return "No Photos"; }

            var hasDate = photos.Where(x => x.Date.HasValue).Count();
            var noCertainDate = photos.Count-hasDate;
            var hasAtLeastYear = photos.Where(x => !x.Date.HasValue && x.UncertainDate.HasValue).Count();
            var hasAtLeastMonth = photos.Where(x => !x.Date.HasValue && x.UncertainDate.HasValue && !x.UnknownMonth).Count();
            var hasNeitherDate = photos.Where(x => !x.EitherDate.HasValue).Count();
            var hasBounds = photos.Where(x => !x.EitherDate.HasValue && x.UpperBoundFromRelationships.HasValue && x.LowerBoundFromRelationships.HasValue).Count();

            var msg = $"{(hasDate / photos.Count):##%} ({hasDate} of {photos.Count}) have a date\r\n";
            if (noCertainDate > 0) { msg += $"Of those without a date, {(hasAtLeastYear / noCertainDate):##%} ({hasAtLeastYear} of {noCertainDate}) have some estimate\r\n"; }
            if (hasNeitherDate > 0) { msg += $"Of those without even an estimated date, {(hasBounds / hasNeitherDate):##%} ({hasBounds} of {noCertainDate}) have some inferred bounds\r\n"; }

            //current photos
            msg += $"Reference Photo Date: {ReferencePhoto.ExplainDate()}\r\n";
            msg += $"Target Photo Date: {TargetPhoto.ExplainDate()}\r\n";

            return msg;
        }
    }
}
