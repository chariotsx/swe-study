namespace Problems.LeetCode
{
    using Problems.Interfaces;

    public class ContainerWithMostWater : IProblem<int[], int>
    {
        public string ProblemName => "Container With Most Water";
        public string URL => "https://leetcode.com/problems/container-with-most-water";
        public string AdditionalNotes => "Two Pointers";

        public int Solve(int[] height)
        {
            int result = 0;
            int left = 0, right = height.Length - 1;

            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                result = Math.Max(result, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }
    }
}
