using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PTS.BusinessModel;
using PTS.BusinessModel.Models;
using PTS.Dao.Base;

namespace PTS.Dao
{
    public interface ICategoryDao : IBaseDao<Category, long>
    {

      
    }
    public class CategoryDao : BaseDao<Category, long>, ICategoryDao
    {
      
    }
}
