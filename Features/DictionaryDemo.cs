namespace CSharpNotebook.Features;

public class DictionaryDemo
{
    public void NewDictionary()
    {
        var map = new Dictionary<string, int>();
        map["apple"] = 3;
        if (map.ContainsKey("apple"))
        {
            Console.WriteLine(map["apple"]);
        }
        var key = "pear";
        map[key] = map.GetValueOrDefault(key) + 1;
        
        // log map
        foreach (var kv in map)
        {
            Console.WriteLine($"{kv.Key}: {kv.Value}");
        }
    }

    public static void Run()
    {
        new DictionaryDemo().NewDictionary();
    }
}