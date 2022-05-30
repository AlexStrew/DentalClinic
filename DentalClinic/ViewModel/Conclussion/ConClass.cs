using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.ViewModel.Conclussion
{
    public class ConClass
    {
        public static bool AddConMethodTest(int patId, string xR, string fa, string des, string curH, string descr, string comp, string stag, string mkbS, int cos, int conId)
        {
            //int nozzleS, int anest, int cro, int gelS, int vita, int basicT, 
            Core db = new Core();
            //consumables newCon = new consumables()
            //{
            //    nozzle = nozzleS,
            //    anesthesia = anest,
            //    crown = cro,
            //    gel = gelS,
            //    vitamins = vita,
            //    basic_tools = basicT,

            //};

            //db.context.consumables.Add(newCon);
            //db.context.SaveChanges();

            med_history newPatient = new med_history()
            {
                patient_id = patId,
                x_ray = xR,
                fase = fa,
                desease = des,
                current_health = curH,
                description = descr,
                complication = comp,
                stage = stag,
                mkb = mkbS,
                cost = cos,
                consumable_id = conId

            };




            db.context.med_history.Add(newPatient);
            db.context.SaveChanges();

            int countRecord = db.context.med_history
            .Where(x => x.fase == fa)
            .Count();
            if (countRecord == 1)
            {

                return false;
            }
            return true;
        }
    }
}
