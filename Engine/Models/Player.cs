﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Player : BasePropertyChangedEventClass
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
                OnPropertyChanged(nameof(name));
            }
        }
        public string CharacterClass 
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            }
        
        }
        public int hp 
        { 
            get { return _hp;  } 
            set
            {
                _hp = value;
                OnPropertyChanged(nameof(hp));
            }
        }
        public int xp 
         {
            get { return _experiencePoints; }
            set {
                _experiencePoints = value;
                OnPropertyChanged(nameof(xp));
            }
        }
        public int level 
        { 
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged(nameof(level));
            }
        }
        public int gold 
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged(nameof(gold));
            }
        }

        //ObservableCollections automatically handles notifications when something gets changed.
        public ObservableCollection<GameItem> Inventory { get; set; }
        public ObservableCollection<QuestStatus> Quests { get; set; }


        public Player()
        {
            /*
            this.hp = 10;
            this.xp = 0;
            this.level = 1;
            this.gold = 25;
            */

            //Instantiate a new inventory to the player.
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }

        
    }
}
