using Model.Interfaces;

namespace Helper.Builder.Interfaces
{
    public interface ICameraModelBuilder
    {
        ICameraModel Build(string cameraManufacturer, string cameraModel);
    }
}