namespace CarInfoApp.Models
{
    /// <summary>
    /// The vehicle information interface.
    /// </summary>
    public interface IVehicleInformation
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        /// <value>The make.</value>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the vehicle identifier.
        /// </summary>
        /// <value>The vehicle identifier.</value>
        public int VehicleId { get; set; }

        #endregion Public Properties
    }
}