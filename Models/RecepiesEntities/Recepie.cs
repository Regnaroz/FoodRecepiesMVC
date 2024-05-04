using AspnetCoreMvcFull.Models.Base;
using RecepieBlog.Models.UserEntities;

namespace AspnetCoreMvcFull.Models.RecepiesEntities
{
  public class Recepie : BaseEntity
  {
    public string Name { get; set; }
    public string Details { get; set; }
    public string Steps { get; set; }
    public double Price { get; set; }
    public double Discount { get; set; }
    public bool IsApproved { get; set; }
    public int ChefId { get; set; }
    public virtual Chef Chef { get; set; }
    public virtual ICollection<RecepieCategory> RecepieCategories { get; set; }
    public virtual ICollection<RecepieIngredient> RecepieIngredient { get; set; }

  }
}
