using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        public WorkTasks Get()
        {
            var fixture = new Fixture();
            var tasks = fixture.Build<WorkTasks>().With(t => t.GetTitle(), "a").Create();
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(
                tasks,
                new ValidationContext(tasks, null, null),
                results,
                false);
            return tasks;
        }
    }
}