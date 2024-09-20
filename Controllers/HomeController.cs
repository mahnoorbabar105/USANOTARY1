using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using USANotary.Models;
using System.Threading.Tasks;
using System;

namespace USANotary.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeModelContext _context;

        public HomeController(EmployeeModelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Username, string Password)
        {
            var user = _context.Employees
                .SingleOrDefault(u => u.Username == Username && u.Password == Password);

            if (user != null)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                ViewData["InvalidLogin"] = true;
                return View();
            }
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(employee);
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateJob()
        {
            var viewModel = new JobDataViewModel();
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Submit(JobDataViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var jobData = new JobData
                    {
                        TitleCompany = viewModel.TitleCompany,
                        ClosingType = viewModel.ClosingType,
                        InternalReference = viewModel.InternalReference,
                        KBARequired = viewModel.KBARequired,
                        PropertyAddress1 = viewModel.PropertyAddress1,
                        PropertyAddress2 = viewModel.PropertyAddress2,
                        PropertyCity = viewModel.PropertyCity,
                        PropertyState = viewModel.PropertyState,
                        PropertyZipCode = viewModel.PropertyZipCode,
                    };

                    await _context.JobData.AddAsync(jobData);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Submit");
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine($"Database update error: {ex.InnerException?.Message}");
                    ViewData["ErrorMessage"] = "An error occurred while saving the job data. Please try again.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                    ViewData["ErrorMessage"] = "An unexpected error occurred. Please contact support.";
                }
            }

            return View("CreateJob", viewModel);
        }

        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ShowData()
        {
            var jobDataList = await _context.JobData.ToListAsync();
            return View(jobDataList);
        }
        [HttpGet]
        public async Task<IActionResult> LoginInfo()
        {
            var employeeList = await _context.Employees.ToListAsync();
            return View(employeeList);
        }
    }
}
