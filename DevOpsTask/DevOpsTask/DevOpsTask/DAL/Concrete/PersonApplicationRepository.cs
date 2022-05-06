using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsTask.Models;
using DevOpsTask.DAL.Abstract;
using DevOpsTask.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections;
//using DevOpsTask.Models.DbModels;

namespace DevOpsTask.DAL.Concrete
{
    public class PersonApplicationRepository : Repository<PersonApplications>,IPersonApplicationRepository
    {
        private BandcDbContext _ctx;

        public PersonApplicationRepository(BandcDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<PersonApplications> GetData()
        {
            List<PersonApplications> results = new List<PersonApplications>();

            var persons = _ctx.PersonApplications;

            foreach(var Data in persons)
            {
                var newData  = new PersonApplications();
                newData = Data;

                results.Add(newData);
            }
            
            return results;
        }
    }
}
