using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PTS.BusinessModel.Models;

namespace PTS.Dao.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Product");
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Category).Column("CategoryId");
        }
    }
}
