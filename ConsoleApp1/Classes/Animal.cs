namespace ConsoleApp1.Classes
{
    /// <summary>
    /// Base class
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Creates the sound.
        /// </summary>
        public virtual void CreateSound() => Console.WriteLine("Animal sound");

        /// <summary>
        /// The animal walks
        /// </summary>
#pragma warning disable CA1822 // Mark members as static

        public void Walks() => Console.WriteLine("The animal walks");

#pragma warning restore CA1822 // Mark members as static
    }
}