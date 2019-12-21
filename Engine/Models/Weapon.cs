using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int Attack { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        //Sends the designated parameters to the base class and sets the properties so we don't have to do it here.
        public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamage) : base(itemTypeID, name, price)
        {
            /* Not necessary because of the ": base(itemTypeID, name, price)"
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            */

            MinDamage = minDamage;
            MaxDamage = maxDamage;

        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinDamage, MaxDamage);
        }
    }
}
