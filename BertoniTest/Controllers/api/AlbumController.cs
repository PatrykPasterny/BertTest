using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BertoniTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace BertoniTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public AlbumController(IHttpClientFactory cf)
        {
            _clientFactory = cf;
        }

        [HttpGet]
        public async Task<IEnumerable<Album>> Get()
        {
            var client = _clientFactory.CreateClient();

            var request = "http://jsonplaceholder.typicode.com/albums";
            var response = await client.GetAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Album>>(responseString);
            }
            return null;


        }
    }
}
