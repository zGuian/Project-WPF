using Register.Desktop.Domain.Entities;

namespace Register.Desktop.Infra.Data.Interfaces
{
    public interface IRepositoryEquipment
    {
        void DisableEquipment(Equipment equipment);
        Task<IEnumerable<Equipment>> GetAllAsync();
        Task<Equipment> GetByHostnameAsync(string hostname);
        Task<Equipment> GetByIdAsync(int id);
        Task<Equipment> GetByInventory(string inventory);
        Task<Equipment> GetBySerialNumberAsync(string serialNumber);
        void Register(Equipment equipment);
        Task Update(Equipment equipment);
    }
}