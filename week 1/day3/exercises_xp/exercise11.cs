using System;
class Song
{
    public  List<string> lyrics = new List<string>();
    public Song(List<string> Lyrics)
    {
        lyrics=Lyrics;
    }
    public void SingMeASong()
    {
        for(int i=0 ; i < lyrics.Count; i++)
        {
            Console.WriteLine(lyrics[i]);
        }
    }
}
class Program
{
    static void Main()
    {
        var stairway = new Song(new List<string>{
            "There’s a lady who's sure",
            "all that glitters is gold",
            "and she’s buying a stairway to heaven"
        });
        stairway.SingMeASong();
    }
}