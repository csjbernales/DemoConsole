using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Classes.Tests
{
    /// <summary>
    /// The animal tests.
    /// </summary>
    [TestClass()]
    public class AnimalTests
    {
        readonly Animal animal = new();
        /// <summary>
        /// Creates the sound test.
        /// </summary>
        [TestMethod()]
        public void CreateSoundTest()
        {
            animal.CreateSound();
        }

        /// <summary>
        /// Walks the test.
        /// </summary>
        [TestMethod()]
        public void WalksTest()
        {
            animal.Walks();
        }
    }
}