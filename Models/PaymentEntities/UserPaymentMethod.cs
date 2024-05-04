using AspnetCoreMvcFull.Models.Base;
using RecepieBlog.Models.UserEntities;

namespace RecepieBlog.Models.PaymentEntities
{
  public class UserPaymentMethod :BaseEntity
  {
    public string CardNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CVV { get; set; }
    public string ExpiryDate { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
  }
}
