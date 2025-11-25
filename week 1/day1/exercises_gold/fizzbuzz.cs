//Exercise — FizzBuzz
int num;
while (true)
{
    Console.Write("inter a number from 1 to 100: ");
    num = int.Parse(Console.ReadLine());
    if (num >= 1 && num <= 100)
    {
        break;
    }
    else
    {
        Console.WriteLine("invalid number, please try again");
    }
}
if (num %3 == 0 && num %5 == 0)
{
    Console.Write("FizzBuzz");
}
else if(num%3 == 0){
    Console.Write("Fizz");
}
else if(num%5 == 0){
    Console.Write("Buzz");
}
//Exercise : Build a Triangle Pattern
for(int i = 1; i <= 5; i++)
{
    string disp = new string('*', i);
    Console.WriteLine(disp);
}
//Exercise : Reverse a Word (No Built-in Functions)
Console.Write("Enter a name: ");
string word = Console.ReadLine();
reversedWord = "";
for (int i = word.Length - 1; i >= 0; i--)
{
    reversedWord += word[i];
}
Console.Write($"the reversed word is : {reversedWord}");
