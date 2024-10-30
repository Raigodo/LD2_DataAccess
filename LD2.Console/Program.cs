using Lab2.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Text.Json;

var serviceCollection = new ServiceCollection()
    .AddDbContext<AppDbContext>();

using (var scope = serviceCollection.BuildServiceProvider())
using (var dbContext = scope.GetRequiredService<AppDbContext>())
{
    await GetmanyAsync(dbContext);
    await GetOneAsync(dbContext);
    await AddOneAsync(dbContext);
    await ModiffyOneAsync(dbContext);
    await RemoveOneAsync(dbContext);
    await AddStudent(dbContext);
    await AddStudent(dbContext);
    await RemoveAllStudents(dbContext);
}

async Task GetmanyAsync(AppDbContext dbContext)
{
    Console.WriteLine("------------------ Get Many ---------------");
    var options = new JsonSerializerOptions { WriteIndented = true };
    var courses = await dbContext.Courses
        .Where(c => c.InstructorId == 1)
        .ToArrayAsync();
    Console.WriteLine(JsonSerializer.Serialize(courses, options));
}

async Task GetOneAsync(AppDbContext dbContext)
{
    Console.WriteLine("------------------- Get One ---------------");
    var options = new JsonSerializerOptions { WriteIndented = true };
    var instructor = await dbContext.Instructors
        .Where(i => i.Id == 1)
        .FirstOrDefaultAsync();
    Console.WriteLine(JsonSerializer.Serialize(instructor, options));
}

async Task AddOneAsync(AppDbContext dbContext)
{
    Console.WriteLine("------------------- Add One ---------------");
    var options = new JsonSerializerOptions { WriteIndented = true };

    var instructors = await dbContext.Instructors
        .ToArrayAsync();
    Console.WriteLine(JsonSerializer.Serialize(instructors, options));

    var instructor = new Instructor
    {
        Id = 0,
        Name = "third instructor",
        Surname = "cccccccccc",
        JoinedOn = DateOnly.FromDateTime(DateTime.UtcNow)
    };
    dbContext.Instructors.Add(instructor);
    await dbContext.SaveChangesAsync();

    instructors = await dbContext.Instructors
        .ToArrayAsync();
    Console.WriteLine(JsonSerializer.Serialize(instructors, options));
}
async Task ModiffyOneAsync(AppDbContext dbContext)
{
    Console.WriteLine("----------------- Modiffy One -------------");
    var options = new JsonSerializerOptions { WriteIndented = true };

    var instructor = await dbContext.Instructors
        .OrderByDescending(i => i.JoinedOn)
        .FirstOrDefaultAsync();
    Console.WriteLine(JsonSerializer.Serialize(instructor, options));

    instructor!.Surname = "bbbbbbbbb (modified)";
    await dbContext.SaveChangesAsync();

    instructor = await dbContext.Instructors
        .OrderByDescending(i => i.JoinedOn)
        .FirstOrDefaultAsync();
    Console.WriteLine(JsonSerializer.Serialize(instructor, options));
}

async Task RemoveOneAsync(AppDbContext dbContext)
{
    Console.WriteLine("----------------- Remove One --------------");
    var options = new JsonSerializerOptions { WriteIndented = true };

    var instructors = await dbContext.Instructors
        .ToArrayAsync();
    Console.WriteLine(JsonSerializer.Serialize(instructors, options));

    var instructor = await dbContext.Instructors
        .OrderByDescending(i => i.JoinedOn)
        .FirstOrDefaultAsync();

    dbContext.Remove(instructor!);
    dbContext.SaveChanges();
    await dbContext.SaveChangesAsync();

    instructors = await dbContext.Instructors
        .ToArrayAsync();
    Console.WriteLine(JsonSerializer.Serialize(instructors, options));
}

async Task AddStudent(AppDbContext dbContext)
{
    Console.WriteLine("----------------- Add Student -------------");
    var options = new JsonSerializerOptions { WriteIndented = true };

    var student = new Student()
    {
        Name = "some student",
    };
    var course = await dbContext.Courses
        .Include(c => c.Students)
        .FirstOrDefaultAsync();
    course!.Students.Add(student);
    await dbContext.SaveChangesAsync();

    var students = await dbContext.Students.ToArrayAsync();
    Console.WriteLine(JsonSerializer.Serialize(students, options));
}

async Task RemoveAllStudents(AppDbContext dbContext)
{
    Console.WriteLine("------------ Remove All Students ----------");
    var options = new JsonSerializerOptions { WriteIndented = true };

    var student = new Student()
    {
        Name = "some student",
    };
    var course = await dbContext.Courses
        .Include(c => c.Students)
        .FirstOrDefaultAsync();
    course!.Students.Clear();
    await dbContext.SaveChangesAsync();

    var students = await dbContext.Students.ToArrayAsync();
    Console.WriteLine(JsonSerializer.Serialize(students, options));
}