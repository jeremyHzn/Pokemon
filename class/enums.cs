using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonApp {
    public enum Posibililty
    {
        fight,
        heal,
        showStats,
        quiteGame
    }
    public class ChoicePosibility
    {
        public static void Posi(Posibililty posibililty)
        {
            Posibililty a = Posibililty.fight;
            Posibililty b = Posibililty.heal;
            Posibililty c = Posibililty.showStats;
            Posibililty d = Posibililty.quiteGame;

            Console.WriteLine($"0: {a} Combatre\n2: {b} Se soigner\n3: {c} Voir les stats\n4: {d} quitter la partie\n2");
            
            switch (posibililty)
            {
                case Posibililty.fight:
                    Console.WriteLine($"Vous decidez d'attaquer !");
                    break;
                case Posibililty.heal:
                    Console.WriteLine($"Vous decidez de vous soigner !");
                    break;
                case Posibililty.showStats:
                    Console.WriteLine($"Vous decidez de regarder vos stats !");
                    break;
                case Posibililty.quiteGame:
                    Console.WriteLine($"Vous decidez de quitter !");
                    break;
                default:
                    break;
            }
        }


    }


}
