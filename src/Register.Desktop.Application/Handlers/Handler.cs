using MediatR;
using Register.Desktop.Application.Commands.Requests;
using Register.Desktop.Application.Commands.Responses;
using Register.Desktop.Application.Interfaces;

namespace Register.Desktop.Application.Handlers
{
    public abstract class Handler<T> : IRequestHandler<Requests<T>, Responses<T>>, IHandler<T>
        where T : class
    {
        public abstract Task<Responses<T>> Handle(Requests<T> request, CancellationToken cancellationToken);
    }
}
