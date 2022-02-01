namespace ConsoleApp1.Classes.Types
{
    /// <summary>
    /// The dog interface.
    /// </summary>
    public interface IDog //encapsulation
    {
        /// <summary>
        /// Creates the sound.
        /// </summary>
        void CreateSound();

        /// <summary>
        /// Sound
        /// </summary>
        /// <param name="sound">The sound.</param>
        void Sounds(string sound);

        /// <summary>
        /// Sound
        /// </summary>
        /// <param name="sound1">The sound1.</param>
        /// <param name="sound2">The sound2.</param>
        void Sounds(string sound1, string sound2);

        /// <summary>
        /// Walk
        /// </summary>
        void Walks();
    }
}