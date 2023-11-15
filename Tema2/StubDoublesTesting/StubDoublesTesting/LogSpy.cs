using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NUnit.Framework.Internal;
using Moq;
using System.Linq.Expressions;
using NPOI.SS.Formula.Functions;

namespace StubDoublesTesting
{
    public class AccountForLogSpy
    {
        public int amount;
        public ClientDummy client;
        Mock<LogSpy> logMock;

        public AccountForLogSpy(int amount, ClientDummy client, Mock<LogSpy> logMock)
        {
            this.amount = amount;
            this.client = client;
            this.logMock = logMock;
        }

    }
    public class LogSpy: ILogger
    {
        List<String> actions = new();
        public void Log(String message)
        {
            actions.Add(MethodBase.GetCurrentMethod().Name + "(" + DateTime.Now + ") "+ message);
        }
        public ISetup SetupMock(Expression<Action<LogSpy>> expression)
        {
            Mock<ILogger> aux = new();
            var setup = aux.Setup(e => expression);
            return (ISetup)setup;
        }
        public void Verify()
        {
            Mock<ILogger> aux = new();
            aux.Verify(setup => true);
        }
        public List<String> GetActions()
        {
            return actions;
        }

        public int GetNumberOfCalls()
        {
            return actions.Count;
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
