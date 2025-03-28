using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace T1_PR5.Pages.EnergyIndicator
{
    public class CreateModel : PageModel
    {
        readonly DB.EnergyDBContext _context;
        public CreateModel(DB.EnergyDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public DB.EnergyIndicator indicator { get; set; }

        public  IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.EnergyIndicators == null || indicator == null)
            {
                return Page();
            }
            else
            {
                _context.EnergyIndicators.Add(indicator);
                await _context.SaveChangesAsync();
                return RedirectToPage(nameof(Index));
            }
        }
    }
}
