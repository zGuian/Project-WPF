using Register.Desktop.Application.Interfaces;

namespace Register.Desktop.Application.Services
{
    public class ServicesEquipment : IServicesEquipment
    {
        private readonly IEquipmentHandler _handler;

        public ServicesEquipment(IEquipmentHandler handler)
        {
            _handler = handler;
        }
    }
}