using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEF
{
    public class Character
    {
        public Character()
        {

        }
        public int CharacterId { get; set; }

        public int AccountId { get; set; }
        [Required]
        [MaxLength(60)]
        public string Naam { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }

        public int Mana { get; set; }

        public bool Alive { get; set; }
        public virtual Account Account { get; set; }

        public void Heal(int x)
        {
            this.HP = this.HP + x;
        }

        public void Fight(Monster m)
        {
            m.HP -= Attack;
            if(m.HP<=0)
            {
                m.HP = 0;
                m.Alive = false;
            }
        }
    }
}
