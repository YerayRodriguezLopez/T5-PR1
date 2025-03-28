using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DB;
using Microsoft.EntityFrameworkCore;

namespace T1_PR5.Pages.WaterConsum
{
    public class IndexModel : PageModel
    {
        private readonly EnergyDBContext _context;

        public IndexModel(EnergyDBContext context)
        {
            _context = context;
        }
        public IList<DB.WaterConsum> Consums { get; set; }
        public async Task OnGetAsync()
        {
            if (_context.WaterConsums != null)
            {
                Consums = await _context.WaterConsums.ToListAsync();
            }
        }
    }
}
