using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Data;
using Data.Entities;
using Polymermvc.Models;

namespace Polymermvc.Classes
{
  public class PeopleDatabase
  {
    public static List<MinimalPersonViewModel> GetAllPeople()
    {
      List<MinimalPersonViewModel> results;
      Mapper.CreateMap<Person, MinimalPersonViewModel>();

      using(var dataStore = new Store())
      {
        results = Mapper.Map<List<Person>, List<MinimalPersonViewModel>>(dataStore.People.ToList());
      }

      return results;
    }

    public static MinimalPersonViewModel GetOneMinimalPersonByRecordId(int recordId)
    {
      MinimalPersonViewModel result;
      Mapper.CreateMap<Person, MinimalPersonViewModel>();

      using (var dataStore = new Store())
      {
        var theRecord = dataStore.People.FirstOrDefault(x => x.RecordId == recordId);
        result = theRecord != null ? Mapper.Map<Person, MinimalPersonViewModel>(theRecord) : null;
      }

      return result;
    }

    public static FullPersonViewModel GetOneFullPersonByRecordId(int recordId)
    {
      FullPersonViewModel result;
      Mapper.CreateMap<Person, FullPersonViewModel>();

      using (var dataStore = new Store())
      {
        var theRecord = dataStore.People.FirstOrDefault(x => x.RecordId == recordId);
        result = theRecord != null ? Mapper.Map<Person, FullPersonViewModel>(theRecord) : null;
      }

      return result;
    }

    public static void UpdateFullPerson(FullPersonViewModel personDetails)
    {
      Mapper.CreateMap<FullPersonViewModel, Person>()
        .ForMember(dest => dest.RecordId, opt => opt.Ignore());

      using(var dataStore = new Store())
      {
        var originalRecord = dataStore.People.Find(personDetails.RecordId);

        if(originalRecord != null)
        {
          originalRecord = Mapper.Map<FullPersonViewModel, Person>(personDetails, originalRecord);
        }

        dataStore.SaveChanges();
      }
    }

  }
}