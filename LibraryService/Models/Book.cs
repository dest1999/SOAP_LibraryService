using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryService.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Lang { get; set; }
        public int Pages { get; set; }
        public int AgeLimit { get; set; }
        public int PubDate { get; set; }
        public Author[] Authors { get; set; }

        public override string ToString()
        {
            return $"{Title}, ({Lang}, {PubDate}г, {Pages}стр, +{AgeLimit}) /{Category}/ {string.Join<Author>(",", Authors)}";
        }
    }
}