using CQRSMediatorExample.Models;

using MediatR;

namespace CQRSMediatorExample.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;

    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
