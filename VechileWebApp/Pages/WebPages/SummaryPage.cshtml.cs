using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VechileMonitor.Domain.Entities;

namespace VechileWebApp.Pages.WebPages
{
    public class SummaryPageModel : PageModel
    {
        public List<ContractorSummary> detials { get; set; } = new();
        public void OnGet()
        {
            
        }
    }
}
