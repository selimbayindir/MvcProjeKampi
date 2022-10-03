using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class BaseCommon
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public String Name { get; set; }
    }
}
