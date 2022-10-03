using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Writer: BaseCommon, IEntity
    {
        [StringLength(50)]
        public String LastName { get; set; }
        [StringLength(100)]
        public String WritrImage { get; set; }
        [StringLength(50)]
        public String Email { get; set; }
        [StringLength(33)]

        public String Password { get; set; }


        public ICollection<Heading> Headings { get; set; }

    }
}
