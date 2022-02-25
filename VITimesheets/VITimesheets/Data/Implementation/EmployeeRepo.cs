using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VI.Timesheets.API.Data.Interfaces;
using VI.Timesheets.API.Models.Entities;

namespace VI.Timesheets.API.Data.Implementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public Task Add(Employee item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
