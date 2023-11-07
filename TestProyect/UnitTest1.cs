//namespace TestProyect
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//        }
//    }
//}
using Data;
using Entitties;
using myfavouriteimages_back_end.IServices;
using myfavouriteimages_back_end.Controllers;
using myfavouriteimages_back_end.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TestProyect
{
    [TestClass]
    public class ImageControllerTests
    {
        private readonly IImageService _imageService;
        private readonly ServiceContext _serviceContext;
        private readonly ImageController _controller;

        public ImageControllerTests()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var options = new DbContextOptionsBuilder<ServiceContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _serviceContext = new ServiceContext(options);
            _imageService = new ImageService(_serviceContext);
            _controller = new ImageController(_imageService, _serviceContext);
        }


        [TestMethod]
        public void Post_ShouldCallInsertImage()
        {
            // Arrange
            var testImage = new Image
            {
                imageFavourite = "testImage.jpg",
                title = "Test Image"
            };

            // Act
            var result = _controller.Post(testImage);

            // Assert
            // Aqu� necesitar�as alguna forma de verificar que InsertImage fue llamado con la imagen de prueba.
            // Esto podr�a implicar refactorizar tu c�digo para permitir la verificaci�n de esto, o podr�a implicar
            // configurar el resultado esperado de InsertImage.
        }
    }

}

