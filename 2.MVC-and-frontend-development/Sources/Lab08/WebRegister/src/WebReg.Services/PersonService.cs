using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebReg.Data;
using WebReg.Data.Models;

namespace WebReg.Services
{
    public class PersonService : IPersonService
    {
        protected readonly WebRegContext dbContext;

        public PersonService(WebRegContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IReadOnlyList<Person>> ListAllAsync(CancellationToken cancellationToken = default)
        {
            return await dbContext.Set<Person>().ToListAsync(cancellationToken);
        }
    }
}
