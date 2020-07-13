using NUnit.Framework;
using Util;

namespace Test
{
    public class SubsetFromListTest
    {
        [Test]
        public void Next1() {
            var subSet = new SubsetFromList(new int[]{10, 20, 30, 40, 50, 60, 70, 80, 90, 100}, 5);
            var firstSubSet = subSet.Get();
            Assert.AreEqual(new int[]{10, 20, 30, 40, 50}, firstSubSet);
            var count = 1;
            while (subSet.Next()){
                count++;
            }
            Assert.AreEqual(252, count);
        }

        [Test]
        public void Next2() {
            var subSet = new SubsetFromList(new int[]{9, 8, 2, 12, 7, 16, 17}, 3);
            var firstSubSet = subSet.Get();
            Assert.AreEqual(new int[]{9, 8, 2}, firstSubSet);
            var count = 1;
            while (subSet.Next()){
                count++;
            }
            Assert.AreEqual(35, count);
        }

        [Test]
        public void Next3() {
            var count = 0;
            for (var i = 0; i <= 9; i++){
                var subSet = new SubsetFromList(new int[]{9, 8, 2, 12, 7, 16, 17, 8, 3}, i);
                count++;
                while (subSet.Next()){
                    count++;
                }
            }
            Assert.AreEqual(512, count);
        }

    }
}