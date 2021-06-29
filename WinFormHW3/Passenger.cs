using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormHW3
{
    class Passenger
    {
        public Passenger(string fullName, int numOfLuggage, double weightOfLuggage, DateTime dateOfFlight, string timeOfFlight, double hoursOfFlight, string place)
        {
            FullName = fullName;
            NumOfLuggage = numOfLuggage;
            WeightOfLuggage = weightOfLuggage;
            DateOfFlight = dateOfFlight;
            TimeOfFlight = timeOfFlight;
            HoursOfFlight = hoursOfFlight;
            Place = place;
        }

        public string FullName { get; set; }
        public int NumOfLuggage { get; set; }
        public double WeightOfLuggage { get; set; }
        public DateTime DateOfFlight { get; set; }
        public string TimeOfFlight { get; set; }
        public double HoursOfFlight { get; set; }
        public string Place { get; set; }

        public override string ToString()
        {
            return $"{FullName}|{NumOfLuggage} luggages|{WeightOfLuggage} kg|{DateOfFlight}|{TimeOfFlight}|{HoursOfFlight} hours|{Place}";
        }

    }
}
