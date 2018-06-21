using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization.Interfaces
{
    public interface IGraphService
    {
        IEnumerable<ISecuredEntity> GetPath(ISecuredEntity entity);
    }
}
