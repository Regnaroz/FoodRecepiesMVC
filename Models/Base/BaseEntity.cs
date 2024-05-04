namespace AspnetCoreMvcFull.Models.Base
{
  public class BaseEntity
  {
    public int Id { get; set; }
    public int CreatedBy { get; set; }
    public int LastModifedBy { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public int IsDeleted { get; set; }
  }
}
