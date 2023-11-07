using Entitties;

namespace myfavouriteimages_back_end.IServices
{
    public interface IImageService
    {
        int InsertImage(Image image);
        List<Image> GetAllImages();
        bool DeleteImage(int imageId);
    }
}
