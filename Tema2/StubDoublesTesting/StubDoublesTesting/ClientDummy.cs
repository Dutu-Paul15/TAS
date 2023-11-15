using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubDoublesTesting
{
    public class ClientDummy : IClient
    {
        public Handle Handle => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public int AddBrokers(string brokers)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SetSaslCredentials(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
