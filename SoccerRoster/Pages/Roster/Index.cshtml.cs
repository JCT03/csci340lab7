using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoccerRoster.Data;
using SoccerRoster.Models;

namespace SoccerRoster.Pages.Roster
{
    public class IndexModel : PageModel
    {
        private readonly SoccerRoster.Data.SoccerRosterContext _context;

        public IndexModel(SoccerRoster.Data.SoccerRosterContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Player != null)
            {
                Player = await _context.Player.ToListAsync();
            }
        }
    }
}
