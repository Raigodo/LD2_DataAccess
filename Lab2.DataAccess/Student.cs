using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Lab2.DataAccess;

public class Student
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(maximumLength: 20, MinimumLength = 3)]
    public string Name { get; set; }

    public List<Course> Courses { get; set; }
}
