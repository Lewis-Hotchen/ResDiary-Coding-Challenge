using ResDiary_Coding_Challenge;

internal class Program
{
    private static void Main(string[] args)
    {
        //Output some test cases
        PrintGroupResults(new int[] { 1, 2, 3, 4, 5 }, 3); // [[1,2][3,4][5]]
        PrintGroupResults(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}, 4); // [[1,2,3][4,5,6][7,8,9][10,11]]
        PrintGroupResults(new int[] { 1, 2, 3 }, 1); //[[1,2,3]]
    }

    private static void PrintGroupResults(int[] elements, int groupCount)
    {
        var groupedElements = GroupArrayElementsHelper.GroupArrayElements(elements, groupCount);
        foreach (var group in groupedElements)
        {
            Console.Write("[");
            foreach (var element in group)
            {
                Console.Write(element);
            }
            Console.Write("]");
        }
        Console.WriteLine();
    }
}