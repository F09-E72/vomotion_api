namespace Vomotion.Domain.Settings;

public static class EnvironmentVariables
{
    public static string? ConnectionString
    {
        get
        {
            return Environment.GetEnvironmentVariable("VOMOTION_API_ConnectionString");
        }
    }
}
