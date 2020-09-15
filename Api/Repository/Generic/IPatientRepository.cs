using Api.Model;
using System.Collections.Generic;

namespace Api.Repository.Generic
{
    public interface IPatientRepository : IRepository<Patient>
    {
        List<Patient> FindByName(string name);
    }
}
