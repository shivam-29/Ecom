using Ecom.Data;
using Ecom.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecom.Pages.Categories;

public class IndexModel(ApplicationDbContext _context) : PageModel
{
    public List<Category> Categories { get; set; } = [];
    public void OnGet()
    {
        Categories = [.. _context.Categories];
    }
}
