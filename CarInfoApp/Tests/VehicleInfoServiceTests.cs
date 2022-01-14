using CarInfoApp.Contexts;
using CarInfoApp.Models;
using CarInfoApp.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
        public void GetVehicleInfo_NullContext_Throws()
        {
            // Arrange
            _sut = new VehicleInfoService();
            _context = null;

            // Act
            Action action = () => _sut.GetVehicleInfo(_context);

            // Assert
            action.Should().Throw<ArgumentException>();
        }
    }
}
