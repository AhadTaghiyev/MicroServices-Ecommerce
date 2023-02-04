using MongoDB.Driver;
using WebApplication1.Entities;

namespace WebApplication1.Data.Interface
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
