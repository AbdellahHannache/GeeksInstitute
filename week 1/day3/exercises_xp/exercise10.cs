using System;
class Program
{
    class Dog
    {
        public string name ;
        public int height;
        public Dog(string Name , int Height)
        {
            name = Name;
            height = Height;
        }
        public void bark()
        {
            Console.WriteLine($"{name} goes woof");
        }
        public void jump()
        {
            int x = height*2;
            Console.WriteLine($"{name} jumps {x} cm height");
        }
    }
    static void Main()
    {
        Dog dog1 = new Dog("Rex",50);
        dog1.bark();
        dog1.jump();
        Dog dog2 = new Dog("Teacup",20);
        dog2.bark();
        dog2.jump();
        if (dog1.height>dog2.height)
        {
            Console.WriteLine($"{dog1.name} is taller than {dog2.name}");
        }
        else
        {
            Console.WriteLine($"{dog2.name} is taller than {dog1.name}");
        }

    }
}