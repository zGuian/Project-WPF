using Microsoft.AspNetCore.Mvc;
using Register.Desktop.Application.Interfaces;

namespace Register.Desktop.Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IServicesEquipment _services;

        public EquipmentController(IServicesEquipment services)
        {
            _services = services;
        }

        [HttpPost("EntryLaboratory")]
        public IActionResult Entry()
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
