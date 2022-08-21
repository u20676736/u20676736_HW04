using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20676736_HW04.Models
{
    public class HIVPatient : Patient
    {
        public string _underlyingDisease;
        public string _TypeofMedication;


        public HIVPatient(int ID, string firstName, string lastName, bool patientGender, int age, int phone, DateTime date, string address, string underlyingDisease, string TypeofMedication) : base(ID, firstName, lastName, patientGender, age, phone, date, address)
        {
            _underlyingDisease = underlyingDisease;
            _TypeofMedication = TypeofMedication;

        }

        public string Model { get; private set; }

        public override string Disease()
        {
            return "This Patient is" + this.Model + ". \n " +
                   "is " + this._underlyingDisease + " ." + "This";
        }

        public override string Medication()
        {
            return "This Patient is" + this.Model + ". \n " +
                   "is " + this._TypeofMedication + " ." + "This";
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
        public string underlyingDisease { get { return _underlyingDisease; } set { _underlyingDisease = value; } }

        public string TypeofMedication { get { return _TypeofMedication; } set { _TypeofMedication = value; } }
    }
    
}