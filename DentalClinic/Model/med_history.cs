//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DentalClinic.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class med_history
    {
        public int id_history { get; set; }
        public int patient_id { get; set; }
        public string x_ray { get; set; }
        public string fase { get; set; }
        public string desease { get; set; }
        public string current_health { get; set; }
        public string description { get; set; }
        public Nullable<int> cost { get; set; }
        public string complication { get; set; }
        public string stage { get; set; }
        public string mkb { get; set; }
    
        public virtual patients patients { get; set; }
    }
}