using NUnit.Framework.Internal;
using NUnitLite;
using StubDoublesTesting;
using System.Text;

namespace StubDoublesTesting
{
    public class Program
    {
        static public int Main(string[] args)
        {
            // Run the tests and return the exit code
            return new AutoRun(typeof(AccountTestMockFramework).Assembly).Execute(args);
        }
    }
}