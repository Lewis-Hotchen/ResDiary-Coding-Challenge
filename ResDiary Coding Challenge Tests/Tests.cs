using ResDiary_Coding_Challenge;

namespace ResDiary_Coding_Challenge_Tests
{
    public class Tests
    {

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 4)]
        [TestCase(new int[] { 1, 2, 3 }, 1)]
        public void ShouldReturnCorrectAmountOfGroups(int[] elements, int groupCount)
        {
            var result = GroupArrayElementsHelper.GroupArrayElements(elements, groupCount);
            Assert.That(result, Has.Length.EqualTo(groupCount));
        }

        [Test]
        public void ShouldReturnCorrectGroup()
        {
            var testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var testCount = 4;

            var result = GroupArrayElementsHelper.GroupArrayElements(testArray, testCount);
            
            //Asserting that the same amount of elemts are in the starting array as the result array
            Assert.That(testArray.Intersect(result.SelectMany(x => x)).Count(), Is.EqualTo(testArray.Length)); 
        }
    }
}