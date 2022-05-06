using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsTask.Models;
//using DevOpsTask.Models.DbModels;

namespace DevOpsTask.DAL.Abstract
{
    public interface IPersonApplicationRepository : IRepository<PersonApplications>
    {
        IEnumerable<PersonApplications> GetData();
    }
}
