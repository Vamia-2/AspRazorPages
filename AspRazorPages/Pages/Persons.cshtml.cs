using AspRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRazorPages.Pages;

public class PersonsModel(IPersonDataProvider dataProvider) : PageModel
{
    public List<Person> Persons { get; set; }

    public void OnGet()
    {
        Persons = dataProvider.GetAll();
    }
}