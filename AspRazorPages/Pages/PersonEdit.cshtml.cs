using AspRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRazorPages.Pages;

public class PersonEditModel(IPersonDataProvider dataProvider) : PageModel
{
    [BindProperty]
    public Person Person { get; set; }

    public void OnGet(int id)
    {
        Person = dataProvider.GetById(id);
    }

    public IActionResult OnPost(int id)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var existingPerson = dataProvider.GetById(id);

        existingPerson.Name = Person.Name;
        existingPerson.Description = Person.Description;
        existingPerson.Email = Person.Email;
        existingPerson.Birthday = Person.Birthday;

        dataProvider.SaveChanges();
        return RedirectToPage("Persons");
    }
}