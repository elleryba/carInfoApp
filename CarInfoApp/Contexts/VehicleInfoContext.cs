using CarInfoApp.Models;
using System.Diagnostics.CodeAnalysis;

namespace CarInfoApp.Contexts
{
    /// <summary>
    /// The vehicle info context.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class VehicleInfoContext
        : IVehicleInformation
    {
        #region Public Properties

        /// <ineritdoc/>
        public string Description { get; set; }

        /// <ineritdoc/>
        public string Make { get; set; }

        /// <ineritdoc/>
        public string Model { get; set; }

        /// <ineritdoc/>
        public int VehicleId { get; set; }

        #endregion Public Properties
    }
}