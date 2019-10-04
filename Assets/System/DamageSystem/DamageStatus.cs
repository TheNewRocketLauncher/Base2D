﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crom.System.DamageSystem
{
    [Flags()]
    public enum DamageStatus
    {
        Common = 0,
        Critical = 1,
        Evade = 2,
        Blocked = 4,
        Reduced = 8,

    }
}