using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonApp
{

    public abstract class Pokemon
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

        public virtual string ActionChoice(Pokemon pokemon)
        {

            Console.WriteLine("Choisissez une action à réaliser : Attaquer, healer, stats");
            var choixAction = Console.ReadLine();
            switch (choixAction)
            {
                case "Attaquer":
                    return "test";
                
                case "healer":
                    Console.WriteLine($"{pokemon.Name} à {pokemon.Pv} tu utilise soin !");
                    pokemon.Pv += 5;
                    return $"{pokemon.Name} à récupéré 5 PV, il a désormais {pokemon.Pv}";
                 
                case "stats":
                    return $"les stats de ton pokemon sont : pv : {pokemon.Pv}, ATK : {pokemon.Atk}, DEF : {pokemon.Def}, VIT : {pokemon.Vit} ";
             
            }
            return "aurevoir";
        }
    }
}
