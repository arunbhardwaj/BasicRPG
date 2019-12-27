using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    /* Still need to figure out when to assign quests. First, tie them to locations upon being visited, and then 
     * we can assign them to NPC's and create a quest system?
     */
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ItemQuantity> ItemsToComplete { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }
        public Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete, int rewardXP, int rewardGold, List<ItemQuantity> rewardItems)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardExperiencePoints = rewardXP;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }
    }
}
