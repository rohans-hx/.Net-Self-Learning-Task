using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models;

public class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter your name.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be 2 to 50 characters long.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address, like name@example.com.")]
    [StringLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please choose a course.")]
    [StringLength(60)]
    public string Course { get; set; } = string.Empty;

    [Range(1, 8, ErrorMessage = "Semester must be a number from 1 to 8.")]
    public int Semester { get; set; }
}
