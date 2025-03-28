using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DB;
using Microsoft.EntityFrameworkCore;

namespace T1_PR5.Pages.System
{
    public class IndexModel : PageModel
    {
        private readonly EnergyDBContext _context;

        public IndexModel(EnergyDBContext context)
        {
            _context = context;
        }
        public IList<DB.System> Systems { get; set; }
        public async Task OnGetAsync()
        {
            if(_context.Systems != null)
            {
                Systems = await _context.Systems.ToListAsync();
            }
        }
    }
}
