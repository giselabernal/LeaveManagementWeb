namespace LeaveManagementWeb.Models
{ 
    //This class is for using several fields on tables which have the same field names on many tables
    //and it will be used to inherit on other classes
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
