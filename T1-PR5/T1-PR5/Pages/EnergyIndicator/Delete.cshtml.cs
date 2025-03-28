using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace T1_PR5.Pages.EnergyIndicator
{
    public class DeleteModel : PageModel
    {
        readonly DB.EnergyDBContext _context;
        public DeleteModel(DB.EnergyDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public DB.EnergyIndicator indicator { get; set; }
        public async Task<IActionResult> OnGetAsync(int? itemid)
        {
            if (itemid == null)
            {
                return NotFound();
            }
            var indicator = await _context.EnergyIndicators.FirstOrDefaultAsync(s => s.Id == itemid);
            if (indicator == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (indicator == null)
            {
                return NotFound();
            }
            _context.EnergyIndicators.Remove(indicator);
            await _context.SaveChangesAsync();
            return RedirectToPage(nameof(Index));
        }
    }
}
