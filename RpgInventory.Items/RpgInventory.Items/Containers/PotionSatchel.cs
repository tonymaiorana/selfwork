using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgInventory.Items.Containers
{
    public class PotionSatchel :SpecificContainer
    {
        public PotionSatchel() : base(3, ItemType.Potion)
        {
            Name = "A potion satchel";
            Description = "A satchel, that holds potions";
            Weight = 1;
            Type = ItemType.Container;
        }
    }
}
