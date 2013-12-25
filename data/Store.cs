using System.Data.Entity;
using data.Entities;

namespace data
{
  public class Store : DbContext
  {
    public Store()
      : base("dataStoreConnection") // Name of the connection string to look for
    {
      Database.SetInitializer<Store>(new DataStoreInitializer());
    }

    public DbSet<Person> People { get; set; }
    public DbSet<GraphEntry> GraphEntrys { get; set; }

  }
}
