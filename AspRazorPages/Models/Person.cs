namespace AspRazorPages.Models;

	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Email { get; set; }
		public DateTime Birthday { get; set; }
	    public List<Skill> Skills { get; set; }
	}

