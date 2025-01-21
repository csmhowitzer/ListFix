using System.Text.Json;

namespace ListFix;

class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>();
        for(int i = 0; i < 100; i++)
        {
            list.Add(i+1);
        }
        list.Shuffle();
        Console.WriteLine(JsonSerializer.Serialize(list));
    }
}
public static class ListExtension
{
    private static Random rng = new Random();

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count();
        while(n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
