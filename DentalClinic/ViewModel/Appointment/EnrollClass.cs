using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.ViewModel.Appointment
{
    public class EnrollClass
    {
        public static bool AppointmentMethodTest(int patId, DateTime dateApp, string reasonApp, string descApp)
        {
            Core db = new Core();

            appointment newApp = new appointment()
            {
                patient_id = patId,
                date_app = dateApp,
                reason = reasonApp,
                description = descApp
            };

            db.context.appointment.Add(newApp);
            db.context.SaveChanges();

            int countRecord = db.context.appointment
            .Where(x => x.patient_id == patId && x.date_app == dateApp && x.reason == reasonApp && x.description == descApp)
            .Count();
            if (countRecord == 1)
            {

                return true;
            }
            return false;
        }
    }
}
