using KPIapplication.Abstraction;
using KPIapplication.Repositories;
using KPIdomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIapplication.Services
{
    public class TeacherService 
    {
        private readonly IApplicationDbContext _context;

        public TeacherService(IApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<Student> ListStudent()
        //{
        //    //    var teacher = _context.Teachers
        //    //        .Include(t => t.Students)
        //    //            .ThenInclude(s => s.Grades)
        //    //                .ThenInclude(g => g.Subject)
        //    //        .FirstOrDefault(t => t.Id == id);
        //    //}
        //    var teacher = await _context.Teachers.Include(t => t.Students).ThenInclude(s => s.Grades).ThenInclude(g => g.Subject).FirstOrDefaultAsync();
        //    return teacher;

        //}
    }
}
