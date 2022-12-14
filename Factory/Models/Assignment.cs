namespace Factory.Models
{
  public class Assignment
    {       
        public int AssignmentId { get; set; }
        public int MachineId { get; set; }
        public int EngineerId { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual Engineer Engineer { get; set; }
    }
}