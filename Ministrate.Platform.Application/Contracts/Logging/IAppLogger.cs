namespace Ministrate.Platform.Application.Contracts.Logging;

public interface ILoggingService
{
    void LogInformation(string message, params object[] args);
    void LogWarning(string message, params object[] args);
}