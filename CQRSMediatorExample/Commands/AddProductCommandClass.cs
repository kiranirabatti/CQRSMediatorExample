using CQRSMediatorExample.Models;

using MediatR;

namespace CQRSMediatorExample.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
