using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManage
{
    //class, object, inheritance, method, encaptulation
    class Person
    {
        public string Name;
        public int Age;

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Doctor : Person
    {
        public string Specialization;
        public void ShowDoctorInfo()
        {
            ShowInfo();
            Console.WriteLine("Specialiazation: " + Specialization);
        }
    }

    class Patient : Person
    {
        public int PatientID;
        public string Disases;

        public void ShowPatientInto()
        {
            Console.WriteLine("PatientID: " + PatientID);
            Console.WriteLine("Disases: " + Disases);
        }
    }

    class Hospital
    {
        public string HospitalName;

        public void ShowHospitalInfo()
        {
            Console.WriteLine("Hospital Name: " + HospitalName);
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital h = new Hospital();
            h.HospitalName = "AMZ Hospital";
            h.ShowHospitalInfo();

            Console.WriteLine();


            Doctor d = new Doctor();
            d.Name = "Dr. Abdullah";
            d.Age = 45;
            d.Specialization = "Cardiology";
            d.ShowDoctorInfo();

            Console.WriteLine();

            Patient p = new Patient();
            p.Name = "Mahfuj";
            p.Age = 30;
            p.PatientID = 12345;
            p.Disases = "Dengue";
            p.ShowPatientInto();
            Console.WriteLine();

        }
    }
}
