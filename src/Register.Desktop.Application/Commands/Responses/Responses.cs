namespace Register.Desktop.Application.Commands.Responses
{
    public class Responses<T> where T : class
    {
        public int? TotalCount { get; set; }
        public ICollection<T> Datas { get; set; } = null!;
        public string? Message { get; set; }

        public Responses()
        { }

        public Responses(ICollection<T> datas, int totalCount, string? message = null)
        {
            Datas = datas;
            TotalCount = totalCount;
            Message = message;
        }

        public Responses(T data, string? message = null)
        {
            Datas = [data];
            Message = message;
        }
    }
}