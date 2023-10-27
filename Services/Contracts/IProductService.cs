using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        
        Product? GetOneProduct(int id, bool trackChanges);

        void CreateProduct(ProductDtoForInsertion productDto);
        void UpdateProduct(ProductDtoForUpdate productDto);
        void DeleteProduct(int id);
        ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges);
    }
}