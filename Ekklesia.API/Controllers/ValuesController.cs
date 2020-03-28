using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ekklesia.Business.Services;
using Ekklesia.Data.Contexts;
using Ekklesia.Infrastructure.Interfaces.Services;
using Ekklesia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ekklesia.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IService<ActivityType> _commonService;
        public ValuesController(IService<ActivityType> commonService)
        {
            _commonService = commonService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var one = _commonService.GetByID(1);
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
