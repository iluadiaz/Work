using DevOpsTask.Models;
using DevOpsTask.DAL.Abstract;



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
