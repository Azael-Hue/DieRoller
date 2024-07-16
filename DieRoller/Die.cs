namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1 - 6).
    /// </summary>
    public class Die
    {
        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; set; }

        /// <summary>
        /// True if the die is currnetly held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue" />
        /// to the new number, Returns the new face value.
        /// </summary>
        /// <return>Returns the new random number</return>
        public byte Roll()
        {
            // Generate a random number
            Random random = new Random();
            byte newValue = (byte)random.Next(1, 7);

            FaceValue = newValue;

            return FaceValue;
        }
    }
}
