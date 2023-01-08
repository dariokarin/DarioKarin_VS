using CheapestFlightSearch.Entity.Interface;
using CheapestFlightSearch.Entity.Model;
using CheapestFlightSearch.Entity.ViewModel;
using CheapestFlightSearch.Models;
using CheapestFlightSearch.Repository.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CheapestFlightSearch.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IAmadeusRepository _amadeusRepository;

        public HomeController (IAmadeusRepository amadeusRepository)
        {
            this._amadeusRepository = amadeusRepository;
        }


        public IActionResult Index()
        {

            return View(new SearchParams());
        }

        [HttpPost]
        public IActionResult Index(SearchParams searchParams, string token)
        {


            var results1 = _amadeusRepository.GetFlightsAsync(searchParams.DepartureAirport, searchParams.ArrivalAirport, Convert.ToString(searchParams.DepartureDate), Convert.ToString(searchParams.ReturnDate), Convert.ToString(searchParams.Currency), searchParams.Passengers, token);

            return PartialView("Result");

        }


        public async Task<IActionResult> AirportAutocomplete(string term)
        {
            var names = await _amadeusRepository.GetAirports(term);
            return new JsonResult(names);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Entity.Model.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
