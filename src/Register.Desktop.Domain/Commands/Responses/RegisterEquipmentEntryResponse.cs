namespace Register.Desktop.Domain.Commands.Responses
{
    public class RegisterEquipmentEntryResponse
    {
        public Guid NumberTransition { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public string Type { get; private set; } = string.Empty;
        public DateTime Date { get; private set; }

        public RegisterEquipmentEntryResponse()
        {
        }

        public RegisterEquipmentEntryResponse(string name, string description, string type)
        {
            NumberTransition = Guid.NewGuid();
            Name = name;
            Description = description;
            Type = type;
            Date = DateTime.Now;
        }
    }
}