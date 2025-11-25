//Exercise 1: The Greeting
Console.WriteLine("Welcome to C# Programming!");
//Exercise 2: Personal Info
string name = "Abdellah";
int age = 20;
Console.WriteLine($"My name is {name} and I am {age} years old.");
//Exercise 3: The Calculator
int num1=12;
int num2=20;
int sum = num1 + num2;
 
Console.WriteLine($"the sum of {num1} and {num2} is {sum}");
//Exercise 4: The Bouncer (If/Else)
int userAge=cl5;
if (userAge >= 18)
{
    Console.WriteLine("Access granted");
}
else
{
    Console.WriteLine("Access denied");
}
//Exercise 5: The Countdown (Loops)
int i=10;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}
Console.WriteLine("Liftoff");
//Exercise 6: The Repeater (Functions)
void sayHello(string name)
{
    Console.WriteLine($"Hello {name} !");
}
sayHello("Abdellah");
sayHello("mohamed");
sayHello("sara");
//Exercise 7: Even or Odd?
for(int x=1; x<=10; x++)
{
    if (x%2 == 0)
    {
        Console.WriteLine($"the number {x} is even");
    }else
    {
        Console.WriteLine($"the number {x} is odd");
    }
}
//Exercise 8: Temperature Converter
Console.Write("give me the temperature in celsius : ");
double tempC = double.Parse(Console.ReadLine());
double tempF = tempC*9/5 +32;
Console.WriteLine($"the temperature in fahrenheit is : {tempF} F");
//Exercise 9: Number Swapper
int a = 12;
int b = 20;
int temp = a;
a=b;
b=temp;
Console.WriteLine($"after swapping : a= {a},b= {b}");
//Exercise 10: Simple Multiplication Table
Console.Write("Multiplication Table from 1 to 10 of : ");
int num = int.Parse(Console.ReadLine());
for (int i =1 ;i<=10; i++)
{
    int result = num*i;
    Console.WriteLine($"{num} x {i} = {result}");
}
