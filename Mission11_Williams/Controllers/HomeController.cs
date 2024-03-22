using Microsoft.AspNetCore.Mvc;
using Mission11_Williams.Models;
using Mission11_Williams.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Williams.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp)
        {
            _repo = temp;

        }


        //logic for the index page
        public IActionResult Index(int pageNum)
        {
            //setting how many books i want per page
            int pageSize = 10;

            
            var blah = new BooksListViewModel
            {
                //this grabs all the books
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                //this grabs all the pagination information
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = 10,
                    TotalItems = _repo.Books.Count()
                }
            };
            // returns book information and pagination information
            return View(blah);
        }

    }
}
