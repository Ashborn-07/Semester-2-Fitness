using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessWeb.Pages
{
    public class DietPageModel : PageModel
    {
        private DietService service;
        public List<Diet> diets;

        public void OnGet()
        {
            IDietsRepository repository = new DietsRepository();
            service = new DietService(repository);

            diets = service.GetListOfDiets();
        }
    }
}
