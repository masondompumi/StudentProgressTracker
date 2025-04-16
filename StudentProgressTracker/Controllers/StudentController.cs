using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProgressTracker.DTOs;
using StudentProgressTracker.Interfaces;
using StudentProgressTracker.Models;

namespace StudentProgressTracker.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _studentRepository.GetAllAsync();

            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentDTO student)
        {
            try
            {
                Student studentToUpdate = new Student();

                studentToUpdate.Id = student.Id;
                studentToUpdate.LastName = student.LastName;
                studentToUpdate.FirstName = student.FirstName;
                studentToUpdate.Email = student.Email;
                studentToUpdate.IdNumber = student.IdNumber;
                studentToUpdate.ProfileImage = studentToUpdate.ProfileImage;

                if (student.ProfileImageFile != null && student.ProfileImageFile.Length > 0)
                {
                    using var ms = new MemoryStream();
                    await student.ProfileImageFile.CopyToAsync(ms);
                    studentToUpdate.ProfileImage = ms.ToArray();
                }

                await _studentRepository.AddAsync(studentToUpdate);
                await _studentRepository.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);

            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            try
            {
                _studentRepository.UpdateAsync(student);
                await _studentRepository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            return View(student);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Student student)
        {
            try
            {
                _studentRepository.DeleteAsync(student);
                await _studentRepository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
