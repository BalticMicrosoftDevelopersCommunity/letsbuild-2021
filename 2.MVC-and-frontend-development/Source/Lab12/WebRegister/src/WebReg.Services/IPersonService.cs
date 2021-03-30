using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebReg.Data.Models;
using WebReg.Services.Models;

namespace WebReg.Services
{
    public interface IPersonService
    {
        Task<IReadOnlyList<Person>> ListAllAsync(CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Person>> GetPageAsync(PageModel page, CancellationToken cancellationToken = default);
        Task<Person> AddPersonAsync(Person person);
        Task<Person> GetPersonAsync(Guid id);
    }
}