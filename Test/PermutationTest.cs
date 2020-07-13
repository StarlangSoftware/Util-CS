using NUnit.Framework;
using Util;

namespace Test
{
    public class PermutationTest
    {

        [Test]
        public void Next1()
        {
            var permutation = new Permutation(3);
            var firstPermutation = permutation.Get();
            Assert.AreEqual(new int[]{0, 1, 2}, firstPermutation);
            var count = 1;
            while (permutation.Next()){
                count++;
            }
            Assert.AreEqual(6, count);
        }
        
        [Test]
        public void Next2() {
            var permutation = new Permutation(5);
            var firstPermutation = permutation.Get();
            Assert.AreEqual(new int[]{0, 1, 2, 3, 4}, firstPermutation);
            var count = 1;
            while (permutation.Next()){
                count++;
            }
            Assert.AreEqual(120, count);
        }
        
    }
}