using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Domain.Common
{
    [Serializable]
    public class BaseEntity<T>
    {
        [Key]
        public virtual T Id { get; set; }
    }
}
