using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace u20676736_HW04.Models
{
    public abstract class Patient
    {

        public int _IdNumber;
        public string _FirstName;
        public string _LastName;
        public string _PatientGender;
        public int _Age;
        public int _Phone;
        public DateTime _Date;
        public string _Address;      
        public string _HasCovid;

        public Patient(int ID, string firstName, string lastName, string patientGender, int age, int phone, DateTime date, string address, string hasCovid)
        {
            _IdNumber = ID;
            _FirstName = firstName;
            _LastName = lastName;
            _PatientGender = patientGender;
            _Age = age;
            _Phone = phone;
            _Date = date;
            _Address = address;            
            _HasCovid = hasCovid;
        }

        public abstract string PregnantPatients();
        
        public abstract string MonthsPregnant();
        public abstract string HIVPatient();
        public abstract string BloodPressure();
        public abstract string Weight();
        public abstract string NextDosage();      

        public abstract string Disease();

        public abstract string Medication();
        public int ID { get { return _IdNumber; } set { _IdNumber = value; } }

    public string FirstName { get { return _FirstName; } set { _FirstName = value; } }

    public string LastName { get { return _LastName; } set { _LastName = value; } }

    public string PateintGender { get { return _PatientGender; } set { _PatientGender = value; } }

    public int Age { get { return _Age; } set { _Age = value; } }

    public int Phone { get { return _Phone; } set { _Phone = value; } }

    public string Address { get { return _Address; } set { _Address = value; } }


    public string HasCovid { get { return _HasCovid; } set { _HasCovid = value; } }
    }


}