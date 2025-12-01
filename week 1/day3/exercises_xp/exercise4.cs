void DescribeCity(string city, string country = "Iceland")
{
    Console.WriteLine($"{city} is in {country}.");
}
DescribeCity("rabat","Morocco");
DescribeCity("Reykjavík");
DescribeCity("cairo","Egypt");
DescribeCity("paris","France");