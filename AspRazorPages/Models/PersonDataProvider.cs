using AspRazorPages.Models;

namespace AspRazorPages.Models;

public class PersonDataProvider : IPersonDataProvider
{

    private List<Person> persons;

    public PersonDataProvider()
    {
        persons = [
            new Person
            {
                Id = 1,
                Name = "Vasyl Kovalov",
                Description = "Web developer",
                Email = "test@test.com",
                Birthday = new DateTime(2000, 1, 1),
                Skills = [
                new Skill
                {
                    Id = 1,
                    Title = "C#",
                    Level = 70
                },
                    new Skill
                    {
                        Id = 2,
                        Title = "JavaScript",
                        Level = 60
                    },
                    new Skill
                    {
                        Id = 3,
                        Title = "SQL",
                        Level = 50
                    },
                    new Skill
                    {
                        Id = 4,
                        Title = "HTML/CSS",
                        Level = 80
                    },
                    new Skill
                    {
                        Id = 5,
                        Title = "ASP.NET Core",
                        Level = 65
                    }
            ]
            },
            new Person
            {
                Id = 2,
                Name = "Anna Ivanova",
                Description = "Frontend developer",
                Email = "anna@test.com",
                Birthday = new DateTime(1995, 5, 15),
                Skills = [
                    new Skill
                    {
                        Id = 6,
                        Title = "JavaScript",
                        Level = 80
                    },
                    new Skill
                    {
                        Id = 7,
                        Title = "React",
                        Level = 70
                    },
                    new Skill
                    {
                        Id = 8,
                        Title = "HTML/CSS",
                        Level = 90
                    },
                    new Skill
                    {
                        Id = 9,
                        Title = "TypeScript",
                        Level = 60
                    }]
            },
            new Person
            {
                Id = 3,
                Name = "John Smith",
                Description = "Database administrator",
                Email = "smit@test.com",
                Birthday = new DateTime(1988, 10, 30),
                Skills = [
                    new Skill
                    {
                        Id = 10,
                        Title = "SQL",
                        Level = 85
                    },
                    new Skill
                    {
                        Id = 11,
                        Title = "Database Design",
                        Level = 75
                    },
                    new Skill
                    {
                        Id = 12,
                        Title = "Performance Tuning",
                        Level = 65
                    }]
            }
        ];
    }

    public void Add(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetAll()
    {
        return persons;
    }

    public Person GetById(int id)
    {
        return persons.FirstOrDefault(p => p.Id == id);
    }

    public void SaveChanges()
    {
        // No implementation needed for in-memory data
    }
}