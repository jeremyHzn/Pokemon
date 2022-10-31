using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonApp.@class
{

    public class Pokemon
    {
        public string? Name { get; set; }
        public int Pv { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Vit { get; set; }


        public Pokemon() { }

        public Pokemon(string? name, int pv, int atk, int def, int vit)
        {
            Name = name;
            Pv = pv;
            Atk = atk;
            Def = def;
            Vit = vit;
        }
    }
}
