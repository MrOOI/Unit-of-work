using Microsoft.AspNetCore.Mvc;
using TESTUoW.Service.Interfaces;

namespace TESTUoW.API.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected IServices Services { get; } 
        public BaseController(IServices services) 
        {
            Services = services;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var persons = Services.PersonService.GetAll();
            return Ok("Qalaysan!");
        }
    }
}
