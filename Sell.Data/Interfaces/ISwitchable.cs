﻿using Sell.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sell.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
