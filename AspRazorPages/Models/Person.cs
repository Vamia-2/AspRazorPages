using AspRazorPages.Models;
using System.ComponentModel.DataAnnotations;

namespace AspRazorPages.Models;

public class Person
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Заповніть своє ім'я")]
    [MaxLength(50, ErrorMessage = "Ім'я не може бути довшим за 50 символів")]
    [MinLength(2, ErrorMessage = "Ім'я не може бути коротшим за 2 символи")]
    [Display(Name = "Ім'я")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Заповніть свій опис")]
    [MaxLength(500, ErrorMessage = "Опис не може бути довшим за 500 символів")]
    [MinLength(10, ErrorMessage = "Опис не може бути коротшим за 10 символів")]
    [Display(Name = "Опис")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Заповніть свій email")]
    [EmailAddress(ErrorMessage = "Некоректний формат email")]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Заповніть свою дату народження")]
    [Display(Name = "Дата народження")]
    public DateTime Birthday { get; set; }

    public List<Skill> Skills { get; set; } = [];

    [Display(Name = "Аватарка")]
    public string? AvatarImageSrc { get; set; } = null;
    [Display(Name = "Резюме")]
    public string? Resume { get; set; } = null;

}