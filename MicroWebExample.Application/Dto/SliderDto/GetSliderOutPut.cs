using MicroWebExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Application.Dto.SliderDto
{
    public class GetSliderOutPut
    {
        public  int Id { get; set; }
        public string SortDescription { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
    }
}
