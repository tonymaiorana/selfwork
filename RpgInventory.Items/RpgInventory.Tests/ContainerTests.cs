using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RpgInventory.Items.Containers;
using RpgInventory.Items.Potions;
using RpgInventory.Items.Weapons;

namespace RpgInventory.Tests
{
    [TestFixture]
    public class ContainerTests
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            var backpack = new Backpack();
            var hp = new HealingPotion();

            bool actual = backpack.AddItem(hp);
            Assert.IsTrue(actual);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            var b = new Backpack();

            b.AddItem(new GreatAxe());
            b.AddItem(new GreatAxe());
            b.AddItem(new GreatAxe());
            b.AddItem(new GreatAxe());

            var actual = b.AddItem(new GreatAxe()); ;

            Assert.IsFalse(actual);
        }

        [Test]
        public void CannotAddDuplicateItemToBackpack()
        {
            var b = new Backpack();
            var a = new GreatAxe();

            b.AddItem(a);
            var actual = b.AddItem(a);

            Assert.IsFalse(actual);
        }

        [Test]
        public void CanRemoveItemFromBackpack()
        {
            var b = new Backpack();
            var a = new GreatAxe();

            // put the axe in the bag
            b.AddItem(a);

            // get the same axe out
            var item = b.RemoveItem();

            // are they the same object?
            Assert.AreEqual(a, item);

            // is the bag empty?
            Assert.IsNull(b.RemoveItem());
        }

        [Test]
        public void PotionBagOnlyAllowsPotions()
        {
            var b = new PotionSatchel();

            Assert.IsFalse(b.AddItem(new GreatAxe()));

            Assert.IsTrue(b.AddItem(new HealingPotion()));
        }

        [Test]
        public void MyDuffelBagHasWeightRestrictions()
        {
            var d = new DuffelBag();

            d.AddItem(new GreatAxe());
            d.AddItem(new GreatAxe());
            d.AddItem(new HealingPotion());

            Assert.IsFalse(d.AddItem(new GreatAxe()));
            Assert.IsTrue(d.AddItem(new HealingPotion()));

        }
    }
}
