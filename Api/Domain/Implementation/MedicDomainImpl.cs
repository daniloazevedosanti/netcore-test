using Api.Model;
using Api.Repository.Generic;
using System.Collections.Generic;


namespace Api.Domain.Implementation
{
    public class MedicDomainImpl : IMedicDomain
    {

        private IMedicRepository _repository;


        public MedicDomainImpl(IMedicRepository repository)
        {
            _repository = repository;
        }

        public Medic Create(Medic obj)
        {
            var objEntity = obj;
            objEntity = _repository.Create(objEntity);
            return objEntity;
        }

        public Medic FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Medic> FindAll()
        {
            return _repository.FindAll();
        }

        public List<Medic> FindByName(string name)
        {
            return _repository.FindByName(name);
        }

        public Medic Update(Medic obj)
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
