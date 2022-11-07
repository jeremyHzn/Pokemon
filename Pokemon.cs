using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        /*
         * Methode pour attaquer le pokemon et qu'il nous attaque
         */
        public virtual void Attack(Pokemon pokemon, Pokemon sauvage)
        {

            Console.WriteLine($"vous attaquez {sauvage.Name} !");
            Console.WriteLine($"vous infligez {pokemon.Atk /8} PV à {sauvage.Name}!");
            sauvage.Pv -= pokemon.Atk /8;
            if (sauvage.Pv < 0)
            {
                sauvage.Pv = 0;
                Console.WriteLine($"Il reste {sauvage.Pv} à {sauvage.Name}");
                Console.WriteLine($"le pokemon {sauvage.Name} est mort");
            }
            
        }

        /*
         * Methode pour healer le pokemon
         */
        public virtual void Healer(Pokemon pokemon)
        {
            Console.WriteLine($"{pokemon.Name} à {pokemon.Pv} tu utilises une potion !");
            pokemon.Pv += 5;
            Console.WriteLine($"{pokemon.Name} à récupéré 5 PV, il a désormais {pokemon.Pv}");
        }

        /*
         * Methode pour voir les stats du pokemon
         */
        public virtual void Stats(Pokemon pokemon)
        {
            Console.WriteLine($"les stats de ton pokemon sont : pv : {pokemon.Pv}, ATK : {pokemon.Atk}, DEF : {pokemon.Def}, VIT : {pokemon.Vit} ");
        }
        public static void Quitter()
        {
            
            Console.WriteLine("souhaitez-vous quitter ? (Y/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    Console.Clear();
                    break;
                default:
                    
                    break;
            }
        }

        /*
         * Methode du choix de l'action du joueur
         */
        public string ActionChoice(Pokemon pokemon, Pokemon sauvage)
        {
            Console.WriteLine("Choisissez une action à réaliser : 1 - Attaquer, 2 - healer, 3 - stats 4- quitter, 5 - capturer");
            var choixAction = Console.ReadLine();
            switch (choixAction)
            {
                case "1":
                    Attack(pokemon, sauvage);
                    break;
                case "2":
                    Healer(pokemon);
                    break;
                case "3":
                    Stats(pokemon);
                    break;
                case "4":
                    Quitter();
                    break;
                case "5":
                    CapturePokemon();
                    break;
            }
            return "";
        }

        /*
         * Methode du choix de l'adversaire
         */
        public string ActionChoiceSauvage(Pokemon sauvage, Pokemon pokemon)
        {
            if(pokemon.Pv > 0)
            {
                Random random = new Random();
                // choix aléatoire de l'action du pokemon adverse (attaque, utiliser une potion)
                int resultatChoix = random.Next(1);
                switch (resultatChoix)
                {
                    case 0:
                        Console.WriteLine($"{sauvage.Name} vous attaque !");
                        Console.WriteLine($"il vous inflige {sauvage.Atk / 8} PV à {pokemon.Name}!");
                        pokemon.Pv -= sauvage.Atk / 8;
                        Console.WriteLine($"il reste {pokemon.Pv} à {pokemon.Name}");
                        if (pokemon.Pv <= 0)
                        {
                            pokemon.Pv = 0;
                            Console.WriteLine($"votre pokemon {pokemon.Name} est mort");
                        }
                        break;
                    case 1:
                        Console.WriteLine($"{sauvage.Name} observe !");
                        break;
                }
                
            }
            
            return "";
        }

        public void CapturePokemon()
        {
            Console.WriteLine("Vous capturez le pokémon sauvage");

            List<string> pokemon = new List<string>();
      
            pokemon.Add("bulbizzare");

            Console.WriteLine("Vous avez capturé bulbizzare");
            foreach (var item in pokemon)
            {
                Console.WriteLine($"t'es pokemon : {item}");
            }
        }
    }

}
