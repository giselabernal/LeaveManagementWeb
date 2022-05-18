using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Models
{
    public class LeaveAllocation : BaseEntity
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; } 
        public string EmployeeId { get; set; } //Aqui tengo duda porque la tabla de employee no tiene Id
       // public DateTime DateCreated { get; set; }
       // public DateTime DateModified { get; set; } ya estan en baseentity
    }
}
