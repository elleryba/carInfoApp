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
            VehicleInfoResponse response = new();

            if (context is null)
            {
                response.Messages.Add($"The provided context is null :: {nameof(GetVehicleInfo)}");
                return Task.FromResult(response);
            }

            if (!Enum.IsDefined(typeof(VehicleOptions), context.SelectedVehicleOption))
            {
                response.Messages.Add($"Selected vehicle option [{context.SelectedVehicleOption}] not found :: {nameof(GetVehicleInfo)}");
                return Task.FromResult(response);
            }

            if (context.SelectedVehicleOption.Equals(VehicleOptions.Honda))
            {
                response.Description = VehicleDescriptions.HondaDescription;
                response.MilesPerGallonCity = VehicleMpgData.HondaMpgData[MpgConstants.City];
                response.MilesPerGallonHighway = VehicleMpgData.HondaMpgData[MpgConstants.Hwy];

                return Task.FromResult(response);
            }

            response.Description = VehicleDescriptions.NissanDescription;
            response.MilesPerGallonCity = VehicleMpgData.NissanMpgData[MpgConstants.City];
            response.MilesPerGallonHighway = VehicleMpgData.NissanMpgData[MpgConstants.Hwy];

            return Task.FromResult(response);
        }

        #endregion Public Methods
    }
}