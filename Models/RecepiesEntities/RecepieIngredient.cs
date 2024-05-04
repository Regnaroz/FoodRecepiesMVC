using AspnetCoreMvcFull.Models.Base;

namespace AspnetCoreMvcFull.Models.RecepiesEntities
{
  public class RecepieIngredient : BaseEntity
  {
    public int RecepieId { get; set; }
    public virtual Recepie Recepie { get; set; }
    public int IngredientId { get; set; }
    public virtual Ingredient Ingredient { get; set; }
    public string Amount { get; set; } 

  }
}
