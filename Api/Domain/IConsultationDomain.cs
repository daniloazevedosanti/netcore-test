using Api.Model;
using System.Collections.Generic;


namespace Api.Domain
{
    public interface IConsultationDomain
    {
        Consultation Create(Consultation obj);
        Consultation FindById(long id);
        List<Consultation> FindAll();
        List<Consultation> FindByName(string name);
        Consultation Update(Consultation obj);
        void Delete(long id);
    }
}