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
        /// The Honda miles per gallon data.
        /// </summary>
        public static readonly Dictionary<string, int> HondaMpgData = new() { { MpgConstants.City, 30 }, { MpgConstants.Hwy, 38 } };

        /// <summary>
        /// The Nissan miles per gallon data.
        /// </summary>
        public static readonly Dictionary<string, int> NissanMpgData = new() { { MpgConstants.City, 28 }, { MpgConstants.Hwy, 39 } };

        #endregion Public Fields
    }
}