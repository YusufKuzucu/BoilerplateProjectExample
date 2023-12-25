using AutoMapper;
using MicroWebExample.Application.Dto.BlogDto;
using MicroWebExample.Application.Dto.SliderDto;
using MicroWebExample.Application.Interfaces;
using MicroWebExample.Application.Interfaces.Repositories;
using MicroWebExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MicroWebExample.Persistence.Repositories.AppServices
{
    public class SliderAppService : ApplicationService,ISliderAppService
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SliderAppService(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public async Task Create(CreateSliderInput input)
        {
            Slider slider = _mapper.Map<CreateSliderInput,Slider> (input);
           await _sliderService.AddAsync(slider);
        }

        public async Task Delete(DeleteSliderInput input)
        {
            Slider removeSlider = await _sliderService.GetByIdAsync(input.Id);
            if (removeSlider != null)
            {
                await _sliderService.RemoveAsync(removeSlider);
            }
        }

        public async Task<GetSliderOutPut> GetSliderById(int id)
        {
            var getSlider=await _sliderService.GetByIdAsync(id);    
            GetSliderOutPut output=_mapper.Map<Slider,GetSliderOutPut>(getSlider);
            return output;
        }

        public async Task<IEnumerable<GetSliderOutPut>> ListAllAsync()
        {
            var getAllSlider = await _sliderService.GetAllAsync();
            IEnumerable<GetSliderOutPut> output = _mapper.Map<IEnumerable<Slider>,IEnumerable<GetSliderOutPut>>(getAllSlider);
            return output;
        }

        public void Update(UpdateSliderInput input)
        {
            Slider updateSlider = _mapper.Map<UpdateSliderInput, Slider>(input);
            _sliderService.UpdateAsync(updateSlider);
        }
    }
}
