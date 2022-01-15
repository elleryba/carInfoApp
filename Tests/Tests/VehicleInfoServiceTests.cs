using CarInfoApp.Contexts;
using CarInfoApp.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace CarInfoApp.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class VehicleInfoServiceTests
    {
        private VehicleInfoService _sut;
        private VehicleInfoContext _context;

        [TestInitialize]
        public void Setup()
        {
            _context = new VehicleInfoContext() { VehicleId = 1 };
        }

        [TestMethod]
        public async Task GetVehicleInfo_NullContext_ReturnsMessage()
        {
            // Arrange
            _sut = new VehicleInfoService();
            _context = null;

            // Act
            var result = await _sut.GetVehicleInfo(_context);

            // Assert
            result.Should().NotBeNull();
            result.Messages.Should().NotBeNullOrEmpty();
            result.Description.Should().BeNull();
            result.MilesPerGallonCity.Should().Be(0);
            result.MilesPerGallonHighway.Should().Be(0);
        }

        [TestMethod]
        public async Task GetVehicleInfo_VehicleOption_NotDefined_ReturnsMessage()
        {
            // Arrange
            _sut = new VehicleInfoService();
            _context.VehicleId = -1;

            // Act
            var result = await _sut.GetVehicleInfo(_context);

            // Assert
            result.Should().NotBeNull();
            result.Messages.Should().NotBeNullOrEmpty();
            result.Description.Should().BeNull();
            result.Make.Should().BeNull();
            result.Model.Should().BeNull();
        }
    }
}