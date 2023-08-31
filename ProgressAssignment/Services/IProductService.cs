using ProgressAssignment.Models;

namespace ProgressAssignment.Services;

public interface IProductService
{
    Task<Product[]> GetProducts(string route);
}
