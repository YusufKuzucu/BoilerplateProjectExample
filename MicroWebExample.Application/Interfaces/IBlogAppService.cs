using MicroWebExample.Application.Dto.BlogDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MicroWebExample.Application.Interfaces
{
    public interface IBlogAppService:IApplicationService
    {
        Task<List<GetBlogOutPut>> ListAllAsync();
        Task Create(CreateBlogInput input);
        void Update(UpdateBlogInput input);
        Task Delete(DeleteBlogInput input);
       Task<GetBlogOutPut> GetBlogById(int id);
    }
}
