using CarInfoApp.Constants;
using CarInfoApp.Contexts;
using CarInfoApp.Controllers.Responses;
using CarInfoApp.Models;
using System;
using System.Threading.Tasks;

namespace CarInfoApp.Services
{
    /// <summary>
    /// The vehicle info service.
    /// </summary>
    /// <seealso cref="IVehicleInfoService"/>
    public class VehicleInfoService
        : IVehicleInfoService
    {
        #region Public Methods

        /// <inheritdoc/>
        public Task<VehicleInfoResponse> GetVehicleInfo(VehicleInfoContext context)
        {
            if (context is null) throw new ArgumentException($"The provided context is null :: {nameof(GetVehicleInfo)}");

            if (!Enum.IsDefined(typeof(VehicleOptions), context.SelectedVehicleOption))
                throw new ArgumentException($"Selected vehicle option [{context.SelectedVehicleOption}] not found :: {nameof(GetVehicleInfo)}");

            if (context.SelectedVehicleOption.Equals(VehicleOptions.Honda))
                return Task.FromResult(new VehicleInfoResponse() { Description = VehicleDescriptions.HondaDescription, MilesPerGallonCity = VehicleMpgData.HondaMpgData["City"], MilesPerGallonHighway = VehicleMpgData.HondaMpgData["Highway"] });

            return Task.FromResult(new VehicleInfoResponse() { Description = VehicleDescriptions.NissanDescription, MilesPerGallonCity = VehicleMpgData.NissanMpgData["City"], MilesPerGallonHighway = VehicleMpgData.NissanMpgData["Highway"] });
        }

        #endregion Public Methods
    }
}