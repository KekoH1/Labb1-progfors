using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_spel
{
    public abstract class Player : Entitet
    {
        
       public Player (string name, int strenght, int stamina, int vitality, int agility) : base(name, strenght, stamina, vitality, agility)
        {
            name = "";
            this.name = name;

        }
    }
}
