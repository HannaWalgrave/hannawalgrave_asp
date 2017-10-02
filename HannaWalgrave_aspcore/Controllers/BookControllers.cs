using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HannaWalgrave_aspcore.Models;

namespace HannaWalgrave_aspcore.Controllers
{
    [Route("/books")]
    public class BookController :Controller 
    {
        [HttpGet]

        public IActionResult Index()
        {
            /*var model = new BookListViewModel();
            BookDetailModel book = new BookDetailModel();
            book.Title = "poging";
            book.Author = "chtulhu";
            book.ISBN = "1254";
            book.CreatedOn = new DateTime(1989/09/20);
            model.Books = new List<BookDetailModel>();
            model.Books.Add(book);
            model.Books.Add(book);
            model.Books.Add(book);*/

            var model = new BookListViewModel();
            return View( model);
        }

        [HttpGet("books/{id}")]
        
        public IActionResult Detail([FromRoute]int id)
        {
            var model = new BookListViewModel().Books[id];
            

            if (id == 0)
            {
                return new NotFoundResult();
            }
            return View(model);
        }
    }
}
