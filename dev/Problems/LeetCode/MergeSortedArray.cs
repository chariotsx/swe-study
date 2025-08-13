namespace Problems.LeetCode
{
    using Problems.Interfaces;

    public class MergeSortedArray : IProblem<(int[] nums1, int m, int[] nums2, int n), int[]>
    {
        public string ProblemName => "Merge Sorted Array";
        public string URL => "https://leetcode.com/problems/merge-sorted-array";
        public string AdditionalNotes => "Two Pointers, O(1) in memory";

        public int[] Solve((int[] nums1, int m, int[] nums2, int n) input)
        {
            var (nums1, m, nums2, n) = input;

            int mIndex = m - 1;
            int nIndex = n - 1;
            int writeIndex = nums1.Length - 1;

            while (nIndex >= 0)
            {
                if (mIndex >= 0 && nums1[mIndex] > nums2[nIndex])
                {
                    nums1[writeIndex--] = nums1[mIndex--];
                }
                else
                {
                    nums1[writeIndex--] = nums2[nIndex--];
                }
            }
            
            return nums1;
        }
    }
}