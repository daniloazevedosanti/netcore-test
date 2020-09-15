using Api.Model;
using System.Collections.Generic;

namespace Api.Repository.Generic
{
    public interface IMedicRepository : IRepository<Medic>
    {
        List<Medic> FindByName(string name);
    }
}
