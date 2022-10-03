using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content: BaseCommon, IEntity
    {
        public String ContentValue { get; set; }
        public DateTime CreatedDate { get; set; }

        //ContentYazar
        //ContentHeading
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }
    }
}
