namespace Register.Desktop.Domain.Entities
{
    public class Equipment
    {
        public string Name { get; private set; } = string.Empty;
        public string? Hostname { get; private set; }
        public string? Inventory { get; private set; }
        public string SerialNumber { get; private set; } = string.Empty;
        public string UserInsertion { get; private set; } = string.Empty;
        public DateTime Date { get; set; }


        public Equipment()
        {
        }

        public Equipment(string name, string? hostname, string? inventory, string serialNumber,
             string userInsertion)
        {
            ToAddEquipment(name, hostname, inventory, serialNumber, userInsertion);
        }

        private void ToAddEquipment(string name, string? hostname, string? inventory, string serialNumber, string userInsertion)
        {
            Name = name;
            Hostname = hostname;
            Inventory = inventory;
            SerialNumber = serialNumber;
            UserInsertion = userInsertion;
            Date = DateTime.Now.Date;
        }
    }
}