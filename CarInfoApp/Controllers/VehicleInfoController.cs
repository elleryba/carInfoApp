using CarInfoApp.Contexts;
using CarInfoApp.Controllers.Responses;
using CarInfoApp.Models;
using Microsoft.AspNetCore.Mvc;
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
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        [Route("{vehicleId}/info")]
        [HttpGet]
        public async Task<ActionResult<VehicleInfoResponse>> GetVehicleInfo([FromRoute] int vehicleId)
        {
            if (vehicleId < 0)
                return BadRequest($"Provided vehicle identifier [{vehicleId}] is not valid.");

            VehicleInfoContext context = new() { VehicleId = vehicleId };

            var result = await _service.GetVehicleInfo(context);

            return Ok(result);
        }

        #endregion Public Methods
    }
}