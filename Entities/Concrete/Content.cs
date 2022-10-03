using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content: BaseCommon, IEntity
    {
        [StringLength(1000)]

        public String ContentValue { get; set; }
        public DateTime CreatedDate { get; set; }


        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        public int WriteId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
