using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using System.Data;

namespace UnitTest
{
    internal class ProductMockRepo : IProductRepository
    {
        private List<Product> _products = new List<Product>();

        public ProductMockRepo()
        {
            _products.Add(new Product("name", "brand", "asd", ProductType.TABLETS, 13, null));
            _products.Add(new Product("name1", "brand1", "asd1", ProductType.TABLETS, 14, null));
        }

        public void AddProduct(Product product)
        {

        }
        //downsides of using datatables
        public DataTable DisplayProducts()
        {
            //List<Product> products = new List<Product>();
            //products.Add(new Product("name", "brand", "asd", ProductType.TABLETS, 13, null));
            //products.Add(new Product("name1", "brand1", "asd1", ProductType.TABLETS, 14, null));

            DataTable dt = null;

            return dt;
        }
        public DataTable ShowProductsByFilters(string brand, string type, string name)
        {
            return null;
        }

        public List<string> PopulateFilterBoxByType(string type)
        {
            return null;
        }

        public void DeleteProduct(int id)
        {

        }

        public Product GetProductById(int id)
        {
            Product product = null;

            if (id == 3)
            {
                byte[] image = null;
                product = new Product("name", "brand", "asd", ProductType.TABLETS, 13, image);
            }

            return product;
        }
        public List<Product> GetListOfProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("name", "brand", "asd", ProductType.TABLETS, 13, null));
            products.Add(new Product("name1", "brand1", "asd1", ProductType.TABLETS, 14, null));

            return products;
        }

        public void UpdateProtein(Protein protein)
        {

        }

        public void UpdateClothing(Clothing clothing)
        {

        }

        public void UpdateVitamins(Vitamins vitamins)
        {

        }

        public bool GetProductByInfo(Product product)
        {
            return false;
        }

        public bool CheckIfProductExists(Product product)
        {
            return false;
        }
    }
}
