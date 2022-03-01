using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VI.Timesheets.API.Data.EFCore;

namespace VI.Timesheets.API.Data
{
    public interface IRepoBase<T>
    {
        Task<T> GetItem(int id);
        Task Add(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}
