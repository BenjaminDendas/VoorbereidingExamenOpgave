using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado3LagenMonster
{
    public class Monster
    {
        public int MonsterId { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public bool Alive { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        public Monster()
        {

        }

        public override string ToString()
        {
            return "ID: " + MonsterId + " Name: " + Name + " " + "HP: " + HP + " Attack: " + Attack + " Alive: " + Alive;
        }




    }
}
