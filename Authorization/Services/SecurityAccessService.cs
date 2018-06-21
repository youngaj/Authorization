using System;
using System.Collections.Generic;
using URF.Core.Abstractions.Trackable;
using URF.Core.Services;

namespace Authorization.Services
{
    public interface ISecurityAccessService
    {
        IResult CanAccess(ISecuredEntity actorCompositeKey, string entityKey);

        List<ISecurityResult> CanAccessMultiple(string actorCompositeKey, List<string> entityKeys);

        void AddAccessRule(ISecuredEntity entityKey, AccessRule accessRule);
    }

    public class SecurityAccessService : Service<AccessRule>, ISecurityAccessService
    {
        private ITrackableRepository<AccessRule> _repo;

        public SecurityAccessService(ITrackableRepository<AccessRule> repository) : base(repository)
        {
            _repo = repository;
        }

        public void AddAccessRule(ISecuredEntity entityKey, AccessRule accessRule)
        {
            throw new NotImplementedException();
        }

        public IResult CanAccess(ISecuredEntity actorCompositeKey, string entityKey)
        {
            throw new NotImplementedException();
        }

        public List<ISecurityResult> CanAccessMultiple(string actorCompositeKey, List<string> entityKeys)
        {
            throw new NotImplementedException();
        }
    }
}