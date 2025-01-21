using System.Threading.Channels;

List<string> kahveler = new List<string>();

Console.WriteLine("5 Tane Kahve İsmi Giriniz:");

string kahve;

for (int i = 1; i < 6; i++)
{
    Console.Write("Kahve " + i + ": ");
    kahve = Console.ReadLine();
    kahveler.Add(kahve);    
}

Console.WriteLine("\nGirilen Kahve İsimleri:");
foreach (string item in kahveler)
{
    Console.WriteLine(item);
}
