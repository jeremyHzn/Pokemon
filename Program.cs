using pokemonApp;

Console.WriteLine("choisi : Salameche, bulbizzare, carrapuce :");
switch (Console.ReadLine())
{
	case "Salameche":
		var salameche = new Salameche();
        Console.WriteLine($"tu as choisi {salameche.Name}");
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
    continuer = (choix == "n") ? false : true;
}