using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEF
{
    public class Monster
    {
        public Monster()
        {

        }

        public int HP { get; set; }
        public int Attack { get; set; }
        public bool Alive { get; set; }
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }
        public int MonsterId { get; set; }

        public void Fight(Character c)
        {
            c.HP -= Attack;
            if(c.HP<=0)
            {
                c.Alive = false;
                c.HP = 0;
            }
        }


        
    }
}
