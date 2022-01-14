using System.Diagnostics.CodeAnalysis;

namespace CarInfoApp.Constants
{
    /// <summary>
    /// The vehicle mile per gallon data.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class VehicleMpgData
    {
        #region Public Fields

        /// <summary>
        /// The Honda miles per gallon data. Item1 = MPG City Item2 = MPG Highway
        /// </summary>
        public static (int, int) HondaMpgData = (30, 38);

        /// <summary>
        /// The Nissan miles per gallon data. Item1 = MPG City Item2 = MPG Highway
        /// </summary>
        public static (int, int) NissanMpgData = (28, 39);

        #endregion Public Fields
    }
}