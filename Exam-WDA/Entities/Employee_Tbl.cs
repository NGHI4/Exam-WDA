using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Exam_WDA.Entities
{
	public partial class Employee_Tbl
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? Code { get; set; }
		public string? Department { get; set; }
		public string? Rank { get; set; }
    }
}

