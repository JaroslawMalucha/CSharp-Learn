namespace CSharpAdvanced.Interfaces.WorflowEngine
{
    interface ILogger
    {
        void LogError(string errorMessage);
        void LogInfo(string infoMessage);
    }
}