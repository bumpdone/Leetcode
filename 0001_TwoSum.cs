public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
      for (int i = 0; i < nums.Length; i++)
      {
        for (int x = i + 1; x < nums.Length; x++)
        {
          if (nums[i] + nums[x] == target)
          {         
            return new[] { i, x };
          }
        }
      }
      throw new ArgumentException("None");
    }
}
