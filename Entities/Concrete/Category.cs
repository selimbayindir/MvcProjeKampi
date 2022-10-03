using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category: BaseCommon,IEntity
    {
        public int Description { get; set; }
        public bool Status { get; set; }

        public ICollection<Heading> Headings{ get; set; }



    }
}
