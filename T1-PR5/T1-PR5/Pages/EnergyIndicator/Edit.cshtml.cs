using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace T1_PR5.Pages.EnergyIndicator
{
    public class EditModel : PageModel
    {
        readonly DB.EnergyDBContext _context;
        public EditModel(DB.EnergyDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public DB.EnergyIndicator indicator { get; set; }

        public async Task<IActionResult> OnGetAsync(int? itemid)
        {
            if (itemid == null || _context.EnergyIndicators == null)
            {
                return NotFound();
            }
            var ind = await _context.EnergyIndicators.FirstOrDefaultAsync(s => s.Id == itemid);
            if (ind == null)
            {
                return NotFound();
            }
            indicator = ind;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                _context.EnergyIndicators.Update(indicator);
                await _context.SaveChangesAsync();
                return RedirectToPage(nameof(Index));
            }
        }
    }
}
