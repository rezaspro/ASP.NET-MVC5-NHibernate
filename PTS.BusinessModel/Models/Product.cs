using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.BusinessModel.Models
{
   public class Product
    {
       public virtual long Id { get; set; }
        public virtual string Name { get; set; }

        public virtual Category Category { get; set; }
    }
}
