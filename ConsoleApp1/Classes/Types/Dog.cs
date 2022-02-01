namespace ConsoleApp1.Classes.Types
{
    /// <summary>
    /// The dog.
    /// </summary>
    public class Dog : Animal, IDog //inheritance and abstraction
    {
        /// <summary>
        /// Creates the sound. (Override)
        /// </summary>
        public override void CreateSound() => Console.WriteLine("Dog makes sound");

        /// <summary>
        /// Creates the sound. (Overload parameter)
        /// </summary>
        public void Sounds(string sound) => Console.WriteLine("Dog says {0}", sound);

        /// <summary>
        /// Creates the sound. (Overload parameter)
        /// </summary>
        public void Sounds(string sound1, string sound2) => Console.WriteLine("Dog says {0} {1}", sound1, sound2);
    }
}