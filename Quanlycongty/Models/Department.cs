using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Quanlycongty.Models
{
	public class Department
	{
		public int DepartmentId { get; set; }
		public string Name { get; set; }
		public int Code { get; set; }
		public string Location { get; set; }

		public int NumberOfPersonnel { get; set; }
		public string Employee { get; set; } 
		
		}
}
