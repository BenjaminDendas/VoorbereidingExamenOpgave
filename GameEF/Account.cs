using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEF
{
    public class Account
    {
        public Account()
        {

        }
        public int AccountId { get; set; }

        public int CharacterId { get; set; }

        [Required]
        [MaxLength(60)]
        public string GebruikersNaam { get; set; }

        [Required]
        [MaxLength(60)]
        public string Wachtwoord { get; set; }
        public virtual Character Character { get; set; }

        public bool Login(string username, string pass)
        {
            using (var context = new GameContext())
            {
                var accounts = context.Accounts.ToList();
                
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].GebruikersNaam.Equals(username))
                    {
                        if (pass.Equals(accounts[i].Wachtwoord))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
