using AspnetCoreMvcFull.Models.Base;
using AspnetCoreMvcFull.Models.RecepiesEntities;

namespace RecepieBlog.Models.PaymentEntities
{
  public class PaymentReceiptDetail : BaseEntity
  {
    public DateTime PaymentDate { get; set; }
    public string PaymentPdfPath { get; set; }
    public double PaymentPrice { get; set; }
    public int UserRecepieId { get; set; }
    public virtual UserRecepie UserRecepie { get; set; }
  }
}
