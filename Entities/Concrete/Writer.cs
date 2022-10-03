using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Writer: BaseCommon, IEntity
    {
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }


        public ICollection<Heading> Headings { get; set; }

    }
}
