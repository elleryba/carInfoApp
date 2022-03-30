using CarInfoApp.Models;
using System.Collections;
using System.Collections.Generic;
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

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        /// <value>
        /// The messages.
        /// </value>
        public ICollection<string> Messages = new List<string>();

        #endregion Public Properties
    }
}