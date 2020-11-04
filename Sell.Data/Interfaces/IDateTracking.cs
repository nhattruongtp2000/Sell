using System;
using System.Collections.Generic;
using System.Text;

namespace Sell.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}
