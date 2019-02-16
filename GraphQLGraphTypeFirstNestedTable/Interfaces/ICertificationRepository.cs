using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLGraphTypeFirstNestedTable
{
    public interface ICertificaationRepository
    {
        Task<List<Certification>> GetCertificationByEmployee(long EmployeeId);
    }

}
