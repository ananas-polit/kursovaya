//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kursovaya
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceiptsBook
    {
        public int ID { get; set; }
        public Nullable<int> BookID { get; set; }
        public Nullable<int> SuppliersID { get; set; }
        public string Quantity { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}
