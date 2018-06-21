using System;
using URF.Core.EF.Trackable;

namespace Authorization.Entities
{
    public class Permission: Entity
    {
        public int Id { get; set; }
        public string EntityCompositeKey { get; set; }
        public string ActorCompositeKey { get; set; }
        public string Feature { get; set; }
        public PermissionType Type { get; set; }
        public DateTime? Expiration { get; set; }
    }

    public enum PermissionType
    {
        Denied = 0,
        Granted = 1
    }
}