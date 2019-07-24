using PTS.BusinessModel.Base;

namespace PTS.BusinessModel.Models
{
    public class AppUser : BaseModel<long>
    {
        public virtual string Name { get; set; }
    }
}
