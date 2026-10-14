using System;
using System.IO;
using System.Text;

namespace Pelitesti
{
class Program
{
    // Määritellään muuttujat
public static string vastaus;
public static string numero;


static void Main()
{
    // Aloitetaan peli
    Console.WriteLine("Tervetuloa arvauspeliin! Paina mitä tahansa näppäintä aloittaaksesi");
    Console.ReadKey();
    Aloitus();
}

static void Aloitus()
{
// Tervehdys
Console.WriteLine("Moikka pelaaja! Mikä on nimesi?");

string nimi = Console.ReadLine();
Console.WriteLine($"Hauska tutustua {nimi}! Paina mitä tahansa näppäintä jatkaaksesi");

// Luetaan käyttäjän vastaus
Console.ReadKey();
Kysymys();
}
static void Kysymys()
{
 // Kysytään käyttäjältä numero
Console.WriteLine("Anna numero 1-500: ");

// Luetaan käyttäjän vastaus ja tarkistetaan se
numero = Console.ReadLine();
switch (numero)
{
    case "42":
        Voitto();
        break;

    case "69":
        Easter1();
        break;

    case "67":
        Easter2();
        break;

    case "420":
        Easter3();
        break;

    default:
        Häviö();
        break;
}
}

static void Voitto()
{
    Console.WriteLine("Arvasit oikein!");
    Console.WriteLine("Paina mitä tahansa näppäintä sulkeaksesi peli");
    Console.ReadKey();
}

static void Häviö()
{
    Console.WriteLine("Hävisit pelin lol");
    Console.WriteLine("Haluatko yrittää uudestaan? y/n");

    vastaus = Console.ReadLine();

    if(vastaus == "y")
    {
        Kysymys();
    }

    else if (vastaus == "n")
    {
        Console.WriteLine("Moi sitten");
        Console.ReadKey();
    }

    else 
    {
        Console.WriteLine("Komentoa ei tunnistettu");
        Häviö();
    }
}

public static void Easter1()
{
    Console.WriteLine("Easter egg 1 löytyi!");
    Console.OutputEncoding = Encoding.UTF8;
    string easter1 = File.ReadAllText("1.txt");
    Console.WriteLine(easter1);
    Console.ReadKey();
    Kysymys();
}

public static void Easter2()
{
    Console.WriteLine("Easter egg 2 löytyi!");
    Console.OutputEncoding = Encoding.UTF8;
    string easter2 = File.ReadAllText("2.txt");
    Console.WriteLine(easter2);
    Console.ReadKey();
    Kysymys();
}

public static void Easter3()
{
    Console.WriteLine("Easter egg 3 löytyi!");
    Console.OutputEncoding = Encoding.UTF8;
    string easter3 = File.ReadAllText("3.txt");
    Console.WriteLine(easter3);
    Console.ReadKey();
    Kysymys();
}
}
}