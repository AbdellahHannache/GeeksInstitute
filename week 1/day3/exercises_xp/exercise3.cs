using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var brand = new Dictionary<string, object>
        {
            {"name", "Zara"},
            {"creation_date", 1975},
            {"creator_name", "Amancio Ortega Gaona"},
            {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
            {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
            {"number_stores", 7000},
            {"major_color", new Dictionary<string, List<string>>
                {
                    {"France", new List<string>{"blue"}},
                    {"Spain", new List<string>{"red"}},
                    {"US", new List<string>{"pink", "green"}}
                }
            }
        };

        // 1. Change number_stores to 2.
        brand["number_stores"] = 2;

        // 2. Print a sentence explaining Zara’s clients.
        var typeOfClothes = (List<string>)brand["type_of_clothes"];
        Console.WriteLine($"Zara’s clients are: {string.Join(", ", typeOfClothes)}.");

        // 3. Add country_creation = "Spain".
        brand["country_creation"] = "Spain";

        // 4. Check if international_competitors exists and add "Desigual".
        if (brand.ContainsKey("international_competitors"))
        {
            var competitors = (List<string>)brand["international_competitors"];
            competitors.Add("Desigual");
        }

        // 5. Delete creation_date.
        brand.Remove("creation_date");

        // 6. Print the last international competitor.
        var international_competitors = (List<string>)brand["international_competitors"];
        Console.WriteLine("Last international competitor: " +
            international_competitors[international_competitors.Count - 1]);

        // 7. Print the major colors in the US.
        var majorColor = (Dictionary<string, List<string>>)brand["major_color"];
        Console.WriteLine("Major colors in the US: " + string.Join(", ", majorColor["US"]));

        // 8. Print the number of key-value pairs.
        Console.WriteLine($"The dictionary contains {brand.Count} key-value pairs.");

        // 9. Print all the keys.
        Console.WriteLine("All keys:");
        foreach (var key in brand.Keys)
        {
            Console.WriteLine($"- {key}");
        }

        // 10. Merge another dictionary.
        var more_on_zara = new Dictionary<string, object>
        {
            {"creation_date", 1975},
            {"number_stores", 10000}
        };

        foreach (var item in more_on_zara)
        {
            brand[item.Key] = item.Value;
        }

        // 11. Print number_stores and explain.
        Console.WriteLine($"After merging, number_stores = {brand["number_stores"]}");
        Console.WriteLine("Explanation: The value from more_on_zara overwrote the old one.");
    }
}
