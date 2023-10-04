using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Exam_WDA.Entities;

public class DataContext : DbContext
{
	public DataContext()
	{
	}
	public DataContext(DbContextOptions<DataContext> options)
		: base(options)
	{
	}
    public virtual DbSet<Department_Tbl> Carts { get; set; }

    public virtual DbSet<Employee_Tbl> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{

	}

}