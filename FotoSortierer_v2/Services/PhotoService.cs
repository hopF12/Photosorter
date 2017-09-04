using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FotoSortierer_v2.Helper.Builder.Interfaces;
using FotoSortierer_v2.Services.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Repository.Interfaces;

namespace FotoSortierer_v2.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;
        private readonly IPhotoViewModelBuilder _photoBuilder;
        private readonly IOpenFilesDialogService _openFilesDialog;
        private readonly ISaveFolderDialogService _saveFolderDialog;

        public PhotoService(IPhotoRepository photoRepository, IPhotoViewModelBuilder photoBuilder, IOpenFilesDialogService openFilesDialog, ISaveFolderDialogService saveFolderDialog)
        {
            _photoRepository = photoRepository;
            _photoBuilder = photoBuilder;
            _openFilesDialog = openFilesDialog;
            _saveFolderDialog = saveFolderDialog;
        }

        public async Task<IEnumerable<IPhotoViewModel>> GetPhotosAsync()
        {
            var models = await _photoRepository.GetPhotosAsync(_openFilesDialog.GetFileNames());
            var photos = models.Select(photoModel => _photoBuilder.Build(photoModel)).ToList();

            return photos;
        }

        public Task SaveAsync(IEnumerable<IPhotoViewModel> photos)
        {
            throw new NotImplementedException();
        }
    }
}