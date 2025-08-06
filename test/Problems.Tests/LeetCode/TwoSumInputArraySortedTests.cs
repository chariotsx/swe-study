namespace Problems.Tests.Leetcode
{
    using Problems.LeetCode;
    using Xunit;

    public class TwoSumInputArraySortedTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { new[] {2, 7, 11, 15}, 9, new object[] { 1, 2 } },
                new object[] { new[] {2, 3, 4}, 6, new object[] { 1, 3 } },
                new object[] { new[] {-1, 0}, -1, new object[] { 1, 2 } },
                new object[] { new[] {1, 2, 3}, 7, new int[2] },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solve_ReturnsCorrectIndices(int[] numbers, int target, int[] expectedResult)
        {
            var problem = new TwoSumInputArraySorted();
            var result = problem.Solve((numbers, target));

            Assert.Equal(expectedResult, result);
        }
    }
}