namespace AspRazorPages.Models;

public interface IPersonDataProvider
{
    public List<Person> GetAll();

    public Person GetById(int id);

    public void Add(Person person);

    public void SaveChanges();
}