using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.BusinessModel.Models
{
    public class Category
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual long CategoryId { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
