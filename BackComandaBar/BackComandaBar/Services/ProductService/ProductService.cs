using BackComandaBar.Database;
using BackComandaBar.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BackComandaBar.Services.ProductService
{
    public class ProductService
    {
        public readonly IMongoCollection<ProductModel> _productCollection;

        public ProductService(
            IOptions<ComandaBarDatabaseSettings> comandaBarDatabaseSettings)
        {

            
        }
    }
}
