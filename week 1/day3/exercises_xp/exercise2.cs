int total = 0;
Dictionary<string, int> family = new Dictionary<string, int>
{
    {"rick", 43}, 
    {"beth", 13}, 
    {"morty", 5}, 
    {"summer", 8}
};
foreach(var costumer in family)
{

    if (costumer.Value < 3)
    {

        Console.WriteLine($"{costumer.Key} will pay 0$");
    }else if (costumer.Value < 12 && costumer.Value > 3)
    {
        Console.WriteLine($"{costumer.Key} will pay 10$");
        total += 10;
    }
    else
    {
        Console.WriteLine($"{costumer.Key} will pay 15$");
        total+=15;
    }

}
Console.WriteLine("the total price is: "+total+"$");