namespace Register.Desktop.Application.Commands.Responses
{
    public class Responses<T> where T : class
    {
        public ICollection<T> Data { get; set; } = null!;
        public string? Message { get; set; }

        public Responses(ICollection<T> data, string? message = null)
        {
            Data = data;
            Message = message;
        }

        public Responses(T data, string? message = null) 
        {
            _ = Data.FirstOrDefault(data);
            Message = message;
        }
    }
}