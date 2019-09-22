using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PhotoSort
{
    public class PhotoSort : IComparer<Photo>
    {
        private enum SortResult
        {
            TargetNewerThanReference = -1,
            EqualOrUnknown = 0,
            TargetOlderThanReference = 1
        };

        private SortResult CompareSortResult([AllowNull] Photo reference, [AllowNull] Photo target)
        {
            // A null means that the other object is greater.
            if (target == null && reference==null) { return SortResult.EqualOrUnknown; }
            if (target == null) { return SortResult.TargetOlderThanReference; }
            if (reference == null) { return SortResult.TargetNewerThanReference; }

            // date to use for comparison
            var refDate = reference.EitherDate;
            var tarDate = target.EitherDate;

            // Dates and estimated dates are sorted the same
            if (refDate.HasValue && tarDate.HasValue)
            {
                return (SortResult)DateTime.Compare(refDate.Value, tarDate.Value);
            }

            // Since at least one has no date, check for and sort by direct relationship if exists
            if (target.Relationships.TryGetValue(reference, out var rel))
            {
                if (rel.OwnerAppearsNewer)
                {
                    return SortResult.TargetNewerThanReference;
                }
                else
                {
                    return SortResult.TargetOlderThanReference;
                }
            }

            // Get possible inferred range midpoints
            DateTime? refBoundaryMid = reference.MidpointOfRelationshipInferredBounds();
            DateTime? targetBoundaryMid = target.MidpointOfRelationshipInferredBounds();

            // At this point we know there is no direct relationship, and at least one doesn't have a date, so try to use inferred dates
            if (!refDate.HasValue) { refDate = refBoundaryMid; }
            if (!tarDate.HasValue) { tarDate = targetBoundaryMid; }

            if (refDate.HasValue && tarDate.HasValue)
            {
                return (SortResult)DateTime.Compare(refDate.Value, tarDate.Value);
            }

            return SortResult.EqualOrUnknown;
        }

        public int Compare([AllowNull] Photo x, [AllowNull] Photo y)
        {
            return (int)CompareSortResult(x, y);
        }
    }
}
