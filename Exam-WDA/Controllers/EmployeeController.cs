using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Exam_WDA.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam_WDA.Controllers
{
    [ApiController]
    [Route("api/Employee")]

    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _context;
        public EmployeeController(DataContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        [HttpGet]
    }
    }
}
    


