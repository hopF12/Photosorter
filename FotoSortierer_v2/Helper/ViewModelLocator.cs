using System.ComponentModel;
using System.Windows;
using Autofac;
using FotoSortierer_v2.ViewModel.Interfaces;
using FotoSortierer_v2.ViewModel.MockUps;

namespace FotoSortierer_v2.Helper
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Returns ViewModel for a singe camera.
        /// </summary>
        public ICameraViewModel CameraViewModel => IsInDesignMode()? new MockCameraViewModel() : IocContainer.Instance.Container.Resolve<ICameraViewModel>();

        /// <summary>
        /// Returns viewmodel for flipview.
        /// </summary>
        public IFlipViewViewModel FlipViewViewModel => IsInDesignMode()? new MockFlipViewViewModel() : IocContainer.Instance.Container.Resolve<IFlipViewViewModel>();

        /// <summary>
        /// Returns viewmodel for hamburgermenu.
        /// </summary>
        public IHamburgerMenuViewModel HamburgerMenuViewModel => IsInDesignMode()? new MockHamburgerMenuViewModel() : IocContainer.Instance.Container.Resolve<IHamburgerMenuViewModel>();

        /// <summary>
        /// Returns viewmodel for importview.
        /// </summary>
        public IImportViewModel ImportViewModel => IsInDesignMode()? new MockImportViewModel() : IocContainer.Instance.Container.Resolve<IImportViewModel>();

        /// <summary>
        /// Returns viewmodel for mainview.
        /// </summary>
        public IMainViewModel MainViewModel => IsInDesignMode()? new MockMainViewModel() : IocContainer.Instance.Container.Resolve<IMainViewModel>();

        /// <summary>
        /// Returns viewmodel for single photo.
        /// </summary>
        public IPhotoViewModel PhotoViewModel => IsInDesignMode()? new MockPhotoViewModel() : IocContainer.Instance.Container.Resolve<IPhotoViewModel>();

        // returns true if editing .xaml file in VS for example
        private bool IsInDesignMode()
        {
            return DesignerProperties.GetIsInDesignMode(new DependencyObject());
        }
    }
}