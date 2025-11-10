namespace CSharpNotebook.Features;

public class StackDemo
{
    public int MinOperations(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        int result = 0;
        Stack<int> stack = new Stack<int>();

        foreach (int num in nums)
        {
            while (stack.Count > 0 && stack.Peek() > num)
            {
                result++;
                stack.Pop();
            }

            if (num == 0)
                continue;

            if (stack.Count == 0 || stack.Peek() < num)
                stack.Push(num);
        }

        return result + stack.Count;
    }
}