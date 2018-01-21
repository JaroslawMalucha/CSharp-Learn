using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class ReportsJob : IWorkflowObject
    {
        private ILogger _logger;

        public ReportsJob(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");
            _logger = logger;
        }
        public void Execute()
        {
            // do stuff
            _logger.LogInfo("Running ReportJob");
        }
    }
}
