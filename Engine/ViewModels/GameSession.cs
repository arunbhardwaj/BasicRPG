using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }


        //TODO: make it possible to store previous Characters
        public Player[] previousPlayers { get; set; }


        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.name = "Arun";
            CurrentPlayer.CharacterClass = "Assassin";
            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your home!";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.png";

            
        }

        public void MoveNorth()
        {
            CurrentLocation.YCoordinate += 1;
        }

        public void MoveWest()
        {
            CurrentLocation.XCoordinate -= 1;
        }

        public void MoveEast()
        {
            CurrentLocation.XCoordinate += 1;
        }

        public void MoveSorth()
        {
            CurrentLocation.YCoordinate -= 1;
        }
    }
}
