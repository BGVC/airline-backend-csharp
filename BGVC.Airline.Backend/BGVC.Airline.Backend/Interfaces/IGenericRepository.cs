using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Interfaces
{
    interface IGenericRepository<T> : IDisposable where T : class
    {
        // Todo: Ask VC: Why abandon generic repository approach?
        // We are not returning IQueryable because once results are retrieved from the database,
        // no further querying should be done (No exposing of database out of repository). Hence no usage of IQueryable.
        List<T> GetAll();
        void Add();
        void Update();
        void Delete();
        T FindById();
    }
}
