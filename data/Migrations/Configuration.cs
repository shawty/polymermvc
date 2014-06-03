namespace Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.Store>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "data.Store";
        }

        protected override void Seed(Data.Store context)
        {
          //IList<Person> defaultPeople = new List<Person>
          //                            {
          //                              new Person()
          //                                {
          //                                  RecordId = 1,
          //                                  Name = "Fred Blogs",
          //                                  Role = "Programmer",
          //                                  Age = 20,
          //                                  ContactPic = "images/avatars/Avatar-1.png"
          //                                },
          //                              new Person()
          //                                {
          //                                  RecordId = 2,
          //                                  Name = "Jane Doe",
          //                                  Role = "Systems Analyst",
          //                                  Age = 21,
          //                                  ContactPic = "images/avatars/Avatar-2.png"
          //                                },
          //                              new Person()
          //                                {
          //                                  RecordId = 3,
          //                                  Name = "Alice Person",
          //                                  Role = "Data Clerk",
          //                                  Age = 25,
          //                                  ContactPic = "images/avatars/Avatar-3.png"
          //                                }
          //                            };

          //context.People.AddRange(defaultPeople);

          //Random rand = new Random();
          //int numberToGenerate = rand.Next(5, 50);
          //int recordId = 1;

          //IList<GraphEntry> defaultGraphEntrys = new List<GraphEntry>();
          //for (int counter = 0; counter < numberToGenerate; counter++)
          //{
          //  var valueToSend = rand.Next(200);
          //  var tagToSend = string.Format("Value {0}", valueToSend);
          //  defaultGraphEntrys.Add(new GraphEntry { RecordId = recordId, Tag = tagToSend, Value = valueToSend });
          //  recordId++;
          //}

          //context.GraphEntrys.AddRange(defaultGraphEntrys);

        }
    }
}
