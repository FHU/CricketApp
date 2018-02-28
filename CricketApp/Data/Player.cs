using System;
namespace CricketApp.Data
{
    public class Player
    {
        public Player()
        {
        }

        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public DateTime Birthdate
        {
            get;
            set;
        }
    }
}
