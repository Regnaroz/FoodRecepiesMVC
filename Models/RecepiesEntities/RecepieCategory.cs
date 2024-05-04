using AspnetCoreMvcFull.Models.Base;

namespace AspnetCoreMvcFull.Models.RecepiesEntities
{
  public class RecepieCategory:BaseEntity
  {
    public int RecepieId { get; set; }
    public virtual Recepie Recepie { get; set;}
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
  }
}
