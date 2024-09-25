using Register.Desktop.Application.Commands.Requests;
using Register.Desktop.Application.Commands.Responses;

namespace Register.Desktop.Application.Interfaces
{
    public interface IHandler<T> where T : class
    {
        Task<Responses<T>> Handle(Requests<T> request, CancellationToken cancellationToken);
    }
}
