using AutoMapper;
using Register.Desktop.Application.Commands.Requests;
using Register.Desktop.Application.Commands.Responses;
using Register.Desktop.Application.Interfaces;
using Register.Desktop.Domain.Entities;

namespace Register.Desktop.Application.Handlers
{
    public class HandlerEquipment : IHandler<Equipment>, IHandlerEquipment
    {
        private readonly IServicesEquipment _services = null!;
        private readonly IMapper _mapper = null!;

        public HandlerEquipment()
        { }

        public HandlerEquipment(IServicesEquipment services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

        public async Task<Responses<Equipment>> Handle(Requests<Equipment> request, CancellationToken cancellationToken)
        {
            //A fazer:
            //validar dados

            // CRIAR UMA PROCEDURE E SUBSTITUIR ESSAS 3 BUSCAS EM BANCO
            Equipment equipSN = await _services.GetBySerialNumberAsync(request.Datas.SerialNumber);
            if (equipSN == null)
            {
                Equipment equipInventory = await _services.GetByInventory(request.Datas.Inventory!);
                if (equipInventory == null)
                {
                    Equipment equipHostname = await _services.GetByHostnameAsync(request.Datas.Hostname!);
                    if (equipHostname == null)
                    {
                        _services.Register(request.Datas);
                    }
                }
            }
            Equipment equipUpdated = await _services.UpdateAsync(request.Datas);
            //enviar notificação a outras parte do sistema (opcional)
            return new Responses<Equipment>(equipUpdated);
        }
    }
}