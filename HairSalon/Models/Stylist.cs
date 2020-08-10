using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public int ClientId { get; set; }
    public string Name { get; set; }
    public virtual Client Client { get; set; }
  }
}