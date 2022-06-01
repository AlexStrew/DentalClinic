using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.ViewModel.AddPat
{
    public class AddPatientClass
    {
        public static bool AddPatientMethodTest(string firstName, string lastName, DateTime dateBirth)
        {
            Core db = new Core();

            patients newPatient = new patients()
            {
                patient_first_name = firstName,
                patient_last_name = lastName,
                date_of_birth = dateBirth
            };

            db.context.patients.Add(newPatient);
            db.context.SaveChanges();

            int countRecord = db.context.patients
            .Where(x => x.patient_first_name == firstName && x.patient_last_name == lastName && x.date_of_birth == dateBirth)
            .Count();
            if (countRecord == 1)
            {

                return true;
            }
            return false;
        }


        public static bool DelPatientMethodTest(string patName)
        {
            Core db = new Core();
            var item = db.context.patients.Where(x => x.patient_first_name == patName).First() as patients;
            db.context.patients.Remove(item);
            db.context.SaveChanges();

            int countRecord = db.context.patients
            .Where(x => x.patient_first_name == patName)
            .Count();
            if (countRecord == 1)
            {

                return false;
            }
            return true;

        }
    }
}
