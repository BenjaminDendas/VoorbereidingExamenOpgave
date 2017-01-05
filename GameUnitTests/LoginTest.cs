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
    public class LoginTest
    {
        [Test]
        public void ShouldLoginUser()
        {
            Account a = new Account();
            Assert.That(a.Login("Test1", "Test1"), Is.True);
        }

        [Test]
        public void ShouldNotLoginUser()
        {
            Account a = new Account();
            Assert.That(a.Login("Ben", "Ben2"), Is.False);
        }

    }
}
