using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CricketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public void OnGet()
        {
            Captain = "Asher" + ", the SMASHER, Lloyd";

            /*Players = new List<string>() { 
                "Joshua Steward", "Sidney Harmon", "Cam Maguf", "Jerome Beard" 
            };*/

            Players = context.Players.ToList();

            /*using (var db = new CricketDBContext( ) ) {
                Players = db.Players.OrderBy(p=>p.LastName).ToList();
            }*/


        }
    }
}
