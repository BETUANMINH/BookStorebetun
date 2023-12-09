using BookShoppingCartMVC.Models;
using BookShoppingCartMVC.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Security.Policy;

namespace BookShoppingCartMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;


        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }
        private static async Task<double> CallApiAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://api.freecurrencyapi.com/v1/latest?apikey=fca_live_Xfhh8o5aBWDxq1smo6bGAzcsr6Z9X8wkybDUllTa&currencies=EUR"; // Replace with your API endpoint URL

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    //now result is json string and you can deserialize it to your model
                    // Deserialize the JSON string to an object
                    Response responseObject = JsonConvert.DeserializeObject<Response>(result);

                    // Access the EUR property
                    double Value = responseObject.Data.EUR;
                    return Value;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return 1;
                }
            }
        }
        public class Response
        {
            public Data Data { get; set; }
        }

        public class Data
        {
            public double EUR { get; set; }
        }


        public async Task<IActionResult> Index(string sTerm="", int genreId = 0, string currency = "USD")
        {
            double percentCurrency = 1;
            IEnumerable<Book> books = await _homeRepository.GetBooks(sTerm, genreId);
            if(currency != "USD")
            {
                percentCurrency = await CallApiAsync();
                foreach(var book in books)
                {
                    book.Price = book.Price * percentCurrency;
                }
            }

            IEnumerable<Genre> genres = await _homeRepository.GetGenres();
            
            BookDisplayModel bookModel = new BookDisplayModel
            {
                Books = books,
                Genres = genres,
                sTerm = sTerm,
                GenreId = genreId
            };
            ViewBag.Currency = currency;
            return View(bookModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
