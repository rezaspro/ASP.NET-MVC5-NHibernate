using NHibernate;

namespace PTS.Service.Base
{
    public interface IBaseService
    {
        ISession BaseServiceSession { get; set; }
    }
    public class BaseService : IBaseService
    {
        public ISession BaseServiceSession { get; set; }
    }
}
