using BusinessLogicLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public interface IProductRepository
    {
        public void AddProduct(Product product);
        public DataTable DisplayProducts();
        public DataTable ShowProductsByFilters(string brand, string type, string name);
        public List<string> PopulateFilterBoxByType(string type);
        public void DeleteProduct(int id);
        public Product GetProductById(int id);
        public List<Product> GetListOfProducts();
        public void UpdateProtein(Protein protein);
        public void UpdateClothing(Clothing clothing);
        public void UpdateVitamins(Vitamins vitamins);
    }
}