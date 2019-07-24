using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PTS.BusinessModel;
using PTS.BusinessModel.Models;
using PTS.Dao;
using PTS.Service.Base;

namespace PTS.Service
{
    public interface IProductService : IBaseService
    {
        object Save(Product category);
    }
    public class ProductService : BaseService, IProductService
    {
        private IProductDao _categoryDao;
        public ProductService(ISession session)
        {
            BaseServiceSession = session;
            _categoryDao = new ProductDao() { BaseDaoSession = BaseServiceSession };
        }
        public object Save(Product category)
        {
            object returnAppUser = null;
            ITransaction trans;
            try
            {
                using (trans=BaseServiceSession.BeginTransaction())
                {
                    _categoryDao.Save(category);
                    trans.Commit();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return returnAppUser;
        }
    }
}
