using AspRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRazorPages.Pages;

public class PersonSkillEditModel(IPersonDataProvider dataProvider) : PageModel
{
    [BindProperty]
    public Skill Skill { get; set; }

    public void OnGet(int personId, int skillId)
    {
        var person = dataProvider.GetById(personId);
        Skill = person.Skills.First(s => s.Id == skillId);
    }

    public IActionResult OnPost(int personId, int skillId)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var person = dataProvider.GetById(personId);
        var skill = person.Skills.First(s => s.Id == skillId);

        skill.Title = Skill.Title;
        skill.Level = Skill.Level;

        dataProvider.SaveChanges();

        return RedirectToPage("/PersonSkills", new { id = personId });
    }
}