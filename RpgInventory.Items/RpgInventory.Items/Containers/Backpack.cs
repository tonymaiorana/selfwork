using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgInventory.Items.Containers
{
    public class Backpack : Container
    {
        public Backpack() : base(4)
        {
            Name = "A leather backpack";
            Description = "Not quite big enough to fit a body, sigh";
            Weight = 2;
            Type = ItemType.Container;
        }
    }
}
