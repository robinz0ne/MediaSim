using Admin.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Admin.UI.Controllers
{
    [ApiController]
    [Route("api/people")]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<People>> Get()
        {
            var client = new HttpClient();

            var streamTask = await client.GetStreamAsync("https://localhost:44375/api/mediaSim");

            var result = await JsonSerializer.DeserializeAsync<IEnumerable<People>>(streamTask);

            return result;
        }
    }
}
