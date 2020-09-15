using Api.Model;
using Api.Repository.Generic;
using System.Collections.Generic;


namespace Api.Domain.Implementation
{
    public class PatientDomainImpl : IPatientDomain
    {

        private IPatientRepository _repository;


        public PatientDomainImpl(IPatientRepository repository)
        {
            _repository = repository;
        }

        public Patient Create(Patient obj)
        {
            var objEntity = obj;
            objEntity = _repository.Create(objEntity);
            return objEntity;
        }

        public Patient FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Patient> FindAll()
        {
            return _repository.FindAll();
        }

        public List<Patient> FindByName(string name)
        {
            return _repository.FindByName(name);
        }

        public Patient Update(Patient obj)
        {
            var objEntity = obj;
            objEntity = _repository.Update(objEntity);
            return objEntity;
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

        
    }
}
