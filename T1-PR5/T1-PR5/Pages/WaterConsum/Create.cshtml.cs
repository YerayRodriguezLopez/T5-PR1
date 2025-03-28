using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T1_PR5.Pages.WaterConsum

{
    public class CreateModel : PageModel
    {
        private readonly EnergyDBContext _context;
        public CreateModel(EnergyDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DB.WaterConsum consum { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid || _context.WaterConsums == null || consum == null)
            {
                return Page();
            }
            else
            {

                _context.WaterConsums.Add(consum);
                await _context.SaveChangesAsync();
                return RedirectToPage(nameof(Index));
            }
        }
    }
}
