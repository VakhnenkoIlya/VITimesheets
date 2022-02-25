using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VI.Timesheets.API.Data
{
    interface IRepoBase<T>
    {
        Task<T> GetItem(Guid id);
        Task Add(T item);
        Task Update(T item);
        Task Delete(Guid id);
    }
}
