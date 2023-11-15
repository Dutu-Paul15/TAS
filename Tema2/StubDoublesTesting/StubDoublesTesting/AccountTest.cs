using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace StubDoublesTesting
{
//    [TestFixture]
//    public class AccountTest
//    {
//        Account? source;
//        Account? destination;

//        [SetUp]
//        public void InitAccount()
//        {
//            //arrange
//            source = new Account();
//            source.Deposit(200.00F);
//            destination = new Account();
//            destination.Deposit(150.00F);
//        }

//        [Test]
//        [Category("pass")]
//        public void TransferFunds()
//        {
//            //act
//            source.TransferFunds(destination, 100.00F);

//            //assert
//            Assert.AreEqual(250.00F, destination.GetBalance);
//            Assert.AreEqual(100.00F, source.GetBalance);
//        }

//        [Test, Category("pass")]
//        [TestCase(200, 0, 78)]
//        [TestCase(200, 0, 189)]
//        [TestCase(200, 0, 1)]
//        public void TransferMinFunds(int a, int b, int c)
//        {

//            Account source = new();
//            source.Deposit(a);
//            Account destination = new();
//            destination.Deposit(b);

//            source.TransferMinFunds(destination, c);
//            Assert.AreEqual(c, destination.GetBalance);
//        }

//        [Test, ExpectedException(typeof(NotEnoughFundsException))]
//        [Category("fail")]
//        [TestCase(200, 150, 190)]
//        [TestCase(200, 150, -1)]
//        [TestCase(200, 150, -142)]
//        [TestCase(200, 150, 345)]

//        public void TransferMinFundsFail(int a, int b, int c)
//        {
//            Account source = new();
//            source.Deposit(a);
//            Account destination = new();
//            destination.Deposit(b);

//            destination = source.TransferMinFunds(destination, c);

//        }

//        [Test, ExpectedException(typeof(NotEnoughFundsException))]
//        [Category("fail")]
//        [Combinatorial]
//        public void TransferMinFundsFailAll([Values(200, 500)] int a, [Values(0, 20)] int b, [Values(190, 345)] int c)
//        {
//            Account source = new();
//            source.Deposit(a);
//            Account destination = new();
//            destination.Deposit(b);

//            destination = source.TransferMinFunds(destination, c);
//        }

//    }

public class NotEnoughFundsException : ApplicationException
{
    public static string ApplicationException(String message)
    {
        return message;
    }
}
}