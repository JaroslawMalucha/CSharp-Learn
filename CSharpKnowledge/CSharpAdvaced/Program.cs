using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpAdvanced
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StackOverflowPost.testStackPost();
            Stopwatch.testStopwatch();
            Baby.testEntity();

            DbCommand.testDbCommand();
            CSharpAdvanced.Interfaces.WorflowEngine.WorkflowEngine.testWorkflowEngine();

            Delegates.PhotoProcessor.testDelegates();
            LambdaExpressions.LabdaExpressions.testLambdaExpressions();
            EventsAndDelegates.EventsAndDelegates.testEventsAndDelegates();
            ExtensionMethods.ExtensionMethods.testExtensionMethods();
            LINQ.TestingLINQ.testingLINQ();
            NullableTypes.testNullable();
            Dynamics.testDynamics();
            ExceptionHandling.testExceptionHandling();

            //var cus = new Customer
            //{
            //    // OBJECT INITIALIZER:
            //    // fields must be public
            //    id = 123,
            //    firstName = "Blob",
            //    lastName = "Bitter",
            //    companyName = "Passantori LLC"
            //};
        }

    }
}
