using System.ComponentModel.DataAnnotations;

namespace MyPortolio.DAL.Entities
{
  public class Features
  {
    [Key]
    public int FeatureId { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }


    }
}
