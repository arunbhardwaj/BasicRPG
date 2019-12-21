using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    //Internal just means the scope is set to the Engine package only. It's good practice to explicitly state the scope. 
    internal class WorldFactory
    {
        //Internal function that can only be used inside Engine Project
        internal World createWorld()
        {
            World newWorld = new World();

            //Populate your world with locations.
            newWorld.AddLocation(0, -1, "Home", "This is your home!", "/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(0, 0, "Town Square", "The Town Square. This is where everyone gathers during festivals and holidays. You can find many merchants here during such times.", "/Engine;component/Images/Locations/TownSquare.png");


            return newWorld;
        }
    }
}
