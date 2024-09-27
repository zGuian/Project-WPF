using Register.Desktop.Application.Commands.Requests;
using Register.Desktop.Application.Commands.Responses;
using Register.Desktop.Application.Interfaces;
using Register.Desktop.Domain.Entities;

namespace Register.Desktop.Application.Handlers
{
    public class HandlerEquipment : IHandler<Equipment>, IEquipmentHandler
    {
        public Task<Responses<Equipment>> Handle(Requests<Equipment> request, CancellationToken cancellationToken)
        {
            //A fazer:
            //validar dados
            //verificar se o cliente esta cadastrado
            //salvar dados no banco
            //enviar notificação a outras parte do sistema (opcional)
            return Task.FromResult(new Responses<Equipment>(new Equipment()));
        }
    }
}