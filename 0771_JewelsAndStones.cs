public class Solution {
    public int NumJewelsInStones(string J, string S)
    {
      var result = 0;
      var jewels = J.ToCharArray();
      var stones = S.ToCharArray();

      foreach (var jewel in jewels)
      {
        foreach (var stone in stones)
        {
          if (jewel == stone)
          {
            result++;
          }
        }
      }
      return result;
    }
}
