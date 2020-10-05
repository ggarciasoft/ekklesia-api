using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ekklesia.Infrastructure.Interfaces.Services;
using Ekklesia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ekklesia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        // GET: api/Activity
        [HttpGet]
        public async Task<IEnumerable<Activity>> Get()
        {
            return await _activityService.GetAllAsync();
        }

        // GET: api/Activity/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Activity> Get(int id)
        {
            return await _activityService.GetByIDAsync(id);
        }

        // POST: api/Activity
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT: api/Activity/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
