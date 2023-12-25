using MicroWebExample.Application.Dto.SliderDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MicroWebExample.Application.Interfaces
{
    public interface ISliderAppService:IApplicationService
    {
        Task<IEnumerable<GetSliderOutPut>> ListAllAsync();
        Task Create(CreateSliderInput input);
        void Update(UpdateSliderInput input);
        Task Delete(DeleteSliderInput input);
        Task<GetSliderOutPut> GetSliderById(int id);
    }
}
