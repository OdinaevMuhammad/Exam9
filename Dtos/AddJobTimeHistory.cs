namespace Domain.Dtos;

    public class AddJobTimeHistory
    {
        
         public int EmployeeId { get; set; }

        public DateTime StartJobTime{ get; set; }
        public DateTime TimeOfBeingLate{ get; set; }
 
    }
     public class GetJobTimeHistory
    {
        public int JobTimeHistoryId { get; set; }
        
        
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public DateTime StartJobTime{ get; set; }
        public DateTime TimeOfBeingLate{ get; set; }
        
     
      
    }

 public class Get
    {
   
        public string TimeOfBeingLate{ get; set; }
        
     
      
    }
