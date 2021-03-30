using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using WebReg.Data;
using WebReg.Data.Models;
using WebReg.Services.Models;

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

        public async Task<IReadOnlyList<Person>> GetPageAsync(PageModel page, CancellationToken cancellationToken = default)
        {
            int rowCount = await dbContext.Set<Person>().CountAsync();
            page.TotalPages = (int)Math.Ceiling(rowCount / (double)page.PageSize);

            var query = BuildQuery(page);
            var persons = await query.Skip((page.PageNumber - 1) * page.PageSize).Take(page.PageSize).AsNoTracking().ToListAsync();

            return persons;
        }

        private IQueryable<Person> BuildQuery(PageModel page)
        {
            IQueryable<Person> query = null;
            Expression<Func<Person, object>> expression = page.SortColumn switch
            {
                "1" => x => x.FirstName,
                "2" => x => x.LastName,
                "3" => x => x.BirthDate,
                "4" => x => x.Email,
                _ => x => x.FirstName,
            };

            page.SortOrder ??= "asc";
            query = page.SortOrder switch
            {
                "asc" => dbContext.Set<Person>().OrderBy(expression),
                "desc" => dbContext.Set<Person>().OrderByDescending(expression),
                _ => dbContext.Set<Person>(),
            };

            return query;
        }
    }
}
