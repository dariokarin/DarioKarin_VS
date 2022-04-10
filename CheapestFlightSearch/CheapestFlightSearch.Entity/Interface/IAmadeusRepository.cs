using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheapestFlightSearch.Entity;
using CheapestFlightSearch.Entity.Model;

namespace CheapestFlightSearch.Entity.Interface
{
    public interface IAmadeusRepository:IDisposable
    {
        Task<string> GetFlightsAsync(string origin, string destination, string departureDate, string returnDate, string currency, int passengers, string token);

        Task<List<Airport>> GetAirports(string nameAirport);


        void Save();
    }
}
