using System;
using URF.Core.EF.Trackable;

namespace Authorization
{
    public interface IAccessRule
    {
        int Id { get; set; }
        string EntityCoompositekey { get; set; }
        string ActorCompositeKey { get; set; }
        AccessType Type { get; set; }
    }

    public class AccessRule : Entity, IAccessRule
    {
        public int Id { get; set; }
        public string EntityCoompositekey { get; set; }
        public string ActorCompositeKey { get; set; }
        public AccessType Type { get; set; }
        public DateTime? Expiration { get; set; }
    }

    public enum AccessType
    {
        Denied = 0,
        Granted = 1
    }
}