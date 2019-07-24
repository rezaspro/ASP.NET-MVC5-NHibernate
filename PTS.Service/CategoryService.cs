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
    public interface ICategoryService : IBaseService
    {
        object Save(Category category);

        IList<Category> LoadCategory();
    }
    public class CategoryService : BaseService, ICategoryService
    {
        private ICategoryDao _categoryDao;
        public CategoryService(ISession session)
        {
            BaseServiceSession = session;
            _categoryDao = new CategoryDao() { BaseDaoSession = BaseServiceSession };
        }
        public object Save(Category category)
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


        public IList<Category> LoadCategory()
        {
            return _categoryDao.LoadActive();
        }
    }
}
