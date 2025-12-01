List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
List<int> values = new List<int> { 10, 20, 30 };

Dictionary<string,int> numbers = new Dictionary<string, int>() ;
for (int i = 0; i < keys.Count;i++)
{
    numbers[keys[i]]=values[i];
}
int counter= 0;
Console.Write("{ ");
foreach (var ke in numbers)
{
    counter++;
    Console.Write(ke.Key+ ':' +ke.Value);
    if (numbers.Count > counter)
    {
        Console.Write(',');
    }

}
Console.WriteLine('}');