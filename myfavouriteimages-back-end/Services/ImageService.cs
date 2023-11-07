using Data;
using Entitties;
using myfavouriteimages_back_end.IServices;

namespace myfavouriteimages_back_end.Services
{
    public class ImageService : BaseContextService, IImageService
    {
        public ImageService(ServiceContext serviceContext) : base(serviceContext)
        {
        }
        public int InsertImage(Image image)
        {
            _serviceContext.Image.Add(image);
            _serviceContext.SaveChanges();
            return image.id;
        }

        public List<Image> GetAllImages()
        {
            return _serviceContext.Image.ToList();

        }

        public bool DeleteImage(int imageId)
        {
            var image = _serviceContext.Image.FirstOrDefault(u => u.id == imageId);

            if (image == null)
            {
                return false;
            }

            _serviceContext.Image.Remove(image);
            _serviceContext.SaveChanges();

            return true;
        }
    }

}
