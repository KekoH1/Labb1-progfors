using labb_spel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Item : Entitet
    {

        public string Name { get; set; }

        public Item(int x, int y, char symbol, string name) : base(x, y, symbol)
        {
            Name = name;
        }
    }
}
