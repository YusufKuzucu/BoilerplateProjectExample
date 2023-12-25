using MicroWebExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace MicroWebExample.Application.Interfaces.Repositories
{
    public interface IContactService : IBaseRepository<Contact, int>, IDomainService
    {
    }
}
