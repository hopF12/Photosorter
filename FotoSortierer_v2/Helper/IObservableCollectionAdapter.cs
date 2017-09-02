using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace FotoSortierer_v2.Helper
{
    public interface IObservableCollectionAdapter<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>, INotifyCollectionChanged
    {
        void AddRange(IEnumerable<T> collection);
    }
}