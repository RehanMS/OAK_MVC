//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }
    
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> LastUpdateUserID { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
    
        public virtual T_User T_User { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
