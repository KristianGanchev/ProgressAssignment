using ProgressAssignment.Models;
using System.Net.Http.Json;

namespace ProgressAssignment.Services;

public class ProductService : IProductService
{
    private readonly HttpClient http;

    public ProductService(HttpClient http)
    {
        this.http = http;
    }

    public async Task<Product[]> GetProducts(string route)
    {
        var products = await this.http.GetFromJsonAsync<Product[]>(route);

        if (products == null)
        {
            throw new ArgumentNullException("No products found.");
        }

        return products;
    }
}
