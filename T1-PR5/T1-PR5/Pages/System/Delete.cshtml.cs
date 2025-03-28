using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace T1_PR5.Pages.System
{
    public class DeleteModel : PageModel
    {
        private readonly EnergyDBContext _context;
        public DeleteModel(EnergyDBContext context)
		{
			_context = context;
		}
        [BindProperty]
        public DB.System Systems { get; set; }
        public async Task<IActionResult> OnGetAsync(int? itemid)
        {
            if(itemid == null)
            {
                return NotFound();
            }
            var simulation = await _context.Systems.FirstOrDefaultAsync(s => s.Id == itemid);
            if(simulation == null)
			{
				return NotFound();
			}
            Systems = simulation;
			return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? itemid)
		{
			if(itemid == null)
			{
				return NotFound();
			}
			var simulation = await _context.Systems.FindAsync(itemid);
			if(simulation != null)
			{
				_context.Systems.Remove(simulation);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage(nameof(Index));
		}
    }
}
