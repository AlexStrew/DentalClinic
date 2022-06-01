using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.ViewModel.ProfilePage
{
    public class AllergyClass
    {
        public static bool AddAllergyMethodTest(int patId, string allNew)
        {
            Core db = new Core();

            db.context.patients.Where(x => x.id_patient == patId).FirstOrDefault().allergy = allNew;
            db.context.SaveChanges();

            int countRecord = db.context.patients
            .Where(x => x.id_patient == patId && x.allergy == allNew)
            .Count();
            if (countRecord == 1)
            {
                return true;
            }
            return false;
        }
    }
}
