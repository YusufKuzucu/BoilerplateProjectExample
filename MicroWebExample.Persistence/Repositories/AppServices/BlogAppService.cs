using AutoMapper;
using MicroWebExample.Application.Dto.BlogDto;
using MicroWebExample.Application.Interfaces;
using MicroWebExample.Application.Interfaces.Repositories;
using MicroWebExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MicroWebExample.Persistence.Repositories.AppServices
{
    public class BlogAppService : ApplicationService,IBlogAppService
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public BlogAppService(IBlogService blogService,IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public async Task Create(CreateBlogInput input)
        {
            Blog blog = _mapper.Map<CreateBlogInput, Blog>(input);
            await _blogService.AddAsync(blog);
        }

        public async Task Delete(DeleteBlogInput input)
        {
            Blog removeBlog = await _blogService.GetByIdAsync(input.Id);
            if (removeBlog != null)
            {
                await _blogService.RemoveAsync(removeBlog);
            }
        }

        public async Task<GetBlogOutPut> GetBlogById(int id)
        {
            var getBlog =  await _blogService.GetByIdAsync(id);
            GetBlogOutPut output = _mapper.Map<Blog,GetBlogOutPut>(getBlog);
            return output;
        }

        public async Task<List<GetBlogOutPut>> ListAllAsync()
        {
            var getAllBlog = await _blogService.GetAllAsync();
            List<GetBlogOutPut> output = _mapper.Map<List<Blog>,List<GetBlogOutPut>>(getAllBlog);
            return output;
        }

        public void Update(UpdateBlogInput input)
        {
            Blog updateBlog = _mapper.Map<UpdateBlogInput, Blog>(input);
            _blogService.UpdateAsync(updateBlog);
        }
    }
}
