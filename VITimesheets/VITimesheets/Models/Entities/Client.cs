using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VI.Timesheets.API.Models.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public Guid User { get; set; }
        public bool IsDeleted { get; set; }
    }
}
