internal class Program
{
    private static void Main(string[] args)
    {
        //Output some test cases
        PrintGroupResults(new int[] { 1, 2, 3, 4, 5 }, 3); // [[1,2][3,4][5]]
        PrintGroupResults(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 4); // [[1,2,3][4,5,6][7,8,9][10]]
        PrintGroupResults(new int[] { 1, 2, 3 }, 1); //[[1,2,3]]
    }

    private static void PrintGroupResults(int[] elements, int groupCount)
    {
        var groupedElements = GroupArrayElements(elements, groupCount);
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

    private static int[][] GroupArrayElements(int[] elements, int groupCount)
    {
        int numberOfElementsInAGroup = (int) Math.Ceiling((decimal)elements.Length / groupCount);
        int numberOfGroups = (int) Math.Round((decimal)elements.Length / numberOfElementsInAGroup);
        int trailingGroupElementCount = 0;
        int[][] groupedResults;

        if (elements.Length % numberOfGroups > 0) { //Check if the array is not split evenly
            trailingGroupElementCount = elements.Length % numberOfElementsInAGroup;
            groupedResults = new int[numberOfGroups + 1][]; //Assign one extra element for the trailing group
        }
        else
        {
            groupedResults = new int[numberOfGroups][];
        }

        int index;
        for (index = 0; index < numberOfGroups; index++) {
            int[] groupedArray = new int[numberOfElementsInAGroup];
            Array.Copy(elements, index * numberOfGroups, groupedArray, 0, numberOfElementsInAGroup);
            groupedResults[index] = groupedArray;
        }

        if(trailingGroupElementCount > 0)
        {
            int[] remainedGroupedArray = new int[trailingGroupElementCount];
            Array.Copy(elements, elements.Length - trailingGroupElementCount, remainedGroupedArray, 0, trailingGroupElementCount);
            groupedResults[index] = remainedGroupedArray;
        }

        return groupedResults;
    }
}