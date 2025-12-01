var data = new List<Dictionary<string, string>>
{
    new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
    new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
    new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
    new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
    new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
    new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
};
int errCount = 0;
List<string> errors = new List<string>();
void Quiz()
{

    Console.WriteLine("Hello and wellcom to Starwas Quiz!");
    for (int i =0 ; i <data.Count;i++)
    {
        Console.WriteLine($"question {i+1}:");
        Console.WriteLine(data[i]["question"]);
        Console.Write("answer: ");
        string answer = Console.ReadLine();
        if (data[i]["answer"].ToLower() != answer.ToLower())
        {
            errCount++;
            errors.Add(answer);
        }else
        {
            errors.Add("correct,.;~`");  //
        }
    }
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<RESULT>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    for(int i =0 ; i < data.Count; i++)
    {
        Console.WriteLine($"question {i+1}:");
        Console.WriteLine(data[i]["question"]);
        if (errors[i] == "correct,.;~`")
        {
            Console.WriteLine("your answer is correct!");
        }else
        {
            Console.WriteLine("your answer is incorrect!");
            Console.WriteLine($"your answer: {errors[i]}");
        }
        Console.WriteLine($"the correct answer: {data[i]["answer"]}");

    }
}
Quiz();
Console.WriteLine($"you answer {data.Count-errCount} from {data.Count} questions");