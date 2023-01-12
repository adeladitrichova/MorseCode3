using ConsoleApp1;

bool konec = false;
do
{
    Console.WriteLine("Menu");
    Console.WriteLine("0 -> End program");
    Console.WriteLine("1 -> Encode");
    Console.WriteLine("2 -> Decode");
    int volba = ReadInt();
    switch (volba)
    {
        case 0:
            konec = true;
            break;
        case 1:
            Encode();
            break;
        case 2:
            Decode();
            break;
        default:
            Console.WriteLine("Neplatná volba");
            break;
    }
} while (!konec);

int ReadInt()
{
    int cislo;
    while (!int.TryParse(Console.ReadLine(), out cislo))
    {
        Console.WriteLine("Neplatný vstup, zadej číslo!");
    }
    return cislo;
}

void Encode()
{
    MorseCode m = new MorseCode();
    Console.WriteLine("Zadej text pro zakódování: ");
    Console.WriteLine(m.Encode(Console.ReadLine()));
}

void Decode()
{
    MorseCode m = new MorseCode();
    Console.WriteLine("Zadej kód pro rozkódování: ");
    Console.WriteLine(m.Decode(Console.ReadLine()));
}
