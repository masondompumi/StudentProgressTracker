using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentProgressTracker.Data;
using StudentProgressTracker.Interfaces;
using StudentProgressTracker.Models;

namespace StudentProgressTracker.Controllers
{
    public class EnrollmentController : Controller
    {

        private readonly IEnrollmentRepository _enrollmentRepository;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EnrollmentController(IEnrollmentRepository studentRepository, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _enrollmentRepository = studentRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: StudentController
        public async Task<IActionResult> Index()
        {
            var enrollments = await _enrollmentRepository.GetAllAsync();

            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);

            if (user != null)
            {
                var roles = await _userManager.GetRolesAsync(user); // returns List<string>

                // Example: check for a specific role
                bool isViewer = roles.Contains("Viewer");

                return Forbid();
            }

            if (!user.IsAdmin && user.PersonId != null)
                return View(await _enrollmentRepository.GetByStudentIdAsync(user.PersonId ?? 0));

            return View(await _enrollmentRepository.GetAllAsync());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);

            if (user != null)
            {
                var roles = await _userManager.GetRolesAsync(user); // returns List<string>

                // Example: check for a specific role
                bool isViewer = roles.Contains("Viewer");

                return Forbid();
            }

            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
