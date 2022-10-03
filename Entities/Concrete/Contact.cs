using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact:BaseCommon,IEntity
    {
        [StringLength(50)]

        public String UserMail { get; set; }
        [StringLength(50)]
        public String Subject { get; set; }
        [StringLength(1000)]
        public String Message { get; set; }
    }
}
