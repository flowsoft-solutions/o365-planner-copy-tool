using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using O365PlannerCopyTool.Common;

namespace O365PlannerCopyTool.Test
{
    [TestClass]
    public class GraphHelperTest
    {
        [TestMethod]
        public void TestSayHello()
        {
            Assert.IsTrue((new GraphHelper()).SayHello() == "Hello World");
        }
    }
}
