using System;
using System.Collections.Generic;
using System.Text;

namespace HN.Data.Interfaces
{
    public class IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
