using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VI.Timesheets.API.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
