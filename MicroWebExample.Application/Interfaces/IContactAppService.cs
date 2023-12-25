using MicroWebExample.Application.Dto.ContactDto;
using MicroWebExample.Application.Dto.SliderDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MicroWebExample.Application.Interfaces
{
    public interface IContactAppService: IApplicationService
    {
        Task<List<GetContactOutPut>> ListAllAsync();
        Task Create(CreateContactInput input);
        void Update(UpdateContactInput input);
        Task Delete(DeleteContactInput input);
        Task<GetContactOutPut> GetContactById(int id);
    }
}
