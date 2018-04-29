using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.Helper.Builder.Interfaces;
using FotoSortierer_v2.Services.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Helper.Comparer.Interfaces;
using Repository.Interfaces;
using Helper.Others;

namespace FotoSortierer_v2.Services
{
    /// <inheritdoc />
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;
        private readonly IPhotoViewModelBuilder _photoBuilder;
        private readonly IDialogService _dialogService;
        private readonly IEqualityComparer<IPhotoViewModel> _photoViewModelComparer;
        private readonly IImageComparer _comparer;

        public PhotoService(IPhotoRepository photoRepository, IPhotoViewModelBuilder photoBuilder,
                            IDialogService saveFolderDialog, IImageComparer comparer, IEqualityComparer<IPhotoViewModel> photoViewModelComparer)
        {
            _photoRepository = photoRepository;
            _photoBuilder = photoBuilder;
            _dialogService = saveFolderDialog;
            _photoViewModelComparer = photoViewModelComparer;
            _comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
        }

        /// <inheritdoc />
        public async Task<ICollection<IPhotoViewModel>> GetPhotosAsync(IProgressbarViewModel progressbar, IEnumerable<IPhotoViewModel> currentPhotos)
        {
            var fileNames = _dialogService.GetFileNames().ToList();
            var photos = currentPhotos.ToList();

            progressbar.Init("Importiere Fotos", fileNames.Count);

            var models = await _photoRepository.GetPhotosAsync(fileNames, progressbar);
            photos.AddRange(models.Select(photoModel => _photoBuilder.Build(photoModel)));
            photos = AddSeperatorForEachNextDay(photos).ToList();

            photos = photos.Distinct(_photoViewModelComparer).ToList();

            progressbar.Finish();

            return photos;
        }

        /// <inheritdoc />
        public async Task<ICollection<IPhotoViewModel>> GetSimilarPhotosAsync(IProgressbarViewModel progressbar, ICollection<IPhotoViewModel> photos)
        {
            progressbar.Init("Vergleiche Fotos", photos.Count(p => !p.IsFolder));

            await Task.Run(() =>
            {
                foreach (var photo in photos.Where(file => !file.IsFolder))
                {
                    photo.SimilarPhotos = _comparer.Compare(photo.Path, photos.Select(p => p.Path).ToList());
                    progressbar.ProgressbarValue++;
                }
            });

            progressbar.Finish();

            return photos;
        }

        public void DeletePhoto(string path, IObservableCollectionAdapter<IPhotoViewModel> photos)
        {
            if (!_dialogService.ShouldDelete(path)) return;

            // remove photo from observable collection
            photos.Remove(photos.FirstOrDefault(p => p.Path == path));

            // remove empty days
            RemoveEmptyDays(photos);

            // remove photo from similarity lists
            foreach (var photoViewModel in photos)
            {
                photoViewModel.SimilarPhotos?.Remove(photoViewModel.SimilarPhotos?.FirstOrDefault(p => p.Destination.File.FullName == path));
            }
        }

        /// <inheritdoc />
        public async Task SaveAsync(ICollection<IPhotoViewModel> photos, IProgressbarViewModel progressbar, bool createSubfolder = false)
        {
            var destination = _dialogService.SaveFiles(photos);
            if (string.IsNullOrEmpty(destination)) return;

            var images = photos.Where(p => createSubfolder || !p.IsFolder).ToList();

            progressbar.Init("Speichere Fotos", images.Count);

            await _photoRepository.Save(images, progressbar, destination);

            progressbar.Finish();
        }

        /// <summary>
        /// Adds a seperator for each next day.
        /// </summary>
        /// <param name="collection">The photo collection.</param>
        private IEnumerable<IPhotoViewModel> AddSeperatorForEachNextDay(ICollection<IPhotoViewModel> collection)
        {
            var orderedCollection = collection.OrderBy(col => col.DateTaken).ToList();
            var dates = collection.Select(col => col.DateTaken.Date).Distinct();

            foreach (var dateTime in dates)
            {
                var index = orderedCollection.IndexOf(orderedCollection.First(oCol => oCol.DateTaken.Date == dateTime.Date));
                orderedCollection.Insert(index, _photoBuilder.BuildSeperator(dateTime));
            }

            return orderedCollection.Distinct(p => p.DateTaken);
        }

        private IEnumerable<IPhotoViewModel> RemoveEmptyDays(ICollection<IPhotoViewModel> collection)
        {
            collection = collection.Where(c => collection.Count(pvw => pvw.DateTaken.Date == c.DateTaken.Date) >= 1).ToList();
            return collection;
        }
    }
}