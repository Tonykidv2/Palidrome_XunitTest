using System;
using PalidromeApp.Src;
using Xunit;

namespace PalidromeApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Palidrome wordcheck = new Palidrome();
            string word = "Racecar";
            Assert.True(wordcheck.isPalidrome(word));
            word = "shouldReturnFalse";
            Assert.False(wordcheck.isPalidrome(word));
        }

        [Fact]
        public void Test2()
        {
            Palidrome wordcheck = new Palidrome();
            string word = "never odd or even";

            Assert.True(wordcheck.isPhrasePalidrome(word));
        }
    }
}