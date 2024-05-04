using AspnetCoreMvcFull.Models.Base;
using AspnetCoreMvcFull.Models.UserEntities;

namespace RecepieBlog.Models.HomeEntities
{
  public class HomePageDetail : BaseEntity
  {
    public string PageTitle { get; set; }
    public string AboutUs { get; set; }
    public string ContactUs { get; set; }
    public virtual ICollection<Testimonial> Testimonial { get;set;}
    public int UserId { get; set; }
    public virtual BaseUser User { get; set; }
  }
}
