using System.Collections.Generic;
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
        public static Dictionary<string, int> HondaMpgData = new Dictionary<string, int>() { { "City", 30 }, { "Highway", 38 } };

        /// <summary>
        /// The Nissan miles per gallon data. Item1 = MPG City Item2 = MPG Highway
        /// </summary>
        public static Dictionary<string, int> NissanMpgData = new Dictionary<string, int>() { { "City", 28 }, { "Highway", 39 } };

        #endregion Public Fields
    }
}