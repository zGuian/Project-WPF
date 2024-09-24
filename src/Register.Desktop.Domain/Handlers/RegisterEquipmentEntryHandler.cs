using MediatR;
using Register.Desktop.Domain.Commands.Requests;
using Register.Desktop.Domain.Commands.Responses;

namespace Register.Desktop.Domain.Handlers
{
    public class RegisterEquipmentEntryHandler : IRequestHandler<RegisterEquipmentEntryRequest, RegisterEquipmentEntryResponse>
    {
        public Task<RegisterEquipmentEntryResponse> Handle(RegisterEquipmentEntryRequest request, CancellationToken cancellationToken)
        {
            // VERIFICA SE O CLIENTE ESTA CADASTRADO
            // VALIDA DADOS
            // INSERIR CLIENTE
            // ACIONA OUTROS SERVIÇOS
            // MANIPULA DADOS ANTES DE RETORNA O RESPONSE
            throw new NotImplementedException();
        }
    }
}