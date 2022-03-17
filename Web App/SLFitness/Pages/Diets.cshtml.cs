using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using SLFitness.Logic;
using SLFitness.Models;

namespace SLFitness.Pages
{
    public class DietsModel : PageModel
    {
        public List<Diet> diets = new List<Diet>();

        public void OnGet()
        {
            DataAccess data = new DataAccess();
            diets = data.GetList();
        }
    }
}
