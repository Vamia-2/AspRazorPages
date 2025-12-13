using AspRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AspRazorPages.Pages;

public class PersonCreateModel(IPersonDataProvider dataProvider, IWebHostEnvironment environment) : PageModel
{
    [BindProperty]
    public Person Person { get; set; } = new Person();

    [BindProperty]
    [Display(Name = "��������")]
    public IFormFile? AvatartImage { get; set; }
    public object Resume { get; set; }

    // GET /PersonCreate
    public IActionResult OnGet()
    {
        return Page();
    }

    // POST /PersonCreate
    public IActionResult OnPost()
    {
        // �������� �������� �����
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (AvatartImage != null)
        {
            // ������������� �������� (��������) ���� ���� 

            var uploadDir = Path.Combine(environment.WebRootPath, "uploads", "avatars");
            // ��������� �������� ���� �� �� ����
            if (!Directory.Exists(uploadDir))
            {
                Directory.CreateDirectory(uploadDir);
            }
            // ��������� ����������� ����� �����
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(AvatartImage.FileName)}";
            // ������ ���� �� �����
            var filePath = Path.Combine(uploadDir, fileName);

            // ���������� �����
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                AvatartImage.CopyTo(fileStream);
            }
            // ������������ ����� �� �������� � ������ Person
            Person.AvatarImageSrc = $"/uploads/avatars/{fileName}";

        }
        if (Resume != null)
        {
            // ������������� �������� (��������) ���� ���� 

            var uploadDir = Path.Combine(environment.WebRootPath, "uploads", "resume");
            // ��������� �������� ���� �� �� ����
            if (!Directory.Exists(uploadDir))
            {
                Directory.CreateDirectory(uploadDir);
            }
            // ��������� ����������� ����� �����
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(Resume.FileName)}";
            // ������ ���� �� �����
            var filePath = Path.Combine(uploadDir, fileName);

            // ���������� �����
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                Resume.CopyTo(fileStream);
            }
            // ������������ ����� �� �������� � ������ Person
            Person.AvatarImageSrc = $"/uploads/resume/{fileName}";

        }

        dataProvider.Add(Person);
        dataProvider.SaveChanges();
        return RedirectToPage("Persons");
    }
}