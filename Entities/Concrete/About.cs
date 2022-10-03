using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class About : BaseCommon, IEntity
    {
        [StringLength(1000)]
        public String AboutDetails1 { get; set; }
        [StringLength(1000)]

        public String AboutDetails2 { get; set; }
        [StringLength(100)]

        public String AboutImage { get; set; }
        [StringLength(100)]

        public String AboutImage2 { get; set; }
    }
}
