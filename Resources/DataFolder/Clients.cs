//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Resources.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clients
    {
        public Clients()
        {
            this.Users = new HashSet<Users>();
        }
    
        public int IdClient { get; set; }
        public string NameClient { get; set; }
        public string LastnameClient { get; set; }
        public string PatronymicClient { get; set; }
        public int Phone { get; set; }
        public int IdCake { get; set; }
    
        public virtual Cakes Cakes { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
