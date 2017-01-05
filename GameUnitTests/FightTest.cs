using GameEF;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUnitTests
{
    [TestFixture]
    public class FightTest
    {
        
        [Test]
        public void MonsterShouldTake20Damage()
        {
            // Aanmaken objecten
            Character c = new Character { CharacterId = 1, Alive = true, HP = 100, Mana = 100, Naam = "Character1", Attack = 20 };
            Monster m = new Monster { MonsterId = 1, Alive = true, HP = 100, Attack = 10, Name = "Monster1" };

            //Uitvoeren methode
            c.Fight(m);

            //Testen
            Assert.That(m.HP, Is.EqualTo(80));
        }
        [Test]
        public void CharacterShouldTake10Damage()
        {
            Character c = new Character { CharacterId = 1, Alive = true, HP = 100, Mana = 100, Naam = "Character1", Attack = 20 };
            Monster m = new Monster { MonsterId = 1, Alive = true, HP = 100, Attack = 10, Name = "Monster1" };

            m.Fight(c);

            //testen
            Assert.That(c.HP, Is.EqualTo(90));
        }

        [Test]
        public void CharacterShouldDieTest()
        {
            Character c = new Character { CharacterId = 1, Alive = true, HP = 100, Mana = 100, Naam = "Character1", Attack = 20 };
            Monster m = new Monster { MonsterId = 1, Alive = true, HP = 100, Attack = 150, Name = "Monster1" };

            m.Fight(c);

            Assert.That(c.Alive, Is.False);
        }

        [Test]
        public void MonsterShouldDieTest()
        {
            Character c = new Character { CharacterId = 1, Alive = true, HP = 100, Mana = 100, Naam = "Character1", Attack = 20 };
            Monster m = new Monster { MonsterId = 1, Alive = true, HP = 100, Attack = 150, Name = "Monster1" };

            for(int i=0;i<5;i++)
            {
                c.Fight(m);
            }
            Assert.That(m.Alive, Is.False);

        }

        [Test]
        public void CharacterShouldHeal50Test()
        {
            Character c = new Character { CharacterId = 1, Alive = true, HP = 20, Mana = 20, Naam = "Character1", Attack = 10 };
            c.Heal(50);
            Assert.That(c.HP, Is.EqualTo(70));
        }

    }
}
