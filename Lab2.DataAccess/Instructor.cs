using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab2.DataAccess;

public class Instructor
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(maximumLength: 20, MinimumLength = 3)]
    public string Name { get; set; }

    [Required]
    [StringLength(maximumLength: 20, MinimumLength = 3)]
    public string Surname { get; set; }

    [Required]
    public DateOnly JoinedOn { get; set; }

    [JsonIgnore]
    public List<Course> Courses { get; } = [];
}
