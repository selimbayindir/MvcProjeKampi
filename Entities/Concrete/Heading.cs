using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Heading: BaseCommon, IEntity
    {
        public DateTime CreatingDate { get; set; }
        // public String Writer { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Content> Contents { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
