namespace Problems.Tests.LeetCode
{
    using Problems.LeetCode;
    using Xunit;

    public class LongestSubstringWithoutRepeatingTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { "abcabcbb", 3 },
                new object[] { "bbbbb", 1 },
                new object[] { "pwwkew", 3 },
                new object[] { string.Empty, 0 },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solve_ReturnsCorrectLength(string s, int expectedResult)
        {
            var problem = new LongestSubstringWithoutRepeating();
            var result = problem.Solve(s);

            Assert.Equal(expectedResult, result);
        }
    }
}