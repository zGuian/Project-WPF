using MediatR;
using Register.Desktop.Application.Commands.Responses;

namespace Register.Desktop.Application.Commands.Requests
{
    public class Requests<T> : IRequest<Responses<T>>
        where T : class
    {
        public ICollection<T> Data { get; set; } = null!;
        public string? Message { get; set; }

        public Requests(ICollection<T> data, string? message = null)
        {
            Data = data;
            Message = message;
        }

        public Requests(T data, string? message = null)
        {
            Data.FirstOrDefault(data);
            Message = message;
        }
    }
}
