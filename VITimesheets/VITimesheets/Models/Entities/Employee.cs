using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VI.Timesheets.API.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Sheet> Sheets { get; set; }
    }
}
