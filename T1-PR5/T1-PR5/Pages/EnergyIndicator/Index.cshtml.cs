using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace T1_PR5.Pages.EnergyIndicator
{
    public class IndexModel : PageModel
    {
        readonly DB.EnergyDBContext _context;
        public IndexModel(DB.EnergyDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<DB.EnergyIndicator> indicator { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (_context.EnergyIndicators != null)
            {
                indicator = await _context.EnergyIndicators.ToListAsync();
            }
            return Page();
        }
    }
}
