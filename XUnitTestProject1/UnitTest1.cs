using ConsoleApp1;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CallDemo_ArgumentMoreThan10()
        {
            var testValue = 11;
            var demoClass = new DemoClass();
            var result = demoClass.CalDemo(testValue);

            Assert.Equal(44, result);
        }
        [Fact]
        public void CallDemo_ArgumentLessThan10()
        {
            var testValue = 9;
            var demoClass = new DemoClass();
            var result = demoClass.CalDemo(testValue);

            Assert.Equal(9, result);
        }
    }
}
