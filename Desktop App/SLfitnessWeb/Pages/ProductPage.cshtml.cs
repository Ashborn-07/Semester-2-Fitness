using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;

namespace SLfitnessWeb.Pages
{
    [Authorize]
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
