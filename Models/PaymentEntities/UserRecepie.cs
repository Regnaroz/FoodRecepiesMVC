using AspnetCoreMvcFull.Models.Base;
using AspnetCoreMvcFull.Models.RecepiesEntities;
using RecepieBlog.Models.UserEntities;

namespace RecepieBlog.Models.PaymentEntities
{
  public class UserRecepie : BaseEntity
  {
    public int UserId { get; set; }
    public virtual User User { get;set;}
    public int RecepieId { get; set; }
    public virtual Recepie Recepie { get; set; }
    public virtual PaymentReceiptDetail PaymentReceiptDetail { get; set; }


  }
}
