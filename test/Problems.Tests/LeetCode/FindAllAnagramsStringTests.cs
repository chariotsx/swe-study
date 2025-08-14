namespace Problems.Tests.Leetcode
{
    using Problems.LeetCode;
    using Xunit;

    public class FindAllAnagramsStringTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { "cbaebabacd", "abc" , new List<int> { 0, 6 } },
                new object[] { "abab", "ab" , new List<int> { 0, 1, 2 } },
                new object[] { "aaaaa", "aaaaa" , new List<int> { 0 } },
                new object[] { "a", "b" , new List<int>() },
                new object[] { "ab", "abc" , new List<int> () },
                new object[] { "aaaaaaaaaa", "aaaaaaaaaaaaa" , new List<int> () },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solve_ReturnsCorrectIndexes(string s, string p, List<int> expectedResult)
        {
            var problem = new FindAllAnagramsString();
            var result = problem.Solve((s, p));

            Assert.Equal(expectedResult, result);
        }
    }
}