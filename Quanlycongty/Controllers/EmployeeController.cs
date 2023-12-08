using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Quanlycongty.Models;

namespace Quanlycongty.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly ApplicationDbContext _context;

		public EmployeeController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: Employees/Create
		public IActionResult Create()
		{
			ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "Name");
			return View();
		}

		// POST: Employees/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("EmployeeId,Name,DepartmentId")] Employee employee)
		{
			if (ModelState.IsValid)
			{
				_context.Add(employee);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "Name", employee.DepartmentId);
			return View(employee);
		}
	}
}

