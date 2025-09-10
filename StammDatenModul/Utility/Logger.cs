using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StammDatenModul.Utility;
public class Logger
{
    private static int _maxLogFiles = 42; // Maximal 6 Wochen (42 Tage) an Logdateien behalten
    public static void Log(string message, Exception? ex = null)
    {
        string logDirectory = "Logs";
        string logFileName = $"Log_{DateTime.Now:yyyyMMdd}.txt";
        string logFilePath = Path.Combine(logDirectory, logFileName);
        var now = DateTime.Now;

        var stackFrame = new StackFrame(1, true);
        var method = stackFrame.GetMethod();
        var methodName = method != null ? $"{method.DeclaringType?.FullName}.{method.Name}" : "Unbekannte Methode";

        var logMessage = $"[{now:yyyy-MM-dd HH:mm:ss.fff}];[{methodName}];{message}";
        if (!Directory.Exists(logDirectory))
        {
            Directory.CreateDirectory(logDirectory);
        }

        // Aufräumen: alte Dateien (> 6 Wochen) löschen
        var cutoffDate = DateTime.Now.AddDays(_maxLogFiles); 
        foreach (var file in Directory.GetFiles(logDirectory, "Log_*.txt"))
        {
            try
            {
                var creationTime = File.GetCreationTime(file);
                if (creationTime < cutoffDate)
                {
                    File.Delete(file);
                }
            }
            catch (Exception cleanupEx)
            {
                Console.WriteLine($"Fehler beim Löschen von {file}: {cleanupEx.Message}");
            }
        }

        // Logfile sicherstellen
        if (!File.Exists(logFilePath))
        {
            using (File.Create(logFilePath)) { }
        }

        // Schreiben
        File.AppendAllText(logFilePath, $"{logMessage}{Environment.NewLine}");
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }

}
