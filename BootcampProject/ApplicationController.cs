using BootcampProject.Business.Interfaces;
using BootcampProject.Business.Managers;
using BootcampProject.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampProject
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _applicationService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Application application)
        {
            _applicationService.Add(application);
            return Ok();
        }
    }

}
