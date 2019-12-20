using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        //This is a placeholder (a backing variable) for the xp so the real xp value can be updated in the UI.
        private string _name;
        private string _characterClass;
        private int _hp;
        private int _experiencePoints;
        private int _level;
        private int _gold;
        
        public string name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }
        public string CharacterClass 
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                OnPropertyChanged(CharacterClass);
            }
        
        }
        public int hp 
        { 
            get { return _hp;  } 
            set
            {
                _hp = value;
                OnPropertyChanged("hp");
            }
        }
        public int xp 
         {
            get { return _experiencePoints; }
            set {
                _experiencePoints = value;
                OnPropertyChanged("xp");
            }
        }
        public int level 
        { 
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("level");
            }
        }
        public int gold 
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("gold");
            }
        }

        public Player()
        {
            this.hp = 10;
            this.xp = 0;
            this.level = 1;
            this.gold = 25;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
