using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PTS.BusinessModel;
using PTS.BusinessModel.Base;

namespace PTS.Dao.Mapping
{
    public class BaseMap<TEntityT, TIdT> : ClassMap<TEntityT> where TEntityT : BaseModel<TIdT>
    {
        public BaseMap()
        {
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Version(x => x.VersionNumber);
            Map(x => x.CreationDate);
            Map(x => x.ModificationDate);
            Map(x => x.Status);
        }


        //public class BaseClassMap<TEntityT, TIdT> : ClassMap<TEntityT> where TEntityT : BaseEntity<TIdT>
    //{
    //    public BaseClassMap()
    //    {
    //        Id(x => x.Id).GeneratedBy.Identity().Column("Id");
    //        Map(x => x.BusinessId);
    //        Version(x => x.VersionNumber);
    //        Map(x => x.CreationDate);
    //        Map(x => x.ModificationDate);
    //        //Map(x => x.Name);
    //        Map(x => x.Status);
    //        Map(x => x.CreateBy);
    //        Map(x => x.ModifyBy);
    //    }
    }
}
