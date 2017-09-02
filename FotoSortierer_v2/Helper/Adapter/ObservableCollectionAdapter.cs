using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using FotoSortierer_v2.Helper.Adapter.Interfaces;

namespace FotoSortierer_v2.Helper.Adapter
{
    public class ObservableCollectionAdapter<T> : ObservableCollection<T>, IObservableCollectionAdapter<T>
    {
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }

            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}