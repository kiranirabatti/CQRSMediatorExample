using CQRSMediatorExample.Commands;
using CQRSMediatorExample.Data;
using CQRSMediatorExample.Models;

using MediatR;

namespace CQRSMediatorExample.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public AddProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.AddProduct(request.Product, _products);

            return request.Product;
        }
    }
}
