using MicroWebExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Domain.Entities
{
    public class Contact:BaseEntity<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; } 
    }
}
