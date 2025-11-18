using books.Models;
using Microsoft.AspNetCore.Mvc;

namespace books.Controllers
{
    public class BooksController : Controller
    {
        Book mybook = new Book(1, "El General y su Laberinto", "Gabriel Garcia Marquez", 1995);
        private List<Book> bookslist = new List<Book>();

        public void setbookslist()
        {
            bookslist.Add(mybook);
            bookslist.Add(new Book(10, "Tebas las Cien Puerta", "Desconocido", 2000));
            bookslist.Add(new Book(11, "Nunca pares", "Phil knight", 2010));
        }
        public List<Book> getbooklist()
        {
            return bookslist;
        }

        // GET: BooksController
        public ActionResult Index()
        {
            if (this.bookslist.Count == 0)
            {
                this.setbookslist();
            }
            return View(this.getbooklist());
        }
        public ActionResult Detalle(int id)
        {
            this.setbookslist();
            mybook = this.getbooklist().Find(book => book.Id == id);
            return View(mybook);
        }


        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Create([Bind("Id,titulo,autor,anio")] Book book)
        {
            if (ModelState.IsValid)
            {
                this.bookslist.Add(new Book());
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }


  // GET: BooksController/Edit/5
  public ActionResult Edit(int id)
  {
      try
      {
          return RedirectToAction(nameof(Index));
      }
      catch
      {
          return View();
      }
  }


  // POST: BooksController/Edit/5
  [HttpPost]
  [ValidateAntiForgeryToken]
 public ActionResult Edit(int id, IFormCollection collection)
  {
   try
   {
  return RedirectToAction(nameof(Index));
    }
  catch
   {
  return View();
   }
   }
   

// GET: BooksController/Delete/5
public ActionResult Delete(int id)
 {
   return View();
 }

   // POST: BooksController/Delete/5
[HttpPost]
[ValidateAntiForgeryToken]
 public ActionResult Delete(int id, IFormCollection collection)
 {
   try
 {
  return RedirectToAction(nameof(Index));
     }
     catch
     {
        return View();
      }
 }
}
}
