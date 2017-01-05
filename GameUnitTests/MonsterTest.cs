using Ado3LagenMonster;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUnitTests
{
    [TestFixture]
    public class MonsterTest
    {
        [Test]
        public void ShouldCreateMonster()
        {

            Monster m = new Monster
            {
                MonsterId = MonsterDB.GetNextMonsterId(),
                Alive = true,
                Attack = 1,
                HP = 1,
                Name = "BenMonster"
            };

            int amountInDb = MonsterDB.GetMonsters().Count;

            MonsterDB.InsertMonster(m);

            int amountInDbAfterInsert = MonsterDB.GetMonsters().Count;

            Assert.That(amountInDb + 1, Is.EqualTo(amountInDbAfterInsert));
        }


        [Test]
        public void ShouldDeleteMonsterTest()
        {   
            Monster m = MonsterDB.GetMonsters().ElementAt(1);
            MonsterDB.DeleteMonster(m);
            Assert.That(MonsterDB.GetMonsters(), Has.None.EqualTo(m));
        }
    }
}
