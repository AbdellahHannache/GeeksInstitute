Console.Write("hello , give me a word: ");
string str = Console.ReadLine();
int counter=0;
Dictionary<char,List<int>> register= new();
for (int i = 0; i < str.Length; i++)
{
    if (!register.ContainsKey(str[i]))
    {
        register[str[i]]= new List<int>();
        register[str[i]].Add(i);


    }
    else if (register.ContainsKey(str[i]))
    {
        register[str[i]].Add(i);
    }
}
Console.Write("{");
foreach(var itm in register)
{
    counter++;
    Console.Write($" {itm.Key} : [{string.Join(", ", itm.Value)}] ");
    if (counter < register.Count)
    {
        Console.Write(',');
    }
}
Console.Write("}");
