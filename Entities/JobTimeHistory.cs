using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities
{
    public class JobTimeHistory
    {
        [Key]
        public int JobTimeHistoryId { get; set; }
        
        
        public DateTime StartJobTime{ get; set; }
        public DateTime TimeOfBeingLate{ get; set; }
      
        public int EmployeeId { get; set; } 
        
        public Employee Employee;

        
}
}