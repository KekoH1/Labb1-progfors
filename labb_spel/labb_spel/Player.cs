﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_spel
{
    public class Player : Entitet
    {
        public string Name {  get; set; }
        public int Strength { get; set; }

        public int Endurance { get; set; }
        public int Agility { get; set; }

        public Player(int x, int y, char symbol, string name, int strenght, int endurance, int agility) : base(x, y, symbol)
        {
            Name = name;
            Strength = strenght;
            Endurance = endurance;
            Agility = agility;
        }

    }
}
