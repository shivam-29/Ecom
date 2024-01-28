using Ecom.Data;
using Ecom.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecom.Pages.Categories
{
    [BindProperties]
    public class EditModel(ApplicationDbContext _context) : PageModel
    {
        public Category? Category { get; set; }
        public void OnGet(int? id)
        {
            if(id!=null && id > 0)
            {
                Category = _context.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(Category);
                _context.SaveChanges();
                TempData["Success"] = " Catgory Updated SuccessFully!";

                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}
