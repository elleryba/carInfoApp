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
        /// Gets or sets the miles per gallon city.
        /// </summary>
        /// <value>The miles per gallon city.</value>
        public int MilesPerGallonCity { get; set; }

        /// <summary>
        /// Gets or sets the miles per gallon highway.
        /// </summary>
        /// <value>The miles per gallon highway.</value>
        public int MilesPerGallonHighway { get; set; }

        #endregion Public Properties
    }
}