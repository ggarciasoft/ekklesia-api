using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ekklesia.Infrastructure.Interfaces.Services;
using Ekklesia.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ekklesia.API.Controllers
{
    public class BaseController<TService, TModel> : ControllerBase where TService : IService<TModel> where TModel : class
    {
        private readonly TService _baseService;

        public BaseController(TService baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public async Task<IEnumerable<TModel>> Get()
        {
            return await _baseService.GetAllAsync();
        }

        [HttpGet("{id}", Name = "Get")]
        public async Task<TModel> Get(int id)
        {
            return await _baseService.GetByIDAsync(id);
        }

        [HttpPost]
        public async void Post([FromBody] TModel obj)
        {
            await _baseService.InsertAsync(obj);
        }

        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] TModel obj)
        {
            await _baseService.UpdateAsync(id, obj);
        }

        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _baseService.DeleteAsync(id);
        }
    }
}
