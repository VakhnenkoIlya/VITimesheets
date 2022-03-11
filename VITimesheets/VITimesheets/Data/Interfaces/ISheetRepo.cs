using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VI.Timesheets.API.Models.Entities;

namespace VI.Timesheets.API.Data.Interfaces
{
    interface ISheetRepo : IRepoBase<Sheet>
    {
        Task<IEnumerable<Sheet>> GetItemsForInvoice(Guid contractId, DateTime dateStart, DateTime dateEnd);
    }
}
