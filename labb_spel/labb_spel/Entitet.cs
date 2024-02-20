using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_spel
{
    public abstract class Entitet
    {

       public string name;
       public int strenght;
       public int stamina;
       public int vitality;
       public int agility;
        public Entitet (string name, int strenght, int stamina, int vitality, int agility) //Arv som de olika monster, djur och spelare kommar ett ärva ifrån
        {
            this.name = name;
            this.strenght = strenght;
            this.stamina = stamina;
            this.vitality = vitality;
            this.agility = agility;

        }

        public abstract string EntitetHp();
        public abstract string EntitetMp();

        public abstract string EntitetStr();
        public abstract string EntitetStam();

        public abstract string EntitetVit();
        public abstract string EntitetAgi();
    }
}
