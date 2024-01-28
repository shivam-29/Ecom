using Ecom.Data;
using Ecom.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecom.Pages.Categories
{
    [BindProperties]
    public class DeleteModel(ApplicationDbContext _context) : PageModel
    {
        public Category? Category { get; set; }  
        public void OnGet(int Id)
        {
            if (Id is not 0)
            {
                Category = _context.Categories.Find(Id);
            }
        }

        public IActionResult OnPost()
        {

            _context.Categories.Remove(Category);
            _context.SaveChanges();
            TempData["Success"] = " Catgory Deleted SuccessFully!";

            return RedirectToPage("Index");

        }
    }
}
