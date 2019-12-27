using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    //This will be a collection of all items in the game, so that when we need to make a weapon or item, we can just create an instance of that object. 
    public static class ItemFactory
    {
        private static List<GameItem> _gameItems;

        // We need a way to populate all the items in the game into this list. But, you never instantiate a static class and doesn't have a constructor. But it does have a funciton that we can say that the first time anyone ever uses anything in this item class, use this function. 
        static ItemFactory()
        {
            //TODO: Instead of hardcoding the variables, load the items from a database or XML file or some other file. 

            _gameItems = new List<GameItem>();
            _gameItems.Add(new Weapon(1001, "Sharp Stick", 1, 1, 2));
            _gameItems.Add(new Weapon(1002, "Rusty Broken Sword", 5, 1, 3));
            _gameItems.Add(new GameItem(2001, "Snake Fang", 5));
            _gameItems.Add(new GameItem(2002, "Snakeskin", 2)); 
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            //LINQ to find the first item that matches the one we passed through using predicates/lambdas.
            GameItem gameItem = _gameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
           
            //In order to allow for modified unique items, we need to create a copy of the standard item.
            if (gameItem != null)
            {
                return gameItem.Clone();
            }
            return null;
        }
    }
}
