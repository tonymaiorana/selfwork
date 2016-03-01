using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RpgInventory.Items.Containers
{
    public class DuffelBag : SuperSpecificContainer
    {
        public DuffelBag() : base(4, 15)
        {
            Name = "A bag full of duffel";
            Description = "Duffelbag with more duffel than bag";
            Weight = 1;
            Type = ItemType.Container;
        }

    }
}
