using HomeWork.Models;
using HomeWork.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentController(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: Student
        public  IActionResult Index()
        {
            var students =  _studentRepository.GetAll();
            return View(students);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View(new Student());
        }

        // POST: Student/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                 _studentRepository.Add(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Details/5
        public  IActionResult Details(int id)
        {
            var student =  _studentRepository.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public IActionResult Edit(int id)
        {
            var student =  _studentRepository.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                 _studentRepository.Update(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public IActionResult Delete(int id)
        {
            var student =  _studentRepository.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
             _studentRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
