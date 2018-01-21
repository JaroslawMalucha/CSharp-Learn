using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class WorkflowEngine
    {
        private IWorkflowObject _activity;

        public WorkflowEngine(IWorkflowObject activity)
        {
            if (activity == null)
                throw new Exception();
            _activity = activity;
        }

        public void Run()
        {
            _activity.Execute();
        }


        public static void testWorkflowEngine()
        {
            var cLogger = new ConsoleLogger();
            var fLogger = new FileLogger(@"testFileLogger.txt");
            var repJobs = new ReportsJob(fLogger);
            var mailJobs = new MailingJob(cLogger);
            var engine = new WorkflowEngine(repJobs);
            engine.Run();
            engine.Run();
            engine = new WorkflowEngine(mailJobs);
            engine.Run();
            cLogger.LogInfo("Fnished all jobs");
            fLogger.LogInfo("Fnished all jobs");   
        }
    }
}
