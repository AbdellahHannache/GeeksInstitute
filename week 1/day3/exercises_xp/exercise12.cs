using System;
using System.Collections.Generic;
using System.Linq;

class Zoo
{
    public string name;
    public List<string> animals;

    public Zoo(string zooName)
    {
        name = zooName;
        animals = new List<string>();
    }

    public void AddAnimal(string newAnimal)
    {
        if (!animals.Contains(newAnimal))
        {
            animals.Add(newAnimal);
            Console.WriteLine($"{newAnimal} added to the zoo.");
        }
        else
        {
            Console.WriteLine($"{newAnimal} is already in the zoo.");
        }
    }

    public void GetAnimals()
    {
        Console.WriteLine("Animals in the zoo:");
        foreach (var a in animals)
            Console.WriteLine("- " + a);
    }

    public void SellAnimal(string animalSold)
    {
        if (animals.Contains(animalSold))
        {
            animals.Remove(animalSold);
            Console.WriteLine($"{animalSold} has been sold.");
        }
        else
        {
            Console.WriteLine($"{animalSold} does not exist in the zoo.");
        }
    }

    public Dictionary<char, List<string>> SortAnimals()
    {
        animals.Sort();

        Dictionary<char, List<string>> grouped = new Dictionary<char, List<string>>();

        foreach (var animal in animals)
        {
            char first = animal[0];

            if (!grouped.ContainsKey(first))
                grouped[first] = new List<string>();

            grouped[first].Add(animal);
        }

        return grouped;
    }

    public void GetGroups()
    {
        var groups = SortAnimals();

        Console.WriteLine("Animal Groups:");
        foreach (var group in groups)
        {
            Console.WriteLine($"{group.Key}: [{string.Join(", ", group.Value)}]");
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo newYorkZoo = new Zoo("New York Zoo");

        Console.Write("Which animal should we add to the zoo? ");
        string inputAnimal = Console.ReadLine();
        newYorkZoo.AddAnimal(inputAnimal);

        newYorkZoo.AddAnimal("Bear");
        newYorkZoo.AddAnimal("Baboon");
        newYorkZoo.AddAnimal("Ape");
        newYorkZoo.AddAnimal("Cat");

        newYorkZoo.GetAnimals();

        newYorkZoo.SellAnimal("Bear");

        newYorkZoo.GetAnimals();

        newYorkZoo.GetGroups();
    }
}
