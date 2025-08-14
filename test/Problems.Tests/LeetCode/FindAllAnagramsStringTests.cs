namespace Problems.Tests.LeetCode
{
    using Problems.LeetCode;
    using Xunit;

    public class FindAllAnagramsStringTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
            new object[] { "cbaebabacd", "abc", new[] { 0, 6 } },
            new object[] { "abab", "ab", new[] { 0, 1, 2 } },
            new object[] { "aaaaa", "aaaaa", new[] { 0 } },
            new object[] { "a", "b", Array.Empty<int>() },
            new object[] { "ab", "abc", Array.Empty<int>() },
            new object[] { "aaaaaaaaaa", "aaaaaaaaaaaaa", Array.Empty<int>() },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solve_ReturnsCorrectIndexes(string s, string p, int[] expectedResult)
        {
            var problem = new FindAllAnagramsString();
            var result = problem.Solve((s, p));

            Assert.Equal(expectedResult, result);
        }
    }
}