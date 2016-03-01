﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgInventory.Items.Containers
{
    public abstract class Container : Item
    {
        protected int Capacity;
        protected Item[] Items;
        protected int ItemIndex;

        public Container(int capacity)
        {
            Capacity = capacity;
            Items = new Item[capacity];
        }

        public virtual bool AddItem(Item itemToAdd)
        {
            if(ItemIndex == Capacity)
            {
                return false;
            }

            if(Items.Contains(itemToAdd))
            {
                return false;
            }

            Items[ItemIndex] = itemToAdd;
            ItemIndex++;
            return true;
        }

        public Item RemoveItem()
        {
            if (ItemIndex == 0)
                return null;

            ItemIndex--;
            Item i = Items[ItemIndex];
            Items[ItemIndex] = null;
            return i;
        }
    }
}
