using Ecom.Data;
using Ecom.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecom.Pages.Categories
{
    public class CreateModel(ApplicationDbContext _context) : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
            TempData["Success"] = " Catgory Created SuccessFully!";

            return RedirectToPage("Index");

        }
    }
}
