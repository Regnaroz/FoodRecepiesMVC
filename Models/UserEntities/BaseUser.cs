using AspnetCoreMvcFull.Models.Base;

namespace AspnetCoreMvcFull.Models.UserEntities
{
  public class BaseUser : BaseEntity
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string ProfilePicturePath { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Adderss { get; set; }
    public int RoleId { get; set; }
    public virtual Role Role { get; set; }

  }
}
