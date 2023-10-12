﻿using Parkomatic.Data;

namespace Parkomatic.Models
{
    public class ParkingHelper
    {
        private ParkomaticContext parkingContext;

        public ParkingHelper(ParkomaticContext context)

        {

            this.parkingContext = context;

        }

        public Pass CreatePass(string purchaser, bool premium, int capacity)

        {

            Pass newPass = new Pass();

            newPass.Purchaser = purchaser;

            newPass.Premium = premium;

            newPass.Capacity = capacity;

            parkingContext.Passes.Add(newPass);

            parkingContext.SaveChanges();

            return newPass;

        }

        public ParkingSpot CreateParkingSpot()

        {

            ParkingSpot newSpot = new ParkingSpot();

            newSpot.Occupied = false;

            parkingContext.ParkingSpots.Add(newSpot);

            return newSpot;

        }
    }
}
