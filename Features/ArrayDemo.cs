namespace CSharpNotebook.Features;

public static class ArrayDemo
{
    public static void Run()
    {
        // assign default value
        int m = 100, n = 100;
        // option 1
        bool[][] visited = new bool[m][];
        for (int i = 0; i < m; i++)
        {
            visited[i] = new bool[n];
            for (int j = 0; j < n; j++)
            {
                visited[i][j] = true;
            }
        }

        // option 2
        visited = Enumerable.Repeat(true, m).Select(_ => Enumerable.Repeat(true, n).ToArray()).ToArray();

        printArray(visited);
    }

    static void printArray(bool[][] arr)
    {
        foreach (var row in arr)
        {
            Console.WriteLine(string.Join(", ", row));
        }
    }

    static void sortAndSum(int[] arr)
    {
        int sum = arr.Sum();
        Array.Sort(arr);
        Console.WriteLine(sum);
        Console.WriteLine(arr.Length);
    }
}