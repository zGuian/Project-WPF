namespace Register.Desktop.Domain.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Modelo { get; private set; } = string.Empty;
        public string? Hostname { get; private set; }
        public string? Inventory { get; private set; }
        public string? SerialNumber { get; private set; } = string.Empty;
        public string UserInsertion { get; private set; } = string.Empty;
        public bool IsActive { get; private set; }
        public DateTime Date { get; set; }

        public Equipment()
        {
        }

        public Equipment(int id, string modelo, string? hostname, string? inventory, string serialNumber,
             string userInsertion, bool isActive)
        {
            Id = id;
            Modelo = modelo;
            Hostname = hostname;
            Inventory = inventory;
            SerialNumber = serialNumber;
            UserInsertion = userInsertion;
            IsActive = isActive;
            Date = DateTime.Now.Date;
        }
    }
}