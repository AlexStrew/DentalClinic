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
    
    public partial class appointment
    {
        public int id_appointment { get; set; }
        public int patient_id { get; set; }
        public Nullable<System.DateTime> date_app { get; set; }
        public string reason { get; set; }
        public string description { get; set; }
    
        public virtual patients patients { get; set; }
    }
}
