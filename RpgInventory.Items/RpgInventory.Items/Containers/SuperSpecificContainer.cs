using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgInventory.Items.Containers
{
    public abstract class SuperSpecificContainer : Container
    {
        protected int CurrentWeight;
        protected int AmountBeforeBagBusts;

        public SuperSpecificContainer(int capacity, int amountBeforeBagBusts) : base(capacity)
        {
            AmountBeforeBagBusts = amountBeforeBagBusts;
        }

        public override bool AddItem(Item itemtoAdd)
        {
            if (CurrentWeight + itemtoAdd.Weight > AmountBeforeBagBusts)
            {
                return false;
            }

            CurrentWeight = itemtoAdd.Weight + CurrentWeight;
            return base.AddItem(itemtoAdd);
        }
    }
}
