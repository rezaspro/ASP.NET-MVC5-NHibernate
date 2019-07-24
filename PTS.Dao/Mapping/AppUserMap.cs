using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTS.BusinessModel;
using PTS.BusinessModel.Models;

namespace PTS.Dao.Mapping
{
    public class AppUserMap : BaseMap<AppUser, long>
    {
        public AppUserMap()
        {
            Table("AppUser");
            Map(x => x.Name);
        }
    }
}
