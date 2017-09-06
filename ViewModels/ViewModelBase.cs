using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Annotations;

namespace ViewModels
{
    /// <summary>
    /// Base class for each viewmodel.
    /// </summary>
    /// <typeparam name="TModel">Model of the viewmodel.</typeparam>
    public class ViewModelBase<TModel> : INotifyPropertyChanged
    {
        public ViewModelBase()
        {
            Model = Activator.CreateInstance<TModel>();
        }

        protected TModel Model { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
