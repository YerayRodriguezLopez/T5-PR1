using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T1_PR5.Pages.System
{
    public class CreateSystemModel : PageModel
    {
        private readonly EnergyDBContext _context;
        public CreateSystemModel(EnergyDBContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public DB.System Systems { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Systems.DateTime = DateTime.Now;
            _context.Systems.Add(Systems);
            await _context.SaveChangesAsync();
            return RedirectToPage(nameof(Index));
        }
    }
}
//44:06 Full CRUD Operations .Net Core Razor Pages CRUD - .NET 8.0 Razor Pages