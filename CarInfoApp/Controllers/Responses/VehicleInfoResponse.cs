using CarInfoApp.Models;
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

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        /// <value>The messages.</value>
        public ICollection<string> Messages = new List<string>();

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