using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession : BasePropertyChangedEventClass
    {
        //Vacuum variable to update UI for changes to CurrentLocation
        private Location _currentLocation;

        //We have to check if there are Locations in each direction to change the UI so the player can't move there if there isn't a Location. 
        public bool hasNorth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }

        public bool hasWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool hasEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool hasSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }

        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation 
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));

                //We have to update the boolean values for the UI visibility of the movement controls. They only need updating if the CurrentLocation changes.
                OnPropertyChanged(nameof(hasNorth));
                OnPropertyChanged(nameof(hasWest));
                OnPropertyChanged(nameof(hasEast));
                OnPropertyChanged(nameof(hasSouth));
            }
                
         }

        public World CurrentWorld { get; set; }

        //TODO: make it possible to store previous Characters
        public Player[] previousPlayers { get; set; }


        public GameSession()
        {
            CurrentPlayer = new Player 
                        { 
                            name = "Arun", 
                            CharacterClass = "Assassin", 
                            hp = 10, 
                            gold = 0, 
                            xp = 0, 
                            level = 1 
                        };
            
           
            CurrentWorld = WorldFactory.createWorld();
            CurrentLocation = CurrentWorld.LocationAt(0, -1);
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(1001));

        }

        public void MoveNorth()
        {
            if (hasNorth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
            
        }

        public void MoveWest()
        {
            if (hasWest)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }

        public void MoveEast()
        {
            if (hasEast)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }

        public void MoveSouth()
        {
            if (hasSouth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }

        
    }
}
