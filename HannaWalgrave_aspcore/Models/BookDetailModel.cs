using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HannaWalgrave_aspcore.Models
{
    public class BookDetailModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
