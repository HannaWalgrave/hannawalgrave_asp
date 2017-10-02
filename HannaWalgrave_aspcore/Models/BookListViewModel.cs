using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HannaWalgrave_aspcore.Models
{
    public class BookListViewModel
    {
        public Dictionary<int, BookDetailModel> Books = new Dictionary<int, BookDetailModel>()
        {
            {1, new BookDetailModel {Author = "Cthulhu", ISBN = "ph’nglui" , Title = "in his house at R’lyeh sleeping Cthulhu waits dreaming"} },
            {2, new BookDetailModel{Author = "Sandworm", ISBN = "Arrakis" , Title = "Shai-Hulud"} },
            {3, new BookDetailModel{Author = "Godzilla", ISBN = "Gojira" , Title = "Ishiro Honda"} },
        };
        
    }
}
