using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BertoniTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;
using Newtonsoft.Json;

namespace BertoniTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly string requestBase = "http://jsonplaceholder.typicode.com/photos";

        public PhotoController(IHttpClientFactory cf)
        {
            _clientFactory = cf;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<Photo>> GetAllPhotos()
        {
            using (var client = _clientFactory.CreateClient())
            {
                var response = await client.GetAsync(requestBase);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Photo>>(responseString);
                }
            }
            return null;
        }

        [HttpGet]
        [Route("GetAllPhotosForAlbum")]
        public async Task<IEnumerable<Photo>> GetAllPhotosForAlbum(int albumId)
        {
            using (var client = _clientFactory.CreateClient()) 
            {
                var response = await client.GetAsync(requestBase + $"?albumId={albumId}");
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Photo>>(responseString);
                }
            }
            return null;
        }
    }
}
