//exercice 1
Dictionary<string,string> birthday = new();
birthday["Shigeru Miyamoto"]="1952/11/16";
birthday["Markus Persson"]="1979/06/01";
birthday["Cory Barlog"]="1979/06/02";
birthday["Satoshi Tajiri"]="1965/08/28";
birthday["Shinji Mikami"]="1965/08/11";

Console.WriteLine("Welcome!👋");
Console.WriteLine("you can explre and look up birthdays of famous game creators.");
Console.Write("Enter the name of the person: ");
string person = Console.ReadLine();
if (birthday.ContainsKey(person))
{
    Console.WriteLine($"{person} born in {birthday[person]}");
}
else
{
    Console.WriteLine("sorry . the person you are looking for is not existing in our list");
}
//exercice2
Dictionary<string,string> birthday = new();
birthday["Shigeru Miyamoto"]="1952/11/16";
birthday["Markus Persson"]="1979/06/01";
birthday["Cory Barlog"]="1979/06/02";
birthday["Satoshi Tajiri"]="1965/08/28";
birthday["Shinji Mikami"]="1965/08/11";

foreach (var item in birthday)
{

    Console.WriteLine($"_ {item.Key}");

}
Console.WriteLine("hello! wellcom to see you again");
Console.Write("please give me a name from the the lis above : ");
string input = Console.ReadLine();
if (birthday.ContainsKey(input))
{
    Console.WriteLine($"{input} born in {birthday[input]}");
}
else
{
    Console.WriteLine($"Sorry, we don’t have the birthday information for {input}");
}
//exercise 3
Console.WriteLine("hello!");
Console.Write("please give me a number : ");
int y= int.Parse(Console.ReadLine());
void sumSequ(int x)
{
    int result = 0;
    string sequance= x.ToString();
    for(int i=0 ; i < 4; i++)
    {
        result+=int.Parse(sequance);
        sequance+= x.ToString();
    }
    Console.WriteLine(result);

}
sumSequ(y);
// exercice 4
Random random = new Random();
int ThrowDice()
{
    return random.Next(1,7);
}
int ThrowUntilDoubles()
{
    int rolls = 0;
    int die1 , die2;
    do
    {
        die1 = ThrowDice();
        die2 = ThrowDice();
        rolls++;
    }while(die1!=die2);
    return rolls;
}
void MainSimulation()
{
    List<int> Nrolls= new();
    int TotalRolls=0;
    int r;
    for(int i = 0; i < 100; i++)
    {
        r = ThrowUntilDoubles();
        Nrolls.Add(r);
        TotalRolls+=r;
        Console.WriteLine($"R{i+1}__{r}");
    }

    Console.WriteLine($"the total rolls is : {TotalRolls}");


}
MainSimulation();
