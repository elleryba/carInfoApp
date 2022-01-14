using CarInfoApp.Contexts;
using CarInfoApp.Controllers.Responses;
using System.Threading.Tasks;

namespace CarInfoApp.Models
{
    /// <summary>
    /// The vehicle info service interface.
    /// </summary>
    public interface IVehicleInfoService
    {
        #region Public Methods

        /// <summary>
        /// Gets the vehicle information.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public Task<VehicleInfoResponse> GetVehicleInfo(VehicleInfoContext context);

        #endregion Public Methods
    }
}