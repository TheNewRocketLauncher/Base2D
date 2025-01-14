﻿using Crom.System.DamageSystem.Critical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crom.Init.DamageModification
{
    public static partial class Critical
    {
        public static CriticalInfo CriticalStrike()
        {
            CriticalInfo critical = new CriticalInfo();

            critical.Id = "c01";
            critical.Name = "Critical Strike";
            critical.Chance = 80.0f;
            critical.Multiple = 2.0f;
            critical.Bonus = 0.0f;
            critical.StackType = System.DamageSystem.StackType.Diminishing;
            critical.Stacks = new List<System.DamageSystem.IDamageModification>();
            critical.CanEvade = true;
            critical.CanIgnoreArmor = false;
            critical.CanIgnoreBlock = false;
            
            return critical;
        }
    }
}
