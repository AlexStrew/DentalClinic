using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.ViewModel.EditPat
{
    public class EditPatClass
    {
        public static bool EditPatientMethodTest(int patId, string firstName, string lastName, DateTime dateBirth)
        {
            Core db = new Core();

            db.context.patients.Where(x => x.id_patient == patId).First().patient_first_name = firstName;
            db.context.patients.Where(x => x.id_patient == patId).First().patient_last_name = lastName;
            db.context.patients.Where(x => x.id_patient == patId).First().date_of_birth = dateBirth;
            db.context.SaveChanges();

            int countRecord = db.context.patients
            .Where(x => x.id_patient == patId && x.patient_first_name == firstName && x.patient_last_name == lastName && x.date_of_birth == dateBirth)
            .Count();
            if (countRecord == 1)
            {

                return true;
            }
            return false;
        }
    }
}
