using System;
using System.Collections.Generic;
using System.Text;

namespace Sell.Data.Interfaces
{
    public interface ISortable
    {
        int SortOrder { set; get; }
    }
}
