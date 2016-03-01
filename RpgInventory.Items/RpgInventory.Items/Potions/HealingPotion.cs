﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgInventory.Items.Potions
{
    public class HealingPotion : Item
    {
        public HealingPotion()
        {
            Name = "Healing Potion";
            Description = "Red fizzy liquid smelling of ben-gay";
            Weight = 1;
            Type = ItemType.Potion;
        }
    }
}
