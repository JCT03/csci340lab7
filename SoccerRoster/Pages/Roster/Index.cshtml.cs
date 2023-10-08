using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoccerRoster.Data;
using SoccerRoster.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
         public string? SearchString { get; set; }

    public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            var players = from p in _context.Player
                 select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                players = players.Where(s => s.Name.Contains(SearchString));
            }

            Player = await players.ToListAsync();
        }
    }
}
