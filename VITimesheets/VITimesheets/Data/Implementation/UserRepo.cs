using Microsoft.Extensions.DependencyInjection;
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

        public async Task Add(User entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            _context.Remove(_context.Users.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetItem(int id)
        {
            var result = await _context.Users.FindAsync(id);
            return result;
        }

        public async Task Update(User entity)
        {
            await _context.SaveChangesAsync();
        }
    }
}
