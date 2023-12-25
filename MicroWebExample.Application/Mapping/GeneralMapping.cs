using AutoMapper;
using MicroWebExample.Application.Dto.BlogDto;
using MicroWebExample.Application.Dto.ContactDto;
using MicroWebExample.Application.Dto.SliderDto;
using MicroWebExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Blog, CreateBlogInput>().ReverseMap();
            CreateMap<Blog, DeleteBlogInput>().ReverseMap();
            CreateMap<Blog, UpdateBlogInput>().ReverseMap();
            CreateMap<Blog, GetBlogOutPut>().ReverseMap();



            CreateMap<Slider, CreateSliderInput>().ReverseMap();
            CreateMap<Slider, DeleteSliderInput>().ReverseMap();
            CreateMap<Slider, UpdateSliderInput>().ReverseMap();
            CreateMap<Slider, GetSliderOutPut>().ReverseMap();


            CreateMap<Contact, CreateContactInput>().ReverseMap();
            CreateMap<Contact, DeleteContactInput>().ReverseMap();
            CreateMap<Contact, UpdateContactInput>().ReverseMap();
            CreateMap<Contact, GetContactOutPut>().ReverseMap();
        }
    }
}
