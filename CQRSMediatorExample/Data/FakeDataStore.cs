﻿using CQRSMediatorExample.Models;

namespace CQRSMediatorExample.Data
{
    public class FakeDataStore
    {
        private static List<Product>? _products = null;
        public FakeDataStore()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Test Product 1" },
                new Product { Id = 2, Name = "Test Product 2" },
                new Product { Id = 3, Name = "Test Product 3" }
            };
        }
        public async Task AddProduct(Product product, List<Product>? _products)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(_products);

        public async Task<Product> GetProductById(int id) => await Task.FromResult(_products.Single(p => p.Id == id));
    }
}
