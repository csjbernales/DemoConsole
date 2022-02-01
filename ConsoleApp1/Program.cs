using ConsoleApp1.Classes.Types;
using ConsoleApp1.Factories;

namespace Program
{
    /// <summary>
    /// The program.
    /// </summary>
#pragma warning disable RCS1102 // Make class static.
    public class Program
#pragma warning restore RCS1102 // Make class static.
    {
        /// <summary>
        /// Program main entry point
        /// </summary>
        public static void Main() => new Start().Init();

        /// <summary>
        /// The initial class to load.
        /// </summary>
        public class Start
        {
            private readonly IDog Dog = ProgramFactory.Dog();

            /// <summary>
            /// Prints hello world
            /// </summary>
            public void Init()
            {
                //abstraction: abstracted functions below
                Dog.Walks();
                Dog.CreateSound();

                Dog.Sounds("Woof"); //overloading 1 parameter
                Dog.Sounds("Woof", "Bark"); //overloading 2 parameter
            }
        }
    }
}