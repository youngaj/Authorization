using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization
{
    public interface ISecuredEntity
    {
        string CompositeKey { get; set; }
    }
}
