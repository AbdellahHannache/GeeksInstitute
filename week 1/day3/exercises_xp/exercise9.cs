using System;

class Cat
{
    public string name;
    public int age;

    public Cat(string catName, int catAge)
    {
        name = catName;
        age = catAge;
    }
}

class Program
{
    static void Main()
    {
        Cat cat1 = new Cat("Mimi", 1);
        Cat cat2 = new Cat("Tom", 3);
        Cat cat3 = new Cat("Mimi", 4);
        List<Cat> cats = new List<Cat>{cat1,cat2,cat3};
        Cat oldest=FindOldestCat(cats);
        Console.WriteLine($"the oldest cat is {oldest.name}.it has {oldest.age} years old");

    }
    static Cat FindOldestCat(List<Cat> catList)
    {
        int maxAge = catList.Max(c => c.age);
        return catList.First(c => c.age == maxAge);
    }
}