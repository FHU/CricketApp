using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CricketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CricketApp.Pages
{
    public class IndexModel : PageModel
    {

        private readonly CricketDBContext context;

        public IndexModel(CricketDBContext context) {
            this.context = context;
        }

        public string Captain { get; set; }
            
        public List<Player> Players { get; set; }

        /*public void OnGet()
        {
            Captain = "Asher" + ", the SMASHER, Lloyd";

            Players = context.Players.ToList();

            //using (var db = new CricketDBContext( ) ) {
            //    Players = db.Players.OrderBy(p=>p.LastName).ToList();
            //}

        }*/

        public async Task OnGetAsync() {
            Captain = "Asher" + ", the SMASHER, Lloyd";

            Players = await context.Players.ToListAsync();
        }

        [BindProperty]
        public Player Player { get; set; }

        /*public void OnPost() {
            context.Players.Add(Player);
            context.SaveChanges();

            RedirectToPage("./Index");
        }*/

        public async Task<IActionResult> OnPostAsync() {
            context.Players.Add(Player);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
