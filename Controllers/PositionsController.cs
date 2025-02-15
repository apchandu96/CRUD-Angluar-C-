﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreAngularCrudDemo.Models;
using AspNetCoreAngularCrudDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AspNetCoreAngularCrudDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionsController : ControllerBase
    {
        private readonly IPositionsService _positionService;

        public PositionsController(IPositionsService positionService)
        {
            _positionService = positionService;
        }

        // GET: api/Positions
        [HttpGet]
        public async Task<IEnumerable<Position>> Get()
        {
            return await _positionService.GetPositionsList();
        }
    }
}
