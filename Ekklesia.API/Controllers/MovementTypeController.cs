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
    public class MovementTypeController : BaseController<IMovementTypeService, MovementType>
    {
        public MovementTypeController(IMovementTypeService movementTypeService) : base(movementTypeService)
        {
        }
    }
}
