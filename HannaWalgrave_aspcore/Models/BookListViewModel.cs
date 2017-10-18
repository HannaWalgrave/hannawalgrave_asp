using System;
using System.Collections.Generic;

namespace HannaWalgrave_aspcore.Models
{
    public class BookListViewModel
    {
        public List<BookDetailViewModel> Books { get; set; }
        public DateTime GeneratedAt => DateTime.Now;
    }
}
