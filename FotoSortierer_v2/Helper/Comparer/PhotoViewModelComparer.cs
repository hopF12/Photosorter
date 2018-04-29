using System.Collections.Generic;
using FotoSortierer_v2.ViewModel.Interfaces;

namespace FotoSortierer_v2.Helper.Comparer
{
    public class PhotoViewModelComparer : IEqualityComparer<IPhotoViewModel>
    {
        public bool Equals(IPhotoViewModel x, IPhotoViewModel y)
        {
            return x?.Name == y?.Name && x?.DateTaken == y?.DateTaken;
        }

        public int GetHashCode(IPhotoViewModel obj)
        {
            var hashCode = obj.Name.GetHashCode() & obj.DateTaken.GetHashCode();

            return hashCode;
        }
    }
}