using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BertoniTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BertoniTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly string requestBase = "http://jsonplaceholder.typicode.com/comments";

        public CommentController(IHttpClientFactory cf)
        {
            _clientFactory = cf;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<Comment>> GetAllComents()
        {
            using (var client = _clientFactory.CreateClient())
            {
                var response = await client.GetAsync(requestBase);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Comment>>(responseString);
                }
            }

            return null;
        }

        [HttpGet]
        [Route("GetAllCommentsForPhoto")]
        public async Task<IEnumerable<Comment>> GetAllCommentsForPhoto(int photoId)
        {
            using (var client = _clientFactory.CreateClient())
            {
                var response = await client.GetAsync(requestBase + $"?postId={photoId}");
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Comment>>(responseString);
                }
            }

            return null;
        }
    }
}
