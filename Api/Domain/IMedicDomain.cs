using Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain
{
    public interface IMedicDomain
    {
        Medic Create(Medic obj);
        Medic FindById(long id);
        List<Medic> FindAll();
        List<Medic> FindByName(string name);
        Medic Update(Medic obj);
        void Delete(long id);
    }
}