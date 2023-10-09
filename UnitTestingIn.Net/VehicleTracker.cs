using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingIn.Net
{
    public class VehicleTracker
    {
        //PROPERTIES
        public string Address { get; set; }
        public int Capacity { get; set; }
        public int SlotsAvailable { get; set; }
        public Dictionary<int, Vehicle> VehicleList { get; set; }

        public VehicleTracker(int capacity, string address)
        {
            this.Capacity = capacity;
            this.SlotsAvailable = capacity;
            this.Address = address;
            this.VehicleList = new Dictionary<int , Vehicle>();

            this.GenerateSlots();
        }

        // STATIC PROPERTIES
        public static string BadSearchMessage = "Error: Search did not yield any result.";
        public static string BadSlotNumberMessage = "Error: No slot with number ";
        public static string SlotsFullMessage = "Error: no slots available.";

        // METHODS
        public void GenerateSlots()
        {
            for (int i = 1; i <= this.Capacity; i++)
            {
                this.VehicleList.Add(i, null);
            }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            foreach (KeyValuePair<int, Vehicle> slot in this.VehicleList)
            {
                if (slot.Value == null)
                {
                    this.VehicleList[slot.Key] = vehicle;
                    this.SlotsAvailable--;
                    return;
                }
            }
            throw new IndexOutOfRangeException(SlotsFullMessage);
        }

        public void RemoveVehicle(string licence)
        {

            try
            {
                int slot = this.VehicleList.First(v => v.Value.Licence == licence).Key;
                this.VehicleList.Remove(slot);
                this.SlotsAvailable++;

            }
            catch
            {
                throw new NullReferenceException(BadSearchMessage);
            }
        }

        public void RemoveVehicle(int slotNumber)
        {

            try
            {
                int slot = this.VehicleList.First(v => v.Key == slotNumber).Key;
                this.VehicleList.Remove(slot);
                this.SlotsAvailable++;
            }
            catch
            {
                throw new NullReferenceException(BadSearchMessage);
            }
        }

        public List<Vehicle> ParkedPassholders()
        {
            List<Vehicle> passHolders = new List<Vehicle>();

            foreach (var entry in this.VehicleList)
            {
                if (entry.Value != null && entry.Value.Pass)
                {
                    passHolders.Add(entry.Value);
                }
            }
            return passHolders;
        }

        public int PassholderPercentage()
        {
            int passHolders = ParkedPassholders().Count;
            int percentage = (passHolders * 100) / this.Capacity;

            return percentage;
        }

    }
}
