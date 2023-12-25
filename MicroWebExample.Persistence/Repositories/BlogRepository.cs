using Abp.Domain.Services;
using MicroWebExample.Application.Interfaces.Repositories;
using MicroWebExample.Domain.Entities;
using MicroWebExample.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Persistence.Repositories
{
    public class BlogRepository : BaseRepository<Blog, int>, IBlogService
    {
        public BlogRepository(ApplicationDbContext dataContext) : base(dataContext)
        {
        }
    }
}
