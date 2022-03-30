using CarInfoApp.Models;
using System.Diagnostics.CodeAnalysis;

namespace CarInfoApp.Contexts
{
    /// <summary>
    /// The vehicle info context.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class VehicleInfoContext
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the selected vehicle option.
        /// </summary>
        /// <value>The selected vehicle option.</value>
        public VehicleOptions SelectedVehicleOption { get; set; }

        #endregion Public Properties
    }
}