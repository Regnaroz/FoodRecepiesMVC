using AspnetCoreMvcFull.Models.Base;
using AspnetCoreMvcFull.Shared.Enums;

namespace AspnetCoreMvcFull.Models.UserEntities
{
  public class Role : BaseEntity
  {
    public string RoleName { get; set; }
    public Roles Roles { get; set; }
  }
}
