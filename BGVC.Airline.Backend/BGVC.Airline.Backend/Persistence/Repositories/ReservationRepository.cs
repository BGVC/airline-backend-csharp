using BGVC.Airline.Backend.DTO;
using BGVC.Airline.Backend.Models;
using BGVC.Airline.Backend.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AirlineDBContext _dbContext;

        public ReservationRepository(AirlineDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Reservation reservation)
        {
            // todo: current architecture is missing unit of work implementation. Once added, handle SaveChanges properly
            // And once more, check whether to include mostly used methods in generic repository.
            _dbContext.Add(reservation);
            // todo: check places to use SaveChangesAsync
            _dbContext.SaveChanges();
        }
    }
}
