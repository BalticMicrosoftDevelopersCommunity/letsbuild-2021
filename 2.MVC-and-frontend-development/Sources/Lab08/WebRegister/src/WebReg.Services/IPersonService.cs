using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebReg.Data.Models;

namespace WebReg.Services
{
    public interface IPersonService
    {
        Task<IReadOnlyList<Person>> ListAllAsync(CancellationToken cancellationToken = default);
    }
}