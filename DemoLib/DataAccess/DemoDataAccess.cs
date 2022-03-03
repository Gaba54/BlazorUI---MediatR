using DemoLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoLib.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new(); //c# 9.0

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new PersonModel { Id = 2, FirstName = "Suzie", LastName = "Storm" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstname, string lastname)
        {
            PersonModel p = new() { FirstName = firstname, LastName = lastname };
            p.Id = people.Max(x => x.Id) + 1; //to get a unique Id in database
            people.Add(p);
            return p;
        }
    }
}
