using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20676736_HW04.Models
{
    public class PregnantPatient : Patient
    {
        //Data Member 
        public string _DetailofPregnant;
        public int _MonthsPregnant;
        public double _BloodPressure;
        public double _Weight;

        public string Model { get; private set; }


        //Default Constructor 

        public PregnantPatient(int ID, string firstName, string lastName, string patientGender, int age, int phone, DateTime date, string address, string DetailofPregnant, int MonthsPregnant, double BloodPressure, double Weight): base (ID, firstName, lastName, patientGender, age, phone, date, address)
        {
            _DetailofPregnant = DetailofPregnant;
            _MonthsPregnant = MonthsPregnant;
            _BloodPressure = BloodPressure;
            _Weight = Weight;

        }

        //Methods

        public override string PregnantPatients()
        {
            return "This Patient is" + this.Model + ". \n " +
                   "is " + this._DetailofPregnant + " ." + "This";
        }

        public override string MonthsPregnant()
        {
            return "This Patient is " + this.Model + ". \n " +
                    this._MonthsPregnant + " Months Pregnant";
        }
        public override string BloodPressure()
        {
            return "This Patient" + this.Model + ". \n " + " Blood Presure is"+
                    this._BloodPressure;
        }

        public override string Weight()
        {
            return "This Patient" + this.Model + ". \n " + " Weighs" +
                    this._Weight+"Kg";
        }

        public override string NextDosage()
        {

            return "Next Dosgae is  " + Convert.ToString(calculateNextDosage()) + " days.";
        }

        private int calculateNextDosage()
        {
            var days = 28;
            return days;
        }

        //Properties
        public string DetailofPregnant { get { return _DetailofPregnant; } set { _DetailofPregnant = value; } }

        public int monthPregnant { get { return _MonthsPregnant; } set { _MonthsPregnant = value; } }

        public double bloodPressure { get { return _BloodPressure; } set { _BloodPressure = value; } }

        public double weight { get { return _Weight; } set { _Weight = value; } }


    }
}