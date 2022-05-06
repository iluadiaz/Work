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
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private BandcDbContext _ctx;

        public PersonRepository(BandcDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Person> GetData()
        {
            List<Person> results = new List<Person>();

            var person = _ctx.Person;

            foreach (var Data in person)
            {
                var newData = new Person();
                newData = Data;

                results.Add(newData);
            }

            return results;
        }
    }
}
