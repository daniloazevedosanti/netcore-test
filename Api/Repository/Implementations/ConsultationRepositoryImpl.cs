using Api.Model;
using Api.Model.Context;
using Api.Repository.Generic;
using System.Collections.Generic;
using System.Linq;


namespace Api.Repository.Implementations
{
    public class ConsultationRepositoryImpl : GenericRepository<Consultation>, IConsultationRepository
    {
        public ConsultationRepositoryImpl(Context context) : base(context) { }

        public List<Consultation> FindByName(string firstName)
        {
            if (!string.IsNullOrEmpty(firstName))
            {
                return _context.Consultas.Where(p => p.Patient.Name.Contains(firstName)).ToList();
            }
            else if (string.IsNullOrEmpty(firstName))
            {
                return _context.Consultas.Where(p => p.Patient.Name.Contains(firstName)).ToList();
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                return _context.Consultas.Where(p => p.Patient.Name.Contains(firstName)).ToList();
            }
            return _context.Consultas.ToList();
        }
    }
}
