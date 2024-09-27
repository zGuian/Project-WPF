﻿using Register.Desktop.Domain.Entities;

namespace Register.Desktop.Application.Interfaces
{
    public interface IServicesEquipment
    {
        Task<Equipment> GetByHostnameAsync(string hostname);
        Task<Equipment> GetByIdAsync(int id);
        Task<Equipment> GetByInventory(string inventory);
        Task<Equipment> GetBySerialNumberAsync(string serialNumber);
        void Register(Equipment equipment);
        Task<Equipment> UpdateAsync(Equipment equipment);
    }
}
