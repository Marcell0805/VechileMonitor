using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VechileMonitor.Domain.Entities;

namespace VechileWebApp.Pages.WebPages
{
    public class VechileAlterModel : PageModel
    {
        public List<Vechile> vechileDetials { get; set; } = new();
        public void OnGet()
        {
            
        }
    }
}
