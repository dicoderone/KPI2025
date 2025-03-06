using KPIdomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIapplication.Abstraction
{
    public interface ITeacherService
    {
        public Task<Student> ListStudent { get; set; }
    }
}
