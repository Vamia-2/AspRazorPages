namespace AspRazorPages.Models
{
    public interface SkillProvider
    {
        public List<Skill> GetAll();
        public Person GetById(int id);

        public void Add(Skill skill);

        public void SaveChanges();
    }
}
