using System;
using NUnit.Framework;
using Util;

namespace Test
{
    public class RandomNormalizedArrayTest
    {

        [Test]
        public void Get() {
            var randomNormalizedArray = new RandomNormalizedArray(10);
            var array = randomNormalizedArray.Get();
            var sum = 0.0;
            foreach (var d in array){
                sum += d;
            }
            Assert.AreEqual(1.0, sum, 0.0);
        }

    }
}