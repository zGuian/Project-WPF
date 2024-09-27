using Microsoft.AspNetCore.Mvc;
using Register.Desktop.Application.Commands.Requests;
using Register.Desktop.Application.Commands.Responses;
using Register.Desktop.Application.Interfaces;
using Register.Desktop.Domain.Entities;

namespace Register.Desktop.Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IHandlerEquipment _handler = null!;

        public EquipmentController()
        { }

        public EquipmentController(IHandlerEquipment handler)
        {
            _handler = handler;
        }

        [HttpGet("GetEquipments")]
        public async Task<IActionResult> GetEquipments(Requests<Equipment> requests, CancellationToken cancellationToken)
        {
            Responses<Equipment> equipments = await _handler.Handle(requests, cancellationToken);
            return Ok(equipments);
        }

        [HttpPost("RegisterOrUpdate")]
        public async Task<IActionResult> RegisterOrUpdate(Requests<Equipment> requests, CancellationToken cancellationToken)
        {
            await _handler.Handle(requests, cancellationToken);
            return Ok();
        }
    }
}
