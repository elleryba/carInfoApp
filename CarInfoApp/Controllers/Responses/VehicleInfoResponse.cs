using CarInfoApp.Models;
using System.Diagnostics.CodeAnalysis;

namespace CarInfoApp.Controllers.Responses
{
    /// <summary>
    /// The vehicle info response.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class VehicleInfoResponse
        : IVehicleInformation
    {
        #region Public Properties

        /// <inheritdoc/>
        public string Description { get; set; }

        /// <inheritdoc/>
        public int MilesPerGallonCity { get; set; }

        /// <inheritdoc/>
        public int MilesPerGallonHighway { get; set; }

        #endregion Public Properties
    }
}