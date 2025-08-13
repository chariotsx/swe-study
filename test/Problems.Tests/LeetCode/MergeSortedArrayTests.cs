namespace Problems.Tests.Leetcode
{
    using Problems.LeetCode;
    using Xunit;

    public class MergeSortedArrayTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { new[] { 1, 2, 3, 0, 0, 0 }, 3, new object[] { 2, 5, 6 }, 3, new object[] { 1, 2, 2, 3, 5, 6 }  },
                new object[] { new[] { 1 }, 1, new object[] { } , 0, new object[] { 1 } },
                new object[] { new[] { 0 }, 0, new object[] { 1 } , 1, new object[] { 1 } },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solve_ReturnsCorrectArray(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
        {
            var problem = new MergeSortedArray();
            var result = problem.Solve((nums1, m, nums2, n));

            Assert.Equal(expectedResult, result);
        }
    }
}