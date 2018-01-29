using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Interfaces.WorflowEngine
{
    class MailingJob : IWorkflowObject
    {
        private ILogger _logger;

        public MailingJob(ILogger logger)
        {
            if (logger == null)
                throw new ArgumentNullException("logger");
            _logger = logger;
        }
        public void Execute()
        {
            try
            {
                // prep some mails and send them
                _logger.LogInfo("Sending Mail");
                throw new Exception();
            }
            catch (Exception)
            {
                _logger.LogError("Sending Mail Failed");
            }
        }
    }
}
