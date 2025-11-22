using AspRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRazorPages.Pages.Shared
{
    public class TableModel : PageModel
    {
		public Person Person { get; set; }
		public void OnGet()
        {
        }
    }
}
