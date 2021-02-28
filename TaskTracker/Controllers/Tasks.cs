using System.Collections.Generic;
using AutoFixture;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskTracker.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class TasksController :  ControllerBase
    {
        [HttpGet]
        public IEnumerable<Tasks> Get()
        {
            var fixture = new Fixture();
            return fixture.Create<IEnumerable<Tasks>>();
        }
    }
}