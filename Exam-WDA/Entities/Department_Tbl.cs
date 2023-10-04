using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Exam_WDA.Entities
{
	public partial class Department_Tbl
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? Code { get; set; }
		public string? Location { get; set; }
		public int NumberOfPersonals { get; set; }
    }
}

