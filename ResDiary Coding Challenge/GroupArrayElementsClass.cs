namespace ResDiary_Coding_Challenge
{
    public static class GroupArrayElementsHelper
    {
        public static int[][] GroupArrayElements(int[] elements, int groupCount)
        {
            int numberOfElementsInAGroup = (int)Math.Ceiling((decimal)elements.Length / groupCount);
            int numberOfGroups = (int)Math.Floor((decimal)elements.Length / numberOfElementsInAGroup);
            int trailingGroupElementCount = 0;
            int[][] groupedResults;

            if (elements.Length % numberOfGroups > 0)
            { //Check if the array is not split evenly
                trailingGroupElementCount = elements.Length % numberOfElementsInAGroup;
                groupedResults = new int[numberOfGroups + 1][]; //Assign one extra element for the trailing group
            }
            else
            {
                groupedResults = new int[numberOfGroups][];
            }

            int index;
            for (index = 0; index < numberOfGroups; index++)
            {
                int[] groupedArray = new int[numberOfElementsInAGroup];
                Array.Copy(elements, index * numberOfGroups, groupedArray, 0, numberOfElementsInAGroup);
                groupedResults[index] = groupedArray;
            }

            if (trailingGroupElementCount > 0)
            {
                int[] remainedGroupedArray = new int[trailingGroupElementCount];
                Array.Copy(elements, elements.Length - trailingGroupElementCount, remainedGroupedArray, 0, trailingGroupElementCount);
                groupedResults[index] = remainedGroupedArray;
            }

            return groupedResults;
        }
    }
}