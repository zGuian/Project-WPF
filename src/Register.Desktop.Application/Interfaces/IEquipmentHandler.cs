using Register.Desktop.Application.Commands.Requests;
using Register.Desktop.Application.Commands.Responses;
using Register.Desktop.Domain.Entities;

namespace Register.Desktop.Application.Interfaces
{
    public interface IEquipmentHandler
    {
        Task<Responses<Equipment>> Handle(Requests<Equipment> request, CancellationToken cancellationToken);
    }
}
