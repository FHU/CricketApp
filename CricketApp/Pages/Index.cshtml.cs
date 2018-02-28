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

        public string Referee
        {
            get;
            set;
        }

            
        public List<Player> Players
        {
            get;
            set;
        }


        public void OnGet()
        {
            Referee = "Asher" + ", the SMASHER, Lloyd";

            /*Players = new List<string>() { 
                "Joshua Steward", "Sidney Harmon", "Cam Maguf", "Jerome Beard" 
            };*/


            using (var db = new DatabaseContext()) {
                Players = db.Players.ToList();

            }

        }
    }
}
