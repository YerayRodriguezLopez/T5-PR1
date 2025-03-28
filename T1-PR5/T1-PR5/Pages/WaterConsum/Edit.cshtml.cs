using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace T1.PR5.Pages.WaterConsum
{
    public class EditModel : PageModel
    {
		private readonly EnergyDBContext _context;
		public EditModel(EnergyDBContext context)
		{
			_context = context;
		}

		[BindProperty]
		public DB.WaterConsum Consum { get; set; }
		public async Task<IActionResult> OnGetAsync(int? itemid)
		{
			if (itemid == null || _context.WaterConsums == null)
			{
				return NotFound();
			}
			var consum = await _context.WaterConsums.FirstOrDefaultAsync(s => s.Id == itemid);
			if (consum == null)
			{
				return NotFound();
			}
			Consum = consum;
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
				_context.WaterConsums.Update(Consum);
				await _context.SaveChangesAsync();
				return RedirectToPage(nameof(Index));
			}
		}
	}
}
