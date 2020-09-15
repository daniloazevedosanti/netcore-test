using Api.Model;
using System.Collections.Generic;


namespace Api.Domain
{
    public interface IPatientDomain
    {
        Patient Create(Patient obj);
        Patient FindById(long id);
        List<Patient> FindAll();
        List<Patient> FindByName(string name);
        Patient Update(Patient obj);
        void Delete(long id);
    }
}