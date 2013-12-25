using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data.Entities
{
  [Table("GraphEntrys")]
  public class GraphEntry
  {
    [Key]
    public int RecordId { get; set; }
    public string Tag { get; set; }
    public int Value { get; set; }
  }
}
