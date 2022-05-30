using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.ViewModel.DelBooked
{
    public class DelEnrollClass
    {
        
        public static bool DelAppMethodTest(int patId)
        {
            Core db = new Core();
            var item = db.context.appointment.Where(x => x.id_appointment == patId).First() as appointment;
            db.context.appointment.Remove(item);
            db.context.SaveChanges();

            int countRecord = db.context.appointment
            .Where(x => x.id_appointment == patId)
            .Count();
            if (countRecord == 1)
            {

                return false;
            }
            return true;
        }
    }
}

