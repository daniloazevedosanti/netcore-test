using Api.Model;
using Api.Repository.Generic;
using System.Collections.Generic;


namespace Api.Domain.Implementation
{
    public class ConsultationDomainImpl : IConsultationDomain
    {

        private IConsultationRepository _repository;


        public ConsultationDomainImpl(IConsultationRepository repository)
        {
            _repository = repository;
        }

        public Consultation Create(Consultation obj)
        {
            var objEntity = obj;
            objEntity = _repository.Create(objEntity);
            return objEntity;
        }

        public Consultation FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Consultation> FindAll()
        {
            return _repository.FindAll();
        }

        public List<Consultation> FindByName(string name)
        {
            return _repository.FindByName(name);
        }

        public Consultation Update(Consultation obj)
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
