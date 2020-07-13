using NUnit.Framework;
using Util;

namespace Test
{
    public class SubsetTest
    {
        [Test]
        public void Next1() {
            var subSet = new Subset(1, 10, 5);
            var firstSubSet = subSet.Get();
            Assert.AreEqual(new int[]{1, 2, 3, 4, 5}, firstSubSet);
            var count = 1;
            while (subSet.Next()){
                count++;
            }
            Assert.AreEqual(252, count);
        }

        [Test]
        public void Next2() {
            var subSet = new Subset(1, 20, 3);
            var firstSubSet = subSet.Get();
            Assert.AreEqual(new int[]{1, 2, 3}, firstSubSet);
            var count = 1;
            while (subSet.Next()){
                count++;
            }
            Assert.AreEqual(1140, count);
        }

        [Test]
        public void Next3() {
            var count = 0;
            for (var i = 0; i <= 10; i++){
                var subSet = new Subset(1, 10, i);
                count++;
                while (subSet.Next()){
                    count++;
                }
            }
            Assert.AreEqual(1024, count);
        }
        
    }
}