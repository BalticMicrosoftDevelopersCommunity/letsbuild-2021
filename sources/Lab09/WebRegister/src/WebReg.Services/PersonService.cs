using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<IReadOnlyList<Person>> GetPageAsync(string sortColumn, string sortOrder, CancellationToken cancellationToken = default)
        {
            Expression<Func<Person, object>> expression = sortColumn switch
            {
                "1" => x => x.FirstName,
                "2" => x => x.LastName,
                "3" => x => x.BirthDate,
                "4" => x => x.Email,
                _ => x => x.FirstName,
            };

            sortOrder ??= "asc";

            var persons = sortOrder switch
            {
                "asc" => await dbContext.Set<Person>().OrderBy(expression).AsNoTracking().ToListAsync(cancellationToken),
                "desc" => await dbContext.Set<Person>().OrderByDescending(expression).AsNoTracking().ToListAsync(cancellationToken),
                _ => await dbContext.Set<Person>().AsNoTracking().ToListAsync(cancellationToken),
            };

            return persons;
        }
    }
}
