using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.ViewModel.Teeth
{
    public class TeethClass
    {
        public static bool EditTeethMethodTest(int patId, string teethMapArray)
        {
            Core db = new Core();
            db.context.patients.Where(x => x.id_patient == patId).FirstOrDefault().teeth_map = teethMapArray;
            Console.WriteLine(teethMapArray);
            db.context.SaveChanges();

            int countRecord = db.context.patients
            .Where(x => x.id_patient == patId)
            .Count();
            if (countRecord == 1)
            {

                return true;
            }
            return false;
        }

       
    }
}
