using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogicLayer;
using System.Data;
using Xunit;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ProductServiceUnitTests
    {
        [Fact]
        public void GetProductByIdReturnsDummyProduct()
        {
            //Arrange
            IProductRepository repository = new ProductMockRepo();
            Product dummyProduct = new Product("name", "brand", "asd", ProductType.TABLETS, 13, null);
            ProductService service = new ProductService(repository);

            //Act
            Product p = service.DisplayProductInformation(3);

            //Assert
            Xunit.Assert.Equal(p.Name, dummyProduct.Name);
        }

        //downside of datatables
        //doesn't work
        [Fact]
        public void ReturnProductsTableWhichIsNull()
        {
            //Arrange
            IProductRepository repository = new ProductMockRepo();
            ProductService service = new ProductService(repository);

            //Act
            DataTable dt = service.DisplayProducts();

            //Assert
            Xunit.Assert.Null(dt);
        }

        [Fact]
        public void ReturnListOfProducts()
        {
            //Arrange
            IProductRepository repository = new ProductMockRepo();
            ProductService service = new ProductService(repository);

            List<Product> dummyList = new List<Product>();
            dummyList.Add(new Product("name", "brand", "asd", ProductType.TABLETS, 13, null));
            dummyList.Add(new Product("name1", "brand1", "asd1", ProductType.TABLETS, 14, null));

            //Act
            List<Product> pro = service.GetListOfProducts();

            //Assert
            Xunit.Assert.Equal(pro.Count, dummyList.Count);
        }

        [Fact]
        public void SaveProductToMockRepo()
        {
            //Arrange
            IProductRepository repository = new ProductMockRepo();
            ProductService service = new ProductService(repository);

            ProductMockRepo dummyMockRepo = new ProductMockRepo();
            Product product = new Product("asd", "asd", "asd", ProductType.TABLETS, 13, null);

            //Act
            service.AddProduct(product);
            List<Product> list = dummyMockRepo.GetListOfProducts();
            List<Product> pro = service.GetListOfProducts();
           
            //Assert
            Xunit.Assert.Equal(pro.Count, list.Count);
        }
    }
}