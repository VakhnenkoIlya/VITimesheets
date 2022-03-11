using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VI.Timesheets.API.Data.EFCore;
using VI.Timesheets.API.Data.Interfaces;
using VI.Timesheets.API.Models.Entities;

namespace VI.Timesheets.API.Data.Implementation
{
    public class UserRepo : IUserRepo
    {
        private readonly TimesheetDbContext _context;
        public UserRepo(TimesheetDbContext context)
        {
            _context = context;
        }
        public async Task Add(User item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
        }

        public Task CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
