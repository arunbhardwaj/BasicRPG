using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    //Internal just means the scope is set to the Engine package only. It's good practice to explicitly state the scope. 
    internal static class WorldFactory
    {
        //Internal function that can only be used inside Engine Project
        internal static World createWorld()
        {
            World newWorld = new World();

            //Populate your world with locations.
            newWorld.AddLocation(0, -1, "Home", "This is your home!", "/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(0, 0, "Town Square", "The Town Square. This is where everyone gathers during festivals and holidays. You can find many merchants here spilling out from the Trader's Sphere. There's a beautiful fountain located in the front, whose waters are said to come straight from Osceia, but who knows?", "/Engine;component/Images/Locations/TownSquare.png");
            newWorld.AddLocation(0, 1, "Herbalist's Hut", "Legend has it that the Herbalist healed the legendary warrior Artorius after he was greatly wounded in the Oceanic War.", "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(1, 0, "Town Gate", "The colossal gate protects us from the forest to the east while also preventing criminals from leaving. Thousands of merchants frequently travel through these gates, often citing them as the most breathtaking thing upon first sight.", "/Engine;component/Images/Locations/TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest", "The forest is home to a diverse and eclectic group of species. In here, the apex predator is the Giant Spider Queen.", "/Engine;component/Images/Locations/SpiderForest.png");
            newWorld.AddLocation(-1, 0, "Trader's Sphere", "Once a year, trader's from across the world come and set up shop in the 100-concentric rings, the primordial shape of the market that the first king King Artorius set up. You can often see merchants fighting over who gets which spot in the rings, as the center rings are the most heavily trafficked and are known for their rare and highest-quality goods.", "/Engine;component/Images/Locations/Trader.png");
            newWorld.AddLocation(-1, -1, "Farmer's House", "The old farm you used to grow up on. It hasn't changed in ages.", "/Engine;component/Images/Locations/Farmhouse.png");
            newWorld.AddLocation(-2, -1, "Farmlands", "Home to the source of the capitol city's food supply, the farmlands have greatly prospered with the rich fertile lands that are downstream from the Osceia, the great glacial mountain to the far north.", "/Engine;component/Images/Locations/FarmFields.png");



            return newWorld;
        }
    }
}
