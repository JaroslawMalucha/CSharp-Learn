namespace CSharpAdvanced
{
    interface ILogger
    {
        void LogError(string errorMessage);
        void LogInfo(string infoMessage);
    }
}