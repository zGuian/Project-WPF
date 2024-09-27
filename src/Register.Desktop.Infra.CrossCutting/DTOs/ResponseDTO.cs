namespace Register.Desktop.Infra.CrossCutting.DTOs
{
    public class ResponseDTO<T> where T : class
    {
        public T Datas { get; set; } = null!;
        public string? Message { get; set; }

        public ResponseDTO()
        { }

        public ResponseDTO(T datas, string? message = null)
        {
            Datas = datas;
            Message = message;
        }
    }
}