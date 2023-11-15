using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BankAccountTesting
{
    [TestFixture]
    class AnotherTestClass
    {
        private Account account;

        [SetUp]
        public void Initialize()
        {
            Console.WriteLine("Setup !");
            account = new Account(10, "testAccount");
        }

        [Test]
        public void VerifyIfConstructorWorksOk(){

            //var account = new Account(10);
            Console.WriteLine("VerifyIfConstructorWorksOk");
            Assert.AreEqual(account.GetBalance, 10);
            Console.WriteLine("--------Constructor method passed---------");
        }

        [Test]
        public void VerifyTransferFundsInSource()
        {
            //arrange
            var account1 = new Account(100, "account1");
            var account2 = new Account(200, "account2");
            Console.Write("\nVerifyTransferFundsInSource\n");
            //act
            account1.TransferFunds(account2, 30);

            //assert
            Assert.AreEqual(account1.GetBalance, 70);
            Console.WriteLine($"--------------{account1.GetName} has the correct balance---------------\n");
        }

        [Test]
        public void VerifyTransferFundsInDestination()
        {

            var account1 = new Account(100, "account1");
            var account2 = new Account(200, "account2");
            Console.Write("\nVerifyTransferFundsInDestination\n");
            account1.TransferFunds(account2, 30);

            Assert.AreEqual(account2.GetBalance, 230);
            Console.WriteLine($"--------------{account2.GetName} has the correct balance---------------\n");
        }
    }
}
