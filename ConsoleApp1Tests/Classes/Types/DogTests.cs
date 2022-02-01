using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Classes.Types.Tests
{
    /// <summary>
    /// The dog tests.
    /// </summary>
    [TestClass()]
    public class DogTests
    {
        readonly Dog dog = new();

        /// <summary>
        /// Creates the sound test.
        /// </summary>
        [TestMethod()]
        public void CreateSoundTest()
        {
            dog.CreateSound();
        }

        /// <summary>
        /// Sounds the test.
        /// </summary>
        [TestMethod()]
        public void SoundsTest()
        {
            dog.Sounds("Test");
        }

        /// <summary>
        /// Sounds the test1.
        /// </summary>
        [TestMethod()]
        public void SoundsTest1()
        {
            dog.Sounds("Test1", "Test2");
        }
    }
}