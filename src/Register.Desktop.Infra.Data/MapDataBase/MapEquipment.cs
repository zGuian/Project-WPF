using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Register.Desktop.Domain.Entities;

namespace Register.Desktop.Infra.Data.MapDataBase
{
    internal class MapEquipment : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable(nameof(Equipment));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(e => e.Modelo)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Hostname)
                .HasColumnName("hostname")
                .HasMaxLength(20);

            builder.Property(e => e.Inventory)
                .HasColumnName("inventory")
                .HasMaxLength(15);

            builder.Property(e => e.SerialNumber)
                .HasColumnName("serial_number")
                .HasMaxLength(50);

            builder.Property(e => e.UserInsertion)
                .HasColumnName("user_insertion")
                .HasMaxLength(50);

            builder.Property(e => e.IsActive)
                .HasColumnName("is_active")
                .HasMaxLength(5);

            builder.Property(e => e.Date)
                .HasColumnName("date")
                .HasDefaultValue(DateTime.Now.Date)
                .IsRequired();
        }
    }
}