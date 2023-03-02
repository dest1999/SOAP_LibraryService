using LibraryService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LibraryService.Services.Implementation
{
    public class LibraryDBContext : ILibraryDBContextService
    {
        private IList<Book> books;

        public LibraryDBContext()
        {
            Init();
        }

        private void Init()
        {

            books = (List<Book>)JsonConvert.DeserializeObject(Encoding.UTF8.GetString(Properties.Resources.books), typeof(List<Book>));
        }

        public IList<Book> Books => books;
    }
}