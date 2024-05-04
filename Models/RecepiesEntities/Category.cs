using AspnetCoreMvcFull.Models.Base;

namespace AspnetCoreMvcFull.Models.RecepiesEntities
{
  public class Category : BaseEntity
  {
    public string Name { get; set; }
    public string Color { get; set; }
    public string CategoryPicturePath { get; set; }
    public virtual ICollection<RecepieCategory> RecepieCategories { get;}
  }
}
