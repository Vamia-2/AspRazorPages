using AspRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRazorPages.Pages;

public class PersonSkillsModel(IPersonDataProvider dataProvider) : PageModel
{
    public Person Person { get; set; }
    public List<Skill> Skills { get; set; }

    public void OnGet(int id)
    {
        var person = dataProvider.GetById(id);
        Person = person;
        Skills = person.Skills;
    }
}

/*
 * ������ ������� ��� ��������� �� ����������� ������� (Skills) ��� ��������� ����� (Person).
 * 
 */ 