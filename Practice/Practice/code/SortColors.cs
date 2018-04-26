using System;
namespace Practice.Code
{
    public class SortColors
    {
        public void SortCol(int[] nums)
        {
            int begin = 0;
            int cur = 0;


            if (nums == null || nums.Length <= 1)
            {
                return;
            }

            int end = nums.Length - 1;

            while (cur <= end)
            {
                if (nums[cur] == 0)
                {
                    nums[cur] = nums[begin];
                    nums[begin] = 0;
                    begin++;
                    cur++;

                }
                else if (nums[cur] == 1)
                {
                    cur++;
                }
                else
                {
                    nums[cur] = nums[end];
                    nums[end] = 2;
                    end--;
                }
            }

        }
    }
}

