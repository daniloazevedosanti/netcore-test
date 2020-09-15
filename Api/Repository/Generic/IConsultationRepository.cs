using Api.Model;
using System.Collections.Generic;

namespace Api.Repository.Generic
{
    public interface IConsultationRepository : IRepository<Consultation>
    {
        List<Consultation> FindByName(string name);
    }
}
