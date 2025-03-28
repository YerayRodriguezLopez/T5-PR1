using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace T1_PR5.Pages.System
{
    public class EditModel : PageModel
    {
        private readonly EnergyDBContext _context;
        public EditModel(EnergyDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DB.System Systems { get; set; }
        public async Task<IActionResult> OnGetAsync(int? itemid)
        {
            if (itemid == null || _context.Systems == null)
            {
                return NotFound();
            }
            var simulation = await _context.Systems.FirstOrDefaultAsync(s => s.Id == itemid);
            if (simulation == null)
            {
                return NotFound();
            }
            Systems = simulation;
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
                Systems.DateTime = DateTime.Now;
                _context.Systems.Update(Systems);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Simulations");
            }
        }
    }
}
