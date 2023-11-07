﻿using Data;
using Entitties;
using Microsoft.AspNetCore.Mvc;
using myfavouriteimages_back_end.IServices;
using System.Web.Http.Cors;

namespace myfavouriteimages_back_end.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("[controller]/[action]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;
        private readonly ServiceContext _serviceContext;

        public ImageController(IImageService imageService, ServiceContext serviceContext)
        {
            _imageService = imageService;
            _serviceContext = serviceContext;

        }

        [HttpPost(Name = "InsertImage")]
        public int Post([FromBody] Image image)
        {
            return _imageService.InsertImage(image);
        }

        [HttpGet(Name = "images")]
        public List<Image> Get()
        {

            return _imageService.GetAllImages ();
        }
 



    }
}
