using AspRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRazorPages.Pages;

public class PersonSkillCreateModel(IPersonDataProvider dataProvider) : PageModel
{
    [BindProperty]
    public Skill Skill { get; set; }

    public void OnGet(int personId)
    {
        Skill = new Skill();
    }

    public IActionResult OnPost(int personId)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var person = dataProvider.GetById(personId);

        person.Skills.Add(Skill);
        dataProvider.SaveChanges();

        return RedirectToPage("/PersonSkills", new { id = personId });
    }
}