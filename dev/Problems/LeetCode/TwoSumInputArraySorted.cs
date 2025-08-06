namespace Problems.LeetCode
{
    using Problems.Interfaces;

    public class TwoSumInputArraySorted : IProblem<(int[] numbers, int target), int[]>
    {
        public string ProblemName => "Two Sum II - Input Array Is Sorted";
        public string URL => "https://leetcode.com/problems/two-sum-ii-input-array-is-sorted";
        public string AdditionalNotes => "Two pointers";

        public int[] Solve((int[] numbers, int target) input)
        {
            var (numbers, target) = input;

            int i = 0, j = numbers.Length - 1;
            int[] result = new int[2];
            while (i < j)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                    break;
                }
                else if (numbers[i] + numbers[j] < target)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            
            return result;
        }
    }
}