﻿namespace Quanlycongty.Models
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string Name { get; set; }
		public int DepartmentId { get; set; }

		// Navigation property
		public Department Department { get; set; } 

	}
}
