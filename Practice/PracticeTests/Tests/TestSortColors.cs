using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Code;

namespace PracticeTests.Tests
{
    [TestClass]
    public class TestSortColors
    {
        [TestMethod]
        public void TestFunction()
        {
            SortColors sc = new SortColors();
            int[] nums = new int[6] { 2, 0, 2, 1, 1, 0 };

            sc.SortCol(nums);

            int[] expected = new int[6] { 0, 0, 1, 1, 2, 2 };
            Assert.AreEqual(expected.Length, nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                Assert.AreEqual(expected[i], nums[i]);
            }
        }

        [TestMethod]
        public void Testnull(){
            SortColors sc = new SortColors();
            int[] nums = null;

            sc.SortCol(nums);

            Assert.AreEqual(null, nums);
        }

       [TestMethod]
        public void TestZeroLen(){
            SortColors sc = new SortColors();
            int[] nums = new int[0];
            sc.SortCol(nums);

            Assert.AreEqual(0, nums.Length);
        }
    }
}
