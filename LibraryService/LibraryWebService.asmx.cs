using LibraryService.Models;
using LibraryService.Services;
using LibraryService.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LibraryService
{
    /// <summary>
    /// Summary description for LibraryWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LibraryWebService : WebService
    {
        private ILibraryRepositoryService _libraryRepositoryService;

        public LibraryWebService()
        {
            _libraryRepositoryService = new LibraryRepository(new LibraryDBContext());
        }

        [WebMethod]
        public List<Book> GetAllBooks()
        {
            return (List<Book>)_libraryRepositoryService.GetAllBooks();
        }

        [WebMethod]
        public List<Book> GetBooksByTitle(string tytle)
        {
            return (List<Book>)_libraryRepositoryService.GetByTitle(tytle);
        }

        [WebMethod]
        public List<Book> GetBookByCathegory(string cathegory)
        {
            return (List<Book>)_libraryRepositoryService.GetByCategory(cathegory);
        }

        [WebMethod]
        public List<Book> GetBooksByAuthor(string author)
        {
            return (List<Book>)_libraryRepositoryService.GetByAuthor(author);
        }


    }
}
