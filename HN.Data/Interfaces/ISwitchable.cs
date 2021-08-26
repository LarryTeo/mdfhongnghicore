using HN.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HN.Data.Interfaces
{
   public interface ISwitchable
    {
       Status Status { set; get; } 
    }
}
