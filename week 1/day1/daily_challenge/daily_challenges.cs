//challenge 1
Console.Write("inter a number: ");
string num=Console.ReadLine();
Console.Write("enter the lenth: ");
string len=Console.ReadLine();
int n=int.Parse(num);
int l=int.Parse(len);
List<int> multiples=new List<int> {};

for (int i=1 ; i<=l ; i++)
{
    multiples.Add(n*i);
    Console.Write(multiples[i-1] + " ");

}

//challenge 2
Console.Write("enter a string: ");
string str=Console.ReadLine();
int len=str.Length;
string result="";
result+=str[0].ToString();
for (int i=0 ; i<len-1 ; i++)
{
    string a = str[i].ToString();
    string b = str[i+1].ToString();
    if (a != b)
    {
        result+=b;
    }
}
Console.WriteLine(result);
