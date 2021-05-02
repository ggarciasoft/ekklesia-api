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
    [Route("api/[controller]")]
    [ApiController]
    public class MovementController : BaseController<IMovementService, Movement>
    {
        public MovementController(IMovementService movementService) : base(movementService)
        {
        }
    }
}
