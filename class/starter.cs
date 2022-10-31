using pokemonApp.@class;

namespace pokemonApp
{
    public class Bulbizarre : Pokemon
    {
        public Bulbizarre(string? name, int pv, int atk, int def, int vit) : base(name, pv, atk, def, vit)
        {
            Name = "Bulbizarre";
            Pv = 45;
            Atk = 49;
            Def = 49;
            Vit = 45;
        }
        
    }
    public class Salameche : Pokemon
    {
        public Salameche(string? name, int pv, int atk, int def, int vit) : base(name, pv, atk, def, vit)
        {
            Name = "Salamèche";
            Pv = 39;
            Atk = 52;
            Def = 43;
            Vit = 65;
        }
    }
    public class Carapuce : Pokemon
    {
        public Carapuce(string? name, int pv, int atk, int def, int vit) : base(name, pv, atk, def, vit)
        {
            Name = "Carapuce";
            Pv = 44;
            Atk = 48;
            Def = 65;
            Vit = 43;
        }
    }
}

