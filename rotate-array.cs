public class Solution {
    public void Rotate(int[] nums, int k) {
        
        int len = nums.Length;
            
            if (len > k)
            {
                int newLen = Math.Abs(len - k);
                int[] nums2 = new int[newLen];

                for (int i = 0; i < newLen; i++)
                {
                    nums2[i] = nums[i];
                }




                for (int i = newLen; i < len; i++)
                {
                    nums[i - newLen] = nums[i];

                }


                for (int i = 0; i < newLen; i++)
                {
                    nums[i + k] = nums2[i];
                }

            }
            else
            {
                int q = k % len;
                int newLen = len - q;
                int[] nums2 = new int[newLen];
                for (int i = 0; i < newLen; i++)
                {
                    nums2[i] = nums[i];
                    
                }
                for (int i = newLen; i < len; i++)
                {
                    nums[i - newLen] = nums[i];

                }
                for (int i = 0; i < newLen; i++)
                {
                    nums[i + q] = nums2[i];
                }

            }

}}
