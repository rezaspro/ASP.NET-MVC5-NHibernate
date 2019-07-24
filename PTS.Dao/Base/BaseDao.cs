using System;
using System.Collections.Generic;
using NHibernate;
using PTS.BusinessModel;
using PTS.BusinessModel.Base;
using PTS.BusinessRule;

namespace PTS.Dao.Base
{
    public interface IBaseDao<TEntityT, TIdT>
    {
        ISession BaseDaoSession { get; set; }
        void Save(TEntityT data);
        //void Delete(TEntityT data);
        //void DeleteEntity(TIdT id);
        //void Update(TEntityT data);
        //void SaveOrUpdate(TEntityT data); 
        IList<TEntityT> LoadActive();
    }
    public class BaseDao<TEntityT, TIdT> : IBaseDao<TEntityT, TIdT> where TEntityT : class
    {
        public ISession BaseDaoSession { get; set; }
        public virtual void Save(TEntityT data)
        {
            //IBaseModel<long> entity = (IBaseModel<long>)data;
            //if (entity.CreationDate.Year < SoftwareConstant.FirstYear)
            //    entity.CreationDate = DateTime.Now;
            //entity.ModificationDate = DateTime.Now;
            //entity.Status = BaseModel<TEntityT>.ModelStatus.Active;

            //entity.CreateBy = GetCurrentUserId();
            //entity.ModifyBy = entity.CreateBy;
            BaseDaoSession.SaveOrUpdate(data);

        }


        public virtual IList<TEntityT> LoadActive()
        {
            Type type = typeof(TEntityT);
            string queryTxt = string.Format(@"From {0} as entity'", type);
            IQuery query = BaseDaoSession.CreateQuery(queryTxt);
            return query.List<TEntityT>();
        }
    }
}
