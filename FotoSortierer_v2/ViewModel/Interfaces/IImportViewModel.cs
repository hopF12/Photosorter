﻿using FotoSortierer_v2.Helper;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    /// <summary>
    /// Viewmodel for importview.
    /// </summary>
    public interface IImportViewModel : IImportModel
    {
        /// <summary>
        /// List of all recognized cameras.
        /// </summary>
        IObservableCollectionAdapter<ICameraViewModel> Cameras { get; set; }

        /// <summary>
        /// List of all imported images.
        /// </summary>
        IObservableCollectionAdapter<IPhotoViewModel> Photos { get; set;  }
    }
}