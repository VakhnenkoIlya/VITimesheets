using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VI.Timesheets.API.Models.Entities;

namespace VI.Timesheets.API.Data.Interfaces
{
    interface IContractRepo : IRepoBase<Contract>
    {
        Task<bool?> CheckContractIsActive(Guid id);
    }
}
