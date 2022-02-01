using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Factories.Tests
{
    /// <summary>
    /// The program factory tests.
    /// </summary>
    [TestClass()]
    public class ProgramFactoryTests
    {
        /// <summary>
        /// Dogs the test.
        /// </summary>
        [TestMethod()]
        public void DogTest()
        {
            _ = ProgramFactory.Dog();
        }
    }
}