using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests;
        
        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(2001, 2));
            rewardItems.Add(new ItemQuantity(1002, 1));

            _quests = new List<Quest>();
            //_quests.add(new quest(101, "test", "this is a test.", new list<itemquantity>(new itemquantity(1001, 1)), );

            _quests.Add(new Quest(101, "test", "this is a test", itemsToComplete, 10, 100, rewardItems));
        }

        public static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
