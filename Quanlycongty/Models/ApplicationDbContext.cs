﻿using Microsoft.EntityFrameworkCore;


namespace Quanlycongty.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	   : base(options)
		{
		}

		public DbSet<Department> Departments { get; set; }

		public DbSet<Employee> Employees { get; set; }
	}
}
