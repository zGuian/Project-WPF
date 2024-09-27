using Microsoft.EntityFrameworkCore;
using Register.Desktop.Domain.Entities;
using Register.Desktop.Infra.Data.AppDataContext;
using Register.Desktop.Infra.Data.Interfaces;

namespace Register.Desktop.Infra.Data.Repository
{
    public class RepositoryEquipment : IRepositoryEquipment
    {
        private readonly AppDbContext _context = null!;

        public RepositoryEquipment()
        { }

        public RepositoryEquipment(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Equipment>> GetAllAsync()
        {
            List<Equipment> equipFound = await _context.Equipments.ToListAsync();
            if (equipFound.Count == 0)
            {
                throw new Exception("Not found equipments");
            }
            return equipFound;
        }

        public async Task<Equipment> GetByIdAsync(int id)
        {
            return await _context.Equipments.FirstOrDefaultAsync(e => e.Id == id)
                ?? throw new Exception($"not found equipment by id:{id}.");
        }

        public async Task<Equipment> GetByInventory(string inventory)
        {
            return await _context.Equipments.FirstOrDefaultAsync(e => e.Inventory == inventory)
                ?? throw new Exception($"not found equipment by inventory{inventory}.");
        }

        public async Task<Equipment> GetByHostnameAsync(string hostname)
        {
            return await _context.Equipments.FirstOrDefaultAsync(e => e.Hostname == hostname)
                ?? throw new Exception($"not found equipment by hostname:{hostname}.");
        }

        public async Task<Equipment> GetBySerialNumberAsync(string serialNumber)
        {
            return await _context.Equipments.FirstOrDefaultAsync(e => e.SerialNumber == serialNumber)
                ?? throw new Exception("SerialNumber not registed.");
        }

        public void Register(Equipment equipment)
        {
            _context.Equipments.Add(equipment);
            _context.SaveChanges();
        }

        public Task Update(Equipment equipment)
        {
            _context.Equipments.Update(equipment);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public void DisableEquipment(Equipment equipment)
        {
            _context.Equipments.Update(equipment);
            _context.SaveChanges();
        }
    }
}