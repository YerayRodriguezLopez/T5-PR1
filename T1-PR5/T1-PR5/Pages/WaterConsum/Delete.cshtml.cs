using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace T1_PR5.Pages.WaterConsum
{
    public class DeleteModel : PageModel
    {
        readonly DB.EnergyDBContext _context;
        public DeleteModel(DB.EnergyDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DB.WaterConsum Consum { get; set; }
        public async Task<IActionResult> OnGetAsync(int? itemid)
        {
            if (itemid == null)
            {
                return NotFound();
            }
            var consum = await _context.WaterConsums.FirstOrDefaultAsync(s => s.Id == itemid);
            if (consum == null)
            {
                return NotFound();
            }
            return RedirectToPage(nameof(Index));
        }
    }
}
