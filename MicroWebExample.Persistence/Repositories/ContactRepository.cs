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
    public class ContactRepository : BaseRepository<Contact, int>, IContactService
    {
        public ContactRepository(ApplicationDbContext dataContext) : base(dataContext)
        {
        }
    }
}
