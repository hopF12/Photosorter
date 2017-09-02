using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.Helper.Builder.Interfaces
{
    public interface ICameraViewModelBuilder
    {
        ICameraViewModel Build(ICameraModel model);
    }
}
