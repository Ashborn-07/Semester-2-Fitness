using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ProductService
    {
        private IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public void AddProduct(Product product)
        {
            repository.AddProduct(product);
        }

        public DataTable DisplayProducts()
        {
            return repository.DisplayProducts();
        }

        public DataTable DisplayProductsByFilter(string brand, string type, string priceFilter)
        {
            return repository.ShowProductsByFilters(brand, type, priceFilter);
        }

        public List<string> PopulateFilterBox(string cbType)
        {
            return repository.PopulateFilterBoxByType(cbType);
        }

        public void DeleteProduct(int id)
        {
            repository.DeleteProduct(id);
        }

        public Product DisplayProductInformation(int id)
        {
            return repository.GetProductById(id);
        }

        public List<Product> GetListOfProducts()
        {
            return repository.GetListOfProducts();
        }

        public void UpdateProduct(Product product)
        {
            switch (product)
            {
                case Clothing:
                    repository.UpdateClothing((Clothing)product);
                    break;
                case Protein:
                    repository.UpdateProtein((Protein)product);
                    break;
                case Vitamins:
                    repository.UpdateVitamins((Vitamins)product);
                    break;
            }
        }
    }
}
