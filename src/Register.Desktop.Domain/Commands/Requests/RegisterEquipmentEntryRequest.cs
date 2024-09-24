using MediatR;
using Register.Desktop.Domain.Commands.Responses;

namespace Register.Desktop.Domain.Commands.Requests
{
    public class RegisterEquipmentEntryRequest : IRequest<RegisterEquipmentEntryResponse>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}