using Api.Model;
using Api.Model.Context;
using Api.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Implementations
{
    public class PatientRepositoryImpl : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepositoryImpl(Context context) : base(context) { }

        public List<Patient> FindByName(string firstName)
        {
            if (!string.IsNullOrEmpty(firstName))
            {
                return _context.Pacientes.Where(p => p.Name.Contains(firstName)).ToList();
            }
            else if (string.IsNullOrEmpty(firstName))
            {
                return _context.Pacientes.Where(p => p.Name.Contains(firstName)).ToList();
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                return _context.Pacientes.Where(p => p.Name.Contains(firstName)).ToList();
            }
            return _context.Pacientes.ToList();
        }
    }
}
