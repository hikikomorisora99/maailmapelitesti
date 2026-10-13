

// Tervehdys
    Console.WriteLine("Moikka maailma!");

// Kysytään käyttäjältä jotain
Console.WriteLine("Onko hienoa: ");

// Luetaan käyttäjän vastaus
string vastaus = Console.ReadLine();
Console.WriteLine("Vastasit: " + vastaus);
Kysymys();

void Kysymys()
{
 // Kysytään käyttäjältä numero
Console.WriteLine("Anna numero 1-100: ");
string numero = Console.ReadLine();
if (numero == "4")
{
    Voitto();
}
else if (numero == "67")
{
    Console.WriteLine("HEHE 6767676767");
    Häviö();
}

else
{
    Häviö();
}   
}

void Voitto()
{
    Console.WriteLine("Arvasit oikein!");
    Console.WriteLine("Paina mitä tahansa näppäintä sulkeaksesi peli");
    Console.ReadLine();
}

void Häviö()
{
    Console.WriteLine("Hävisit pelin lol");
    Console.WriteLine("Haluatko yrittää uudestaan? y/n");

    string vastaus = Console.ReadLine();

    if(vastaus == "y")
    {
        Kysymys();
    }

    else if (vastaus == "n")
    {
        Console.WriteLine("Moi sitten");
    }

    else 
    {
        Console.WriteLine("Komentoa ei tunnistettu");
        Häviö();
    }
}