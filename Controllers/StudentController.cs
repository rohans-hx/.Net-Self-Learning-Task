using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers;

public class StudentController : Controller
{
    
    private static readonly List<Student> _students = new()
    {
        new Student { Id = 1, Name = "Aarav Patel", Email = "aarav@example.com", Course = "B.Tech Computer Engineering", Semester = 5 },
        new Student { Id = 2, Name = "Diya Shah",   Email = "diya@example.com",  Course = "B.Tech Information Technology", Semester = 3 }
    };
    private static int _nextId = 3;

    private static readonly string[] _courses =
    {
        "B.Tech Computer Engineering",
        "B.Tech Information Technology",
        "B.Tech Electrical Engineering",
        "BCA",
        "MCA"
    };

    // GET: /Student  -> list of students
    public IActionResult Index()
    {
        return View(_students);   // pass data from Controller to View
    }

    // GET: /Student/Create  -> show empty form
    [HttpGet]
    public IActionResult Create()
    {
        LoadCourses();
        return View();
    }

    // POST: /Student/Create  -> model binding + validation
    [HttpPost]
    public IActionResult Create(Student student)
    {
        if (!ModelState.IsValid)
        {
            LoadCourses();
            return View(student);   // show form again with error messages
        }

        student.Id = _nextId++;
        _students.Add(student);
        TempData["Success"] = $"{student.Name} was registered.";
        return RedirectToAction(nameof(Index));
    }

    // GET: /Student/Details/5
    public IActionResult Details(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            return NotFound();
        }
        return View(student);
    }

    private void LoadCourses()
    {
        ViewBag.Courses = new SelectList(_courses);
    }
}
