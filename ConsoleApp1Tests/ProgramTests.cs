using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program.Tests
{
    /// <summary>
    /// The program tests.
    /// </summary>
    [TestClass()]
    public class ProgramTests
    {
        /// <summary>
        /// Mains the test.
        /// </summary>
        [TestMethod()]
        public void MainTest()
        {
            Program.Start start = new();
            start.Init();
        }
    }
}