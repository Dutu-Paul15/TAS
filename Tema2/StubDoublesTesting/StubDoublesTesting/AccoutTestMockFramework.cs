using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Moq;
using System.Xml;
using System.Linq;
using NUnit.Framework.Internal;
using TeixeiraSoftware.Finance;

namespace StubDoublesTesting
{

    [TestFixture]
    public class AccountTestMockFramework
    {
        [SetUp]
        public void InitAccount()
        {
            //arrange
        }
        [Test]
        [Category("pass")]
        public void TransferFunds()
        {

            //arrange the MockObject
            var logMock = new LogSpy();

            //arrange SUT
            var source = new Account(200, "client_source", logMock);
            var destination = new Account(150, "client_destination", logMock);

            //set mocked logger expectations

            Assert.AreEqual(2, logMock.GetNumberOfCalls());
            //act

            source.TransferFunds(destination, 100.00F);
            Assert.AreEqual(5, logMock.GetNumberOfCalls());

            //assert 
            Assert.AreEqual(250.00F, destination.GetBalance);
            Assert.AreEqual(100.00F, source.GetBalance);

            //verify
        }

        [Test]
        public void TransferFundsFromEurAmount_MockFramework_ShouldWork()
        {
            //arrange
            var logMock = new LogSpy();
            var source = new Account(200, "source", logMock);
            var destination = new Account(150, "destination", logMock);

            var rateEurRon = 4.9F;
            CurrencyConvertorStub currencyConvertorStub = new(rateEurRon);
            var convertorMock = new Mock<ICurrencyConvertor>() { CallBase = true};
            
            convertorMock.Setup(_ => _.EurToRon(20.00F, rateEurRon)); // set mock to act as a TestDouble Stub - gives IndirectInputs to the SUT
            //act
            source.TransferFundsFromEurAmount_Version3(destination, source, 20.00F, rateEurRon, convertorMock.Object);

            //assert
            Assert.AreEqual(150.00F + (20 * rateEurRon), destination.GetBalance);
            Assert.AreEqual(200.00F - (20 * rateEurRon), source.GetBalance);

            convertorMock.Verify(_ => _.EurToRon(20, rateEurRon), Times.Once()); //verify behavior 
        }
    }
}