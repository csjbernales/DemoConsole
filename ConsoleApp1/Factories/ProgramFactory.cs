using ConsoleApp1.Classes.Types;

namespace ConsoleApp1.Factories
{
    /// <summary>
    /// The Program factory interface.
    /// </summary>
    public static class ProgramFactory //abstraction: the only exposed class;
    {
        /// <summary>
        /// dogs the <see cref="IDog"/>.
        /// </summary>
        /// <returns>An IDog.</returns>
        public static IDog Dog() => new Dog();
    }
}