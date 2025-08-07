namespace Problems.LeetCode
{
    using Problems.Interfaces;

    public class LongestSubstringWithoutRepeating : IProblem<string, int>
    {
        public string ProblemName => "Longest Substring Without Repeating Characters";
        public string URL => "https://leetcode.com/problems/longest-substring-without-repeating-characters";
        public string AdditionalNotes => "Two Pointers, Sliding Window";

        public int Solve(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var characterSeen = new HashSet<char>();
            int maxLength = 0;
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (characterSeen.Contains(s[right]))
                {
                    characterSeen.Remove(s[left]);
                    left++;
                }

                characterSeen.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}