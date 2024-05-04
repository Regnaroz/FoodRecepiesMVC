using AspnetCoreMvcFull.Models.Base;
using AspnetCoreMvcFull.Models.UserEntities;
using RecepieBlog.Models.HomeEntities;
using RecepieBlog.Models.PaymentEntities;

namespace RecepieBlog.Models.UserEntities
{
  public class User : BaseEntity
  {
    public int BaseUserId { get; set; }
    public virtual BaseUser BaseUser { get; set; }
    public virtual ICollection<UserRecepie> UserRecepies {  get; set; }
    public virtual ICollection<Testimonial> UserTestimonials {  get; set; }
    public virtual UserPaymentMethod? UserPaymentMethod { get; set; }
  }
}
