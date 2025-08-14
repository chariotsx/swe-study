namespace Problems.LeetCode
{
    using Problems.Interfaces;

    public class FindAllAnagramsString : IProblem<(string s, string p), IList<int>>
    {
        public string ProblemName => "Find All Anagrams in a String";
        public string URL => "https://leetcode.com/problems/find-all-anagrams-in-a-string";
        public string AdditionalNotes => "Two Pointers";

        public IList<int> Solve((string s, string p) input)
        {
            var (s, p) = input;

            var result = new List<int>();
            if (s.Length < p.Length)
            {
                return result;
            }

            var sCount = this.BuildCountDictionary(s.Substring(0, p.Length - 1));
            var pCount = this.BuildCountDictionary(p);

            for (int left = 0, right = p.Length - 1; right < s.Length; left++, right++)
            {
                this.Increment(sCount, s[right]);

                if (this.IsSameDictionary(sCount, pCount))
                {
                    result.Add(left);
                }

                if (--sCount[s[left]] == 0)
                {
                    sCount.Remove(s[left]);
                }
            }

            return result;
        }

        private void Increment(Dictionary<char, int> dict, char key)
        {
            dict[key] = dict.ContainsKey(key)
                ? dict[key] + 1
                : 1;
        }

        private Dictionary<char, int> BuildCountDictionary(string str)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in str) {
                this.Increment(dict, c);
            }

            return dict;
        }

        private bool IsSameDictionary(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            return dict1.Count == dict2.Count &&
                dict1.All(kvp => dict2.TryGetValue(kvp.Key, out var value) && value == dict1[kvp.Key]);
        }
    }
}