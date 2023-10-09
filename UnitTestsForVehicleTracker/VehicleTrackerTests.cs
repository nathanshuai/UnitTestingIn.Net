using System.ComponentModel;
using UnitTestingIn.Net;

namespace UnitTestsForVehicleTracker
{

    [TestClass]
    public class VehicleTrackerTests
    {
        [TestMethod]
        public void VehicleTracker_Initialization_ShouldHaveEmptySlots()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");

            // Act & Assert
            for (int i = 1; i <= tracker.Capacity; i++)
            {
                Assert.AreEqual(null, tracker.VehicleList[i]);
            }
        }

        [TestMethod]
        public void AddVehicle_SlotsNotFull_ShouldAddVehicleToFirstOpenSlot()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");
            Vehicle vehicle = new Vehicle("ABC123", false);

            // Act
            tracker.AddVehicle(vehicle);
            int key = 1;
            Vehicle retrievedVehicle = tracker.VehicleList[key];

            // Assert
            Assert.AreEqual(vehicle,retrievedVehicle);
        }

        [TestMethod]
        public void AddVehicle_NoOpenSlots_ShouldThrowExceptionWhenAllSlotsFull()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(1, "TestAddress");
            Vehicle vehicle1 = new Vehicle("ABC123", false);
            Vehicle vehicle2 = new Vehicle("XYZ789", false);

            // Act
            tracker.AddVehicle(vehicle1);

            // Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() => tracker.AddVehicle(vehicle2));
        }

        [TestMethod]
        public void RemoveVehicle_ValidLicence_ShouldRemoveVehicleByLicence()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");
            Vehicle vehicle = new Vehicle("ABC123", false);
            tracker.AddVehicle(vehicle);

            // Act
            tracker.RemoveVehicle("ABC123");

            // Assert
            Assert.IsFalse(tracker.VehicleList.ContainsValue(vehicle));
        }

        [TestMethod]
        public void RemoveVehicle_ValidSlotNumber_ShouldRemoveVehicleBySlotNumber()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");
            Vehicle vehicle = new Vehicle("ABC123", false);
            tracker.AddVehicle(vehicle);

            // Act
            tracker.RemoveVehicle(1);

            // Assert
            Assert.IsFalse(tracker.VehicleList.ContainsValue(vehicle));
        }

        [TestMethod]
        public void RemoveVehicle_InvalidLicence_ShouldThrowExceptionWhenLicenceNotFound()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");

            // Act & Assert
            Assert.ThrowsException<NullReferenceException>(() => tracker.RemoveVehicle("ABC123"));
        }

        [TestMethod]
        public void RemoveVehicle_InvalidSlotNumber_ShouldThrowExceptionWhenInvalidSlotNumber()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");

            // Act & Assert
            Assert.ThrowsException<NullReferenceException>(() => tracker.RemoveVehicle(6));
            Assert.ThrowsException<NullReferenceException>(() => tracker.RemoveVehicle(-1));
        }

        [TestMethod]
        public void SlotsAvailable_AddingVehicles_ShouldBeUpdatedProperly()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");
            Vehicle vehicle1 = new Vehicle("ABC123", false);
            Vehicle vehicle2 = new Vehicle("XYZ789", false);

            // Act
            tracker.AddVehicle(vehicle1);
            tracker.AddVehicle(vehicle2);

            // Assert initial state
            Assert.AreEqual(3, tracker.SlotsAvailable); // Two slots are occupied, so there are 3 available
        }

        [TestMethod]
        public void SlotsAvailable_RemovingVehicles_ShouldBeUpdatedProperlyAfterAdding()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");
            Vehicle vehicle1 = new Vehicle("ABC123", false);
            Vehicle vehicle2 = new Vehicle("XYZ789", false);

            // Act
            tracker.AddVehicle(vehicle1);
            tracker.AddVehicle(vehicle2);
            tracker.RemoveVehicle(1);

            // Assert after removing a vehicle
            Assert.AreEqual(4, tracker.SlotsAvailable); // One slot is freed up, so there are 4 available
        }


        [TestMethod]
        public void ParkedPassholders_ValidPassHolder_ShouldReturnListWithPassholders()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");
            Vehicle passHolder = new Vehicle("ABC123", true);
            Vehicle passHolder1 = new Vehicle("ABC456", true);
            tracker.AddVehicle(passHolder);
            tracker.AddVehicle(passHolder1);

            // Act
            var passHolders = tracker.ParkedPassholders();

            // Assert
            Assert.AreEqual(2, passHolders.Count);

        }

        [TestMethod]
        public void PassholderPercentage_ValidPassHolder_ShouldReturnCorrectPercentage()
        {
            // Arrange
            VehicleTracker tracker = new VehicleTracker(5, "TestAddress");
            Vehicle passHolder1 = new Vehicle("ABC123", true);
            Vehicle passHolder2 = new Vehicle("ABC456", true);

            tracker.AddVehicle(passHolder1);
            tracker.AddVehicle(passHolder2);

            // Act
            int percentage = tracker.PassholderPercentage();

            // Assert
            Assert.AreEqual(40, percentage); // 2 passholders out of 5 slots, 40%
        }
    }

}

