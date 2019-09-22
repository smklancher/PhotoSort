using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSort
{
    public class PhotoRelation
    {
        public Photo Owner { get; private set; }
        public Photo Other { get; private set; }
        public PhotoRelation(Photo relationOwner, Photo other, bool otherIsNewer)
        {
            Owner = relationOwner;
            Other = other;

            OwnerInitiallyHadDate = Owner.Date.HasValue;
            OtherInitiallyHadDate = Other.Date.HasValue;
            OwnerAppearsNewer = !otherIsNewer;
        }

        public bool RelationshipNeedsReconfimration
        {
            get
            {
                return OwnerInitiallyHadDate != Owner.Date.HasValue || OtherInitiallyHadDate != Other.Date.HasValue;
            }
        }

        public bool OwnerInitiallyHadDate { get; private set; }
        public bool OtherInitiallyHadDate { get; private set; }

        /// <summary>
        /// Create oposite relation (this relation is this owner to other, output is relation of other to this owner)
        /// </summary>
        /// <returns></returns>
        public PhotoRelation MirrorRelation()
        {
            return new PhotoRelation(Other, Owner, OwnerAppearsNewer);
        }

        public bool OwnerAppearsNewer { get; private set; }

        public int TimesEvaluated { get; set; } = 0;


    }
}
