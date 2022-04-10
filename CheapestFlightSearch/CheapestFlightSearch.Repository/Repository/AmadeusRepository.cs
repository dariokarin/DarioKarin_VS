using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CheapestFlightSearch.Entity.Interface;
using System.Collections.Generic;
using CheapestFlightSearch.Entity.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CheapestFlightSearch.Repository.Repository
{
    public class AmadeusRepository :IAmadeusRepository
    {

        private CheapestFlightSearch.Repository.Model.DatabaseContext _context;

        public AmadeusRepository (CheapestFlightSearch.Repository.Model.DatabaseContext context)
        {
            this._context = context;
        }

        public async Task<string> GetFlightsAsync(string origin, string destination, string departureDate, string returnDate, string currency, int passengers, string token)
        {
            string url = $"https://test.api.amadeus.com/v2/shopping/flight-offers?originLocationCode={origin}&destinationLocationCode={destination}&departureDate={departureDate}&adults={passengers}&currencyCode={currency}";

            if (!string.IsNullOrEmpty(returnDate))
            {
                url += $"&returnDate={returnDate}";
            }

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            using var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "";
        }


        public async Task<List<Airport>> GetAirports(string airportName)
        {
            var names = await _context.Airports.Where(x => x.AirportName.Contains(airportName)).ToListAsync();
            return names;
        }




        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
