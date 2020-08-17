using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.DAL.Contexts;
using Admin.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Admin.Api.Controllers
{
    [ApiController]
    [Route("api/mediaSim")]
    public class MediaSimController : ControllerBase
    {
        private readonly ILogger<MediaSimController> _logger;
        private readonly TargetingGroupContext db;

        public MediaSimController(ILogger<MediaSimController> logger, TargetingGroupContext context)
        {
            _logger = logger;
            db = context;
        }

        [HttpGet]
        public IEnumerable<People> Get()
        {
            var result = db.Peoples.ToList();
            return result;
        }
    }
}
