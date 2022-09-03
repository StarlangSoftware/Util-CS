using System;
using NUnit.Framework;
using Util;

namespace Test
{
    public class RandomArrayTest
    {

        [Test]
        public void NormalizedArrayTest() {
            var array = RandomArray.NormalizedArray(10);
            var sum = 0.0;
            foreach (var d in array){
                sum += d;
            }
            Assert.AreEqual(1.0, sum, 0.0);
        }

        [Test]
        public void IndexArrayTest() {
            var array = RandomArray.IndexArray(10, new Random());
            var sum = 0;
            foreach (var d in array){
                sum += d;
            }
            Assert.AreEqual(45, sum);
        }

    }
}