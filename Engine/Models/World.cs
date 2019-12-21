using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName) 
        {
            Location temp = new Location();
            temp.XCoordinate = xCoordinate;
            temp.YCoordinate = yCoordinate;
            temp.Name = name;
            temp.Description = description;
            temp.ImageName = imageName;
            _locations.Add(temp);

        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location current in _locations)
            {
                if (current.XCoordinate == xCoordinate && current.YCoordinate == yCoordinate)
                {
                    return current;
                }
            }
            return null;
        }
    }
}
