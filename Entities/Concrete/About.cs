using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class About : BaseCommon, IEntity
    {
        public String AboutDetails1 { get; set; }
        public String AboutDetails2 { get; set; }
        public String AboutImage { get; set; }
        public String AboutImage2 { get; set; }
    }
}
