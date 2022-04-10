using System.ComponentModel.DataAnnotations;


namespace CheapestFlightSearch.Entity.Model
{
    public class Airport
    {
        [Key]
        public string IATA { get; set; }
        public string ICAO { get; set; }
        public string AirportName { get; set; }

        public string AirportLocation { get; set; }
    }
}
