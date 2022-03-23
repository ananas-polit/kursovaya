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
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.ReceiptsBook = new HashSet<ReceiptsBook>();
            this.Sales = new HashSet<Sales>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Nullable<int> Year_public { get; set; }
        public Nullable<int> Publishing_houseID { get; set; }
        public Nullable<int> GenreID { get; set; }
        public string SectionID { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Genre Genre { get; set; }
        public virtual Publishinghouse Publishinghouse { get; set; }
        public virtual Section Section { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptsBook> ReceiptsBook { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}