using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessWeb.Pages
{
    public class ProductPageModel : PageModel
    {
        public List<Product> products;
        private ProductService service;
        public void OnGet()
        {
            IProductRepository repository = new ProductRepository();
            service = new ProductService(repository);
            products = repository.GetListOfProducts();
        }
    }
}
