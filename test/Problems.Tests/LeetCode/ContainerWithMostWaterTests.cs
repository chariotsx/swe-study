namespace Problems.Tests.LeetCode
{
    using Problems.LeetCode;
    using Xunit;

    public class ContainerWithMostWaterTests
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49 },
                new object[] { new int[] { 1, 1 }, 1 },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Solve_ReturnsCorrectArea(int[] height, int expectedResult)
        {
            var problem = new ContainerWithMostWater();
            var result = problem.Solve(height);

            Assert.Equal(expectedResult, result);
        }
    }
}