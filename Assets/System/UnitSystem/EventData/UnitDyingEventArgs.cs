﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crom.System.UnitSystem.EventData
{
    public class UnitDyingEventArgs
    {
        public bool Cancel { get; set; }

        public UnitDyingEventArgs()
        {
            Cancel = false;
        }
    }
}
