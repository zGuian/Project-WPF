using Register.Desktop.Application.Interfaces;
using Register.Desktop.Domain.Entities;
using Register.Desktop.Infra.Data.Interfaces;

namespace Register.Desktop.Application.Services
{
    public class ServicesEquipment : IServicesEquipment
    {
        private readonly IRepositoryEquipment _repository = null!;

        public ServicesEquipment()
        { }

        public ServicesEquipment(IRepositoryEquipment repository)
        {
            _repository = repository;
        }

        public async Task<Equipment> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<Equipment> GetByInventory(string inventory) => await _repository.GetByInventory(inventory);

        public async Task<Equipment> GetByHostnameAsync(string hostname) => await _repository.GetByHostnameAsync(hostname);

        public async Task<Equipment> GetBySerialNumberAsync(string serialNumber) => await _repository.GetBySerialNumberAsync(serialNumber);

        public void Register(Equipment equipment) => _repository.Register(equipment);

        public async Task<Equipment> UpdateAsync(Equipment equipment)
        {
            await _repository.Update(equipment);
            return equipment;
        }
    }
}