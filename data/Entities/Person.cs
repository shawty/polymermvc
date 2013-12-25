using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data.Entities
{
  [Table("People")]
  public class Person
  {
    [Key]
    public int RecordId { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public int Age { get; set; }
    public string ContactPic { get; set; }
    public string BlogPage { get; set; }
    public string TwitterHandle { get; set; }
    public string Department { get; set; }
    public string EMail { get; set; }
    public string Telephone { get; set; }
    public string Notes { get; set; }
  }
}
