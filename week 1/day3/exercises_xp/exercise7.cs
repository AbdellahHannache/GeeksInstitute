int GetRandomTemp(string season)
{
    Random rnd = new Random();
    int min = -10, max = 40;

    if (season == "winter") { min = -10; max = 16; }
    if (season == "spring") { min = 0; max = 23; }
    if (season == "summer") { min = 16; max = 40; }
    if (season == "autumn") { min = 0; max = 23; }

    return rnd.Next(min, max + 1);
}
void Main()
{
    Console.Write("enter a season: ");
    string inp = Console.ReadLine();
    Console.WriteLine($"the current temperature is {GetRandomTemp(inp)}.");
    if (-10<GetRandomTemp(inp) && GetRandomTemp(inp)<11) { Console.WriteLine("wear warm layers, cover skin, and limit time outside."); }
    if (11<=GetRandomTemp(inp) && GetRandomTemp(inp)<21) { Console.WriteLine("light jacket or layers, comfortable for outdoor activities."); }
    if (21<=GetRandomTemp(inp) && GetRandomTemp(inp)<30) { Console.WriteLine("light breathable clothing, stay hydrated, avoid midday sun."); }
    if (30<=GetRandomTemp(inp) && GetRandomTemp(inp)<=40) { Console.WriteLine("minimal breathable clothing, shade, protect from sun and heat, drink plenty of water."); }

}
Main();