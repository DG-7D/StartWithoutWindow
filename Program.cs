using System.Diagnostics;
namespace StartWithoutWindow;

static class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Environment.Exit(1);
        }
        try
        {
            DirectoryInfo baseDir = new(AppDomain.CurrentDomain.BaseDirectory);
            FileInfo targetExe = new(Path.Combine(baseDir.FullName ?? "", args[0]));
            ProcessStartInfo process = new()
            {
                Arguments = string.Join(' ', args.Skip(1)),
                CreateNoWindow = true,
                FileName = targetExe.FullName,
                UseShellExecute = true, // falseだとGUIアプリケーションが非表示にならない？
                WindowStyle = ProcessWindowStyle.Hidden,
                WorkingDirectory = targetExe.DirectoryName,
            };
            Process.Start(process);
        }
        catch (Exception)
        {
            Environment.Exit(1);
        }
    }
}