using CarInfoApp.Constants;
using CarInfoApp.Contexts;
using CarInfoApp.Models;
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
            _context = new VehicleInfoContext() { SelectedVehicleOption = VehicleOptions.Honda };
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
            _context.SelectedVehicleOption = (VehicleOptions)3;

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
        public async Task GetVehicleInfo_VehicleOption_Honda_ReturnsData()
        {
            // Arrange
            _sut = new VehicleInfoService();
            _context.SelectedVehicleOption = VehicleOptions.Honda;

            // Act
            var result = await _sut.GetVehicleInfo(_context);

            // Assert
            result.Should().NotBeNull();
            result.Messages.Should().BeEmpty();
            result.Description.Should().NotBeNullOrEmpty();
            result.Description.Should().BeEquivalentTo(VehicleDescriptions.HondaDescription);
            result.MilesPerGallonCity.Should().Be(VehicleMpgData.HondaMpgData[MpgConstants.City]);
            result.MilesPerGallonHighway.Should().Be(VehicleMpgData.HondaMpgData[MpgConstants.Hwy]);
        }

        [TestMethod]
        public async Task GetVehicleInfo_VehicleOption_Nissan_ReturnsData()
        {
            // Arrange
            _sut = new VehicleInfoService();
            _context.SelectedVehicleOption = VehicleOptions.Nissan;

            // Act
            var result = await _sut.GetVehicleInfo(_context);

            // Assert
            result.Should().NotBeNull();
            result.Messages.Should().BeEmpty();
            result.Description.Should().NotBeNullOrEmpty();
            result.Description.Should().BeEquivalentTo(VehicleDescriptions.NissanDescription);
            result.MilesPerGallonCity.Should().Be(VehicleMpgData.NissanMpgData[MpgConstants.City]);
            result.MilesPerGallonHighway.Should().Be(VehicleMpgData.NissanMpgData[MpgConstants.Hwy]);
        }
    }
}