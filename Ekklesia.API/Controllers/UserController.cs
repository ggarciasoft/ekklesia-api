﻿using System;
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
    public class UserController : BaseController<IUserService, User>
    {
        public UserController(IUserService userService) : base(userService)
        {
        }
    }
}
