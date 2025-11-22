using AspRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRazorPages.Pages
{
    public class InfoModel : PageModel
    {
        public Person Person { get; set; }
        public void OnGet()
        {
            Person = new Person
            {
                Id = 1,
                Name = "Ivan",
                Description = "Web developer",
                Email = "test@test.com",
                Birthday = new DateTime(2008,7,17),
                Skills =
                [
                    new Skill
                    {
                        Id = 1,
                        Title = "C#",
                        Level = 15
                    },
					new Skill
					{
						Id = 2,
						Title = "JS",
						Level = 10
					},
					new Skill
					{
						Id = 3,
						Title = "HTML/CSS",
						Level = 25
					},
					new Skill
					{
						Id = 4,
						Title = "SQL",
						Level = 10
					},

				]
            };
        }
    }
}
