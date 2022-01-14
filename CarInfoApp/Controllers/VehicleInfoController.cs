using CarInfoApp.Contexts;
using CarInfoApp.Controllers.Responses;
using CarInfoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CarInfoApp.Controllers
{
    /// <summary>
    /// Controller used for vehicle info interactions.
    /// </summary>
    /// <seealso cref="Controller"/>
    [ApiController]
    [Route("vehicles")]
    public class VehicleInfoController
        : Controller
    {
        #region Private Fields

        private readonly IVehicleInfoService _service;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleInfoController"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public VehicleInfoController(IVehicleInfoService service) => _service = service;

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Gets the vehicle information.
        /// </summary>
        /// <param name="vehicleOptionId"></param>
        /// <returns></returns>
        [Route("{vehicleOptionId}/info")]
        [HttpGet]
        public async Task<ActionResult<VehicleInfoResponse>> GetVehicleInfo([FromRoute] int vehicleOptionId)
        {
            if (vehicleOptionId < 0 || !Enum.IsDefined(typeof(VehicleOptions), vehicleOptionId))
                return BadRequest($"There is not currently data available for vehicle [{vehicleOptionId}].");

            var context = new VehicleInfoContext() { SelectedVehicleOption = (VehicleOptions)vehicleOptionId };

            var result = await _service.GetVehicleInfo(context);

            return Ok(result);
        }

        #endregion Public Methods
    }
}