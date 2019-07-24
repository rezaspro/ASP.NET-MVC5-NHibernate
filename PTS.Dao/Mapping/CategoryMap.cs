using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PTS.BusinessModel;
using PTS.BusinessModel.Models;

namespace PTS.Dao.Mapping
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Category");
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Products).KeyColumn("CategoryId").Cascade.AllDeleteOrphan().Inverse();
        }
    }
}
