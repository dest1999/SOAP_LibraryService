using LibraryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryService.Services.Implementation
{
    public class LibraryRepository : ILibraryRepositoryService
    {
        private ILibraryDBContextService dbContextService;

        public LibraryRepository(ILibraryDBContextService context)
        {
            dbContextService = context;
        }


        public IList<Book> GetAllBooks()
        {
            return dbContextService.Books;
        }

        public IList<Book> GetByAuthor(string authorName)
        {
            //TODO .Contains()
            return dbContextService.Books.Where(b => 
                b.Authors.Where(author => author.Name.ToLower().Contains(authorName.ToLower())).Count() > 0).ToList();
        }

        public IList<Book> GetByCategory(string category)
        {
            return dbContextService.Books.Where(b => b.Category.ToLower().Contains(category.ToLower())).ToList();
        }

        public IList<Book> GetByTitle(string title)
        {
            return dbContextService.Books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
        }
    }
}