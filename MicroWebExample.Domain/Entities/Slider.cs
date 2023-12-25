using MicroWebExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Domain.Entities
{
    public class Slider:BaseEntity<int>
    {
        public string SortDescription { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }

    }
}
