using LibraryService.WebClientMVC.Models;
using LibraryServiceReference;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryService.WebClientMVC.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILogger<LibraryController> _logger;

        public LibraryController(ILogger<LibraryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(SearchType searchType, string searchString)
        {
            LibraryWebServiceSoapClient client = new(LibraryWebServiceSoapClient.EndpointConfiguration.LibraryWebServiceSoap);

            if (!string.IsNullOrEmpty(searchString) && searchString.Length >= 1)
            {
                switch (searchType)
                {
                    case SearchType.Title:
                        return View(new BookCategoryViewModel 
                        { 
                            Books = client.GetBooksByTitle(searchString)
                        });
                        break;
                    case SearchType.Author:
                        return View(new BookCategoryViewModel
                        {
                            Books = client.GetBooksByAuthor(searchString)
                        });
                        break;
                    case SearchType.Category:
                        return View(new BookCategoryViewModel
                        {
                            Books = client.GetBookByCathegory(searchString)
                        });
                        break;
                    default:
                        break;
                }
            }

            return View(new BookCategoryViewModel
            {
                Books = client.GetAllBooks()
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}