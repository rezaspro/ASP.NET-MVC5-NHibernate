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
    public interface ITestService : IBaseService
    {
        object Save(AppUser appUser);
    }
    public class TestService : BaseService, ITestService
    {
        private ITestDao testDao;
        public TestService(ISession session)
        {
            BaseServiceSession = session;
            testDao = new TestDao() { BaseDaoSession = BaseServiceSession };
        }
        public object Save(AppUser appUser)
        {
            object returnAppUser = null;
            ITransaction trans;
            try
            {
                using (trans=BaseServiceSession.BeginTransaction())
                {
                    testDao.Save(appUser);
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
