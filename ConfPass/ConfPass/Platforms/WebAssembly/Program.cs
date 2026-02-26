namespace ConfPass;

public class Program
{
    private static App? _app;

    public static async Task Main(string[] args)
    {
        Microsoft.UI.Xaml.Application.Start(_ =>
        {
            _app = new App();
        });

        await Task.CompletedTask;
    }
}
