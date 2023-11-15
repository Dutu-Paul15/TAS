using NUnit.Framework.Internal;
using NUnitLite;
using System.Text;

namespace BankAccountTesting
{
    public class Program
    {
        static public int Main(string[] args)
        {
            //Console.WriteLine("TestClass methods: \n");
            //AnotherTestClass anotherTestClass = new();
            //anotherTestClass.Initialize();
            //anotherTestClass.VerifyIfConstructorWorksOk();
            //anotherTestClass.VerifyTransferFundsInSource();
            //anotherTestClass.VerifyTransferFundsInDestination();

            // Run the tests and return the exit code
            return new AutoRun(typeof(AccountTest).Assembly).Execute(args);
        }
    }
}