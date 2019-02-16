using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLGraphTypeFirstNestedTable
{
    public class CertificationRepository : ICertificaationRepository
    {
        private readonly GraphQLDemoContext _context;
        public CertificationRepository(GraphQLDemoContext context)
        {
            _context = context;
        }

        public Task<List<Certification>> GetCertificationByEmployee(long EmployeeId)
        {
            return _context.Certification.Where(a => a.Id == EmployeeId).ToListAsync();
        }
    }

}
