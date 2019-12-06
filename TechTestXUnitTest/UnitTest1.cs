using System;
using Xunit;
using TechTest;

namespace TechTestXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var consoleContext = new ConsoleContext();
            consoleContext.Test();
        }
    }
}
