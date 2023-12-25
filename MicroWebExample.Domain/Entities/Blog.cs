using MicroWebExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Domain.Entities
{
    public class Blog:BaseEntity<int>
    {
        public string Title { get; set; }
        public string SortDescription { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
