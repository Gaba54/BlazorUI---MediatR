using DemoLib.Models;
using System.Collections.Generic;

namespace DemoLib.DataAccess
{
    public interface IDataAccess
    {
        List<PersonalModel> GetPeople();
        PersonalModel InsertPerson(string firstname, string lastname);
    }
}