using pokemonApp;


Console.WriteLine("choisi : Salameche, bulbizzare, carrapuce :");
var starterChoice = Console.ReadLine();
switch (starterChoice)
{
    case "Salameche":
		var Pokemon = new Salameche();
        Console.WriteLine($"tu as choisi {Pokemon.Name}");
        Console.WriteLine(Pokemon.ActionChoice(Pokemon));
        break;

    case "Bulbizzare":
        var bulbizarre = new Bulbizarre();
        Console.WriteLine($"tu as choisi {bulbizarre.Name}");
        break;
        
    case "Carrapuce":
        var carapuce = new Carapuce();
        Console.WriteLine($"tu as choisi {carapuce.Name}");
        break;
}

bool continuer = true;
while (continuer)
{

    
    Console.WriteLine("souhaitez-vous continuer ? (Y/n)");
    string choix = Console.ReadLine();
    continuer = choix != "quitter";
}
