using AspnetCoreMvcFull.Models.Base;
using AspnetCoreMvcFull.Models.RecepiesEntities;
using AspnetCoreMvcFull.Models.UserEntities;

namespace RecepieBlog.Models.UserEntities
{
  public class Chef : BaseEntity
  {
    public int UserId { get; set; }
    public virtual BaseUser User { get; set; }
    public virtual ICollection<Recepie> Recepies { get; set; }

  }
}
