using CarInfoApp.Contexts;
using CarInfoApp.Controllers.Responses;
using CarInfoApp.Data.Contexts;
using CarInfoApp.Data.Models;
using CarInfoApp.Models;
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

            if (context.VehicleId < 0)
            {
                response.Messages.Add($"Vehicle identifier [{context.VehicleId}] is not valid :: {nameof(GetVehicleInfo)}");
                return Task.FromResult(response);
            }

            using (VehicleDataContext dbContext = new())
            {
                var query = from v in dbContext.Vehicles
                            where v.VehicleId == context.VehicleId
                            select v;

                var vehicle = query.FirstOrDefault<Vehicle>();

                context.Description = vehicle.Description;
                context.Make = vehicle.Make;
                context.Model = vehicle.Model;
            }

            response.Description = context.Description;
            response.Make = context.Make;
            response.Model = context.Model;

            return Task.FromResult(response);
        }

        #endregion Public Methods
    }
}