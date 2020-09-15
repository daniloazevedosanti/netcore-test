using Api.Model;
using Api.Model.Context;
using Api.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Implementations
{
    public class MedicRepositoryImpl : GenericRepository<Medic>, IMedicRepository
    {
        public MedicRepositoryImpl(MySQLContext context) : base(context) { }

        public List<Medic> FindByName(string firstName)
        {
            if (!string.IsNullOrEmpty(firstName))
            {
                return _context.Medicos.Where(p => p.Name.Contains(firstName)).ToList();
            }
            else if (string.IsNullOrEmpty(firstName))
            {
                return _context.Medicos.Where(p => p.Name.Contains(firstName)).ToList();
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                return _context.Medicos.Where(p => p.Name.Contains(firstName)).ToList();
            }
            return _context.Medicos.ToList();
        }
    }
}
