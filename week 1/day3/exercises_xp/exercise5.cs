Console.Write("enter a number from 1 to 100 :");
int user_num = int.Parse(Console.ReadLine());
void RandomNumberGenerator(int user_num)
{
    Random rand = new Random();
    int randNum = rand.Next(1,101);
    if (user_num >=1 && user_num<=100)
    {
        if (randNum == user_num)
    {
        Console.WriteLine("Success message");
    }
    else
    {
        Console.WriteLine("Fail message");
        Console.WriteLine($"your number:{user_num}     bot number:{randNum}");

    }
    }
    else
    {
        Console.WriteLine("your number is out of range!");
    }
}
RandomNumberGenerator(user_num);