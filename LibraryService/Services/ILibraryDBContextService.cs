﻿using LibraryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Services
{
    public interface ILibraryDBContextService
    {
        IList<Book> Books { get; }
    }
}
