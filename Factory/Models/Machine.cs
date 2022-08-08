using System.Collections.Generic;

namespace Factory.Models

{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<Assignment>();
    }
    public int MachineId { get; set; }
    public string Description { get; set; }
    
    public virtual ICollection<Assignment> JoinEntities { get;}
  }
}