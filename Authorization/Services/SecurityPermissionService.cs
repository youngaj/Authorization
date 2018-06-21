using Authorization.Entities;
using System;
using System.Collections.Generic;
using URF.Core.Abstractions.Trackable;
using URF.Core.Services;

namespace Authorization.Services
{
    public interface ISecurityPermissionService
    {
        IResult CanAccess(string actorCompositeKey, ISecuredEntity entity, string action);

        void AddPermission(Permission permission);

        List<Permission> GetPermissions(string actorCompositeKey, ISecuredEntity entity);
    }

    public class SecurityPermissionService : Service<Permission>, ISecurityPermissionService
    {
        private readonly ITrackableRepository<Permission> _repo;

        protected SecurityPermissionService(ITrackableRepository<Permission> repository) : base(repository)
        {
            _repo = repository;
        }

        public void AddPermission(Permission permission)
        {
            throw new NotImplementedException();
        }

        public IResult CanAccess(string actorCompositeKey, ISecuredEntity entity, string action)
        {
            throw new NotImplementedException();
        }

        public List<Permission> GetPermissions(string actorCompositeKey, ISecuredEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}