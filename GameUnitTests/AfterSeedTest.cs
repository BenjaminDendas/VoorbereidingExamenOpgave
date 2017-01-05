using Ado3LagenMonster;
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
    public class AfterSeedTest
    {
        [Test]
        public void ShouldHave5AccountsTest()
        {
            List<Account> accounts = new List<Account>();
            using (var context = new GameContext())
            {
                accounts = context.Accounts.ToList();
            }

            Assert.That(accounts.Count, Is.EqualTo(5));
        }
       

        [Test]
        public void ShouldHave3Characters()
        {
            List<Character> characters = new List<Character>();
            using (var context = new GameContext())
            {
                characters = context.Characters.ToList();
            }
            Assert.That(characters.Count, Is.EqualTo(3));
        }


    }
}
