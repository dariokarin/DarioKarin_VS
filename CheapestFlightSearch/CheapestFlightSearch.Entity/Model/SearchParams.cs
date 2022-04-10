using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheapestFlightSearch.Entity.Model
{
    [Table("SearchingHistory")]
    public class SearchParams
    {
        [Required(ErrorMessage = "Please select departure airport.")]
        public string DepartureAirport { get; set; }

        [Required(ErrorMessage = "Please select arrival airport.")]
        public string ArrivalAirport { get; set; }

        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }

        [Required(ErrorMessage = "Please select currency.")]
        public Currency1? Currency { get; set; }

        [Required(ErrorMessage = "Please enter a number of adult passengers.")]
        [Range(1, int.MaxValue)]
        public int Passengers { get; set; }

        public string JsonResult { get; set; }

        public SearchParams()
        {
            Passengers = 1;
            DepartureDate = DateTime.Now;
        }

        public enum Currency1
        {
            USD,
            EUR,
            HRK
        }
    }
}
