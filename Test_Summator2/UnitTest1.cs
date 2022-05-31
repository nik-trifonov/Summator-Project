using NUnit.Framework;
using Summator_Proeject;

namespace Test_Summator2
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPositiveNums()
        {
            int result = Summator.Sum(new int[] { 5, 7 });
            Assert.That(result == 12);
        }

        [Test]
        public void Test_OneNum()
        {
            int result = Summator.Sum(new int[] { 5 });
            Assert.That(result == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNums()
        {
            int result = Summator.Sum(new int[] { -5, -7 });
            Assert.That(result == -12);
        }

       

        [Test]
        public void Test_Sum_BigValues()
        {
            int result = Summator.Sum(new int[] {20000,20000,20000 });
            Assert.That(result == 60000);
        }

        [Test]
        public void Test_Sum_BigValues1()
        {
            int result = Summator.Sum(new int[] { 20000, 20000, 20000 });
            Assert.That(result == 60000);
        }


    }
}
