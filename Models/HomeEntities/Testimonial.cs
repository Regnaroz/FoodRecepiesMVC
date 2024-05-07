using AspnetCoreMvcFull.Models.Base;
using RecepieBlog.Models.UserEntities;

namespace RecepieBlog.Models.HomeEntities
{
  public class Testimonial :BaseEntity
  {
    public string Message { get; set; }
    public bool ShowInHomePage { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
  }
}
