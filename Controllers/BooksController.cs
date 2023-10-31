using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookShoppingCartMVC.Data;
using BookShoppingCartMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;

namespace BookShoppingCartMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BooksController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Books.Include(b => b.Genre);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "GenreName");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // get the book object from the form contain image file
        public async Task<IActionResult> Create(Book book, IFormFile Image)
        {
         
            //if extension is not valid
            if (Image != null && Image.Length > 0)
            {
                if (Image.ContentType.ToLower() != "image/jpeg" &&
                    Image.ContentType.ToLower() != "image/jpg" &&
                    Image.ContentType.ToLower() != "image/png" &&
                    Image.ContentType.ToLower() != "image/gif")
                {
                    ModelState.AddModelError("Image", "Only images (.jpg, .png, .gif) are allowed");
                    ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "GenreName", book.GenreId);
                    return View(book);
                }
            }
            // check if the image file is not null
            if (Image != null) {
                string fileName = UploadFile(Image);
                book.Image = fileName;
            }
            else
            {
                book.Image = "NoImage.png";
            }
            // check if the book object is valid

        


                // insert record
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
              
            
            
        }
        private string UploadFile(IFormFile file)
        {
            string fileName = null;
            if (file != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "GenreName");
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Book book, IFormFile Image)
        {
            //if extension is not valid
            if (Image != null && Image.Length > 0)
            {
                if (Image.ContentType.ToLower() != "image/jpeg" &&
                    Image.ContentType.ToLower() != "image/jpg" &&
                    Image.ContentType.ToLower() != "image/png" &&
                    Image.ContentType.ToLower() != "image/gif")
                {
                    ModelState.AddModelError("Image", "Only images (.jpg, .png, .gif) are allowed");
                    ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "GenreName", book.GenreId);
                    return View(book);
                }
            }
            // check if the image file is not null
            if (Image != null)
            {
                string fileName = UploadFile(Image);
                book.Image = fileName;
            }
            else
            {
                book.Image = "NoImage.png";
            }
            if (id != book.Id)
            {
                return NotFound();
            }

            
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            
            //ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "GenreName", book.GenreId);
            //return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Books == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Books'  is null.");
            }
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
          return (_context.Books?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
