using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogicLayer
{
    public class Technician : DbEntity
    {
        string techID;
        string techName;
        string techLName;
        double hourlyRate;
        int age;
        string phoneNume;

        public Technician(string techID, string techName, string techLName, double hourlyRate, int age, string phoneNume)
        {
            this.techID = techID;
            this.techName = techName;
            this.techLName = techLName;
            this.hourlyRate = hourlyRate;
            this.age = age;
            this.phoneNume = phoneNume;
        }

        public string TechID { get => techID; set => techID = value; }
        public string TechName { get => techName; set => techName = value; }
        public string TechLName { get => techLName; set => techLName = value; }
        public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        public int Age { get => age; set => age = value; }
        public string PhoneNume { get => phoneNume; set => phoneNume = value; }
    }
}
