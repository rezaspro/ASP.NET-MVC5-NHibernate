using System;

namespace PTS.BusinessModel.Base
{
    public interface IBaseModel<TTdT>
    {
        TTdT Id { get; set; }
        int VersionNumber { get; set; }
        DateTime CreationDate { get; set; }
        DateTime ModificationDate { get; set; }
        int Status { get; set; }
    }

    public class BaseModel<TTdT> : IBaseModel<TTdT>,ICloneable
    {
        public virtual TTdT Id { get; set; }
        public virtual int VersionNumber { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime ModificationDate { get; set; }
        public virtual int Status { get; set; }

        public static class ModelStatus
        {
            public static int Active { get { return 1; } }
            public static int Inactive { get { return -1; } }
            public static int Delete { get { return -404; } }
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
