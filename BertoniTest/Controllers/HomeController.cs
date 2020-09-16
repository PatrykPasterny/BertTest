using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BertoniTest.Controllers;
using BertoniTest.Models;
using BertoniTest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BST4.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IHttpClientFactory cf, ILogger<HomeController> logger)
        {
            _clientFactory = cf;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
           var albumViewModels = await GetAllAlbums();

            return View(albumViewModels);
        }
        public async Task<ActionResult> DisplayAlbumPhotos(int albumId)
        {
           var albumViewModels = await GetAllPhotosForAlbum(albumId);

            return PartialView("_Photo", albumViewModels);
        }
        public async Task<ActionResult> DisplayPhotoComments(int photoId)
        {
           var albumViewModels = await GetAllCommentsForPhoto(photoId);

            return PartialView("_Comment", albumViewModels);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IEnumerable<AlbumViewModel>> GetAllAlbums() 
        {
            var albumRepo = new AlbumController(_clientFactory);
            var allAlbums = await albumRepo.Get();

            var albumViewModels = allAlbums.Select(a => new AlbumViewModel()
            {
                Id = a.Id,
                Title = a.Title
            });

            return albumViewModels;
        }

        public async Task<IEnumerable<PhotoViewModel>> GetAllPhotosForAlbum(int albumId)
        {
            var photoRepo = new PhotoController(_clientFactory);
            var allPhotos = await photoRepo.GetAllPhotosForAlbum(albumId);

            var photoViewModels = allPhotos.Select(p => new PhotoViewModel()
            {
                Id = p.Id,
                Title = p.Title,
                Url = p.Url,
                ThumbnailUrl = p.ThumbnailUrl,
            });

            return photoViewModels;
        }
        
        public async Task<IEnumerable<CommentViewModel>> GetAllCommentsForPhoto(int photoId)
        {
            var commentRepo = new CommentController(_clientFactory);

            var allComents = await commentRepo.GetAllCommentsForPhoto(photoId);
            return allComents.Select(c => new CommentViewModel()
            {
                Id = c.Id,
                Body = c.Body,
                Email = c.Email,
                Name = c.Name
            });
        }
    }
}
