using System;
using data;

namespace datatester
{
  class Program
  {
    static void Main()
    {
      using(var ctx = new Store())
      {
        foreach(var person in ctx.People)
        {
          Console.WriteLine(person.Name);
        }
      }

    }
  }
}
