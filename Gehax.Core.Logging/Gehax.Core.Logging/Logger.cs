using System;
using System.Diagnostics;
using System.IO;

namespace Gehax.Core.Logging
{
    /// <summary>
    /// Statische Logger-Klasse für Thread-sicheres Logging in Textdateien.
    /// Unterstützt Log-Rotation nach Dateigröße und automatisches Löschen alter Logs.
    /// </summary>
    public static class Logger
    {
        // 1 MB in Bytes
        private const long MB = 1024 * 1024;

        // Lock-Objekt für Thread-Sicherheit beim Schreiben
        private static readonly object _lock = new object();

        // Maximale Anzahl an Tagen, die Logdateien aufbewahrt werden
        private static int _maxLogDays = 42;

        // Maximale Dateigröße einer Logdatei in Bytes (Standard: 5 MB)
        private static long _maxFileSizeBytes = 5 * MB;

        // Pfad-Provider für das Basisverzeichnis
        private static IPathProvider _pathProvider;

        /// <summary>
        /// Optional: Ermöglicht es einer UI, Logeinträge live zu empfangen (z.B. für eine Log-Ansicht).
        /// </summary>
        public static Action<string> OutputAction { get; set; }

        /// <summary>
        /// Konfiguriert den Logger mit Pfad-Provider, Aufbewahrungsdauer und maximaler Dateigröße.
        /// Muss vor der ersten Nutzung aufgerufen werden.
        /// </summary>
        /// <param name="pathProvider">Implementierung von IPathProvider für das Basisverzeichnis.</param>
        /// <param name="maxLogDays">Maximale Anzahl an Tagen, die Logs aufbewahrt werden.</param>
        /// <param name="maxFileSizeMb">Maximale Größe einer Logdatei in MB.</param>
        public static void Configure(IPathProvider pathProvider, int maxLogDays = 42, long maxFileSizeMb = 5)
        {
            _pathProvider = pathProvider ?? throw new ArgumentNullException(nameof(pathProvider));
            _maxLogDays = maxLogDays;
            _maxFileSizeBytes = maxFileSizeMb * MB;

            // Basisverzeichnis sicherstellen
            string logDir = _pathProvider.GetBaseDirectory();
            if (!Directory.Exists(logDir))
                Directory.CreateDirectory(logDir);
        }

        /// <summary>
        /// Gibt das Log-Verzeichnis zurück und legt es ggf. an.
        /// </summary>
        /// <returns>Pfad zum Log-Verzeichnis.</returns>
        private static string GetLogDirectory()
        {
            if (_pathProvider == null)
                throw new InvalidOperationException(
                    "Logger ist nicht konfiguriert. " +
                    "Bitte rufe Logger.Configure(IPathProvider) auf.");

            string baseDir = _pathProvider.GetBaseDirectory();
            string logDir = Path.Combine(baseDir, "Logs");

            if (!Directory.Exists(logDir))
                Directory.CreateDirectory(logDir);

            return logDir;
        }

        /// <summary>
        /// Schreibt eine Lognachricht in die aktuelle Logdatei.
        /// Optional kann eine Exception mitprotokolliert werden.
        /// </summary>
        /// <param name="message">Die zu protokollierende Nachricht.</param>
        /// <param name="ex">Optional: Exception, deren Details geloggt werden.</param>
        public static void Log(string message, Exception ex = null)
        {
            lock (_lock)
            {
                var now = DateTime.Now;
                string logFileName = GetLogFileName(now);
                string logFilePath = Path.Combine(GetLogDirectory(), logFileName);

                // Prüft, ob die aktuelle Logdatei die Maximalgröße überschreitet und rotiert ggf.
                logFilePath = EnsureFileSizeLimit(logFilePath, now);

                // Exception-Details anhängen, falls vorhanden
                string stackInfo = "";
                if (ex != null)
                {
                    stackInfo = $"{Environment.NewLine}Exception: {ex.Message}{Environment.NewLine}{ex.StackTrace}";
                }

                // Ermittelt den Aufrufer (Methode) für den Logeintrag
                var stackFrame = new StackFrame(1, true);
                var method = stackFrame.GetMethod();
                var methodName = method != null ? $"{method.DeclaringType?.FullName}.{method.Name}" : "Unbekannte Methode";

                // Baut die finale Logzeile zusammen
                string logMessage = $"[{now:yyyy-MM-dd HH:mm:ss.fff}] [{methodName}] {message}{stackInfo}";

                // Schreibt die Logzeile in die Datei
                File.AppendAllText(logFilePath, $"{logMessage}{Environment.NewLine}");

                // Optional: Übergibt die Logzeile an die UI, falls registriert
                if (OutputAction != null)
                {
                    OutputAction?.Invoke(logMessage);
                }

                // Löscht alte Logdateien, die die Aufbewahrungsdauer überschreiten
                CleanupOldLogs();
            }
        }

        /// <summary>
        /// Erzeugt den Dateinamen für die Logdatei anhand des Datums und ggf. Index für Rotation.
        /// </summary>
        /// <param name="date">Datum des Logeintrags.</param>
        /// <param name="index">Index für Log-Rotation (Standard: 1).</param>
        /// <returns>Dateiname der Logdatei.</returns>
        private static string GetLogFileName(DateTime date, int index = 1)
        {
            return index == 1
                ? $"Log_{date:yyyyMMdd}.txt"
                : $"Log_{date:yyyyMMdd}_{index}.txt";
        }

        /// <summary>
        /// Prüft, ob die Logdatei die Maximalgröße überschreitet und gibt ggf. einen neuen Dateipfad zurück.
        /// </summary>
        /// <param name="logFilePath">Aktueller Logdateipfad.</param>
        /// <param name="now">Aktuelles Datum/Zeit.</param>
        /// <returns>Pfad zur zu verwendenden Logdatei.</returns>
        private static string EnsureFileSizeLimit(string logFilePath, DateTime now)
        {
            int index = 1;
            // Erhöht den Index, bis eine Datei mit zulässiger Größe gefunden wird
            while (File.Exists(logFilePath) && new FileInfo(logFilePath).Length > _maxFileSizeBytes)
            {
                index++;
                string logFileName = GetLogFileName(now, index);
                logFilePath = Path.Combine(GetLogDirectory(), logFileName);
            }
            return logFilePath;
        }

        /// <summary>
        /// Löscht Logdateien, die älter als die konfigurierte Aufbewahrungsdauer sind.
        /// </summary>
        private static void CleanupOldLogs()
        {
            var files = Directory.GetFiles(GetLogDirectory(), "Log_*.txt");
            var threshold = DateTime.Now.AddDays(-_maxLogDays);

            foreach (var file in files)
            {
                string name = Path.GetFileName(file);
                if (name.Length < 13) continue; // Dateiname zu kurz für Datumsangabe

                // Extrahiert das Datum aus dem Dateinamen
                string datePart = name.Substring(4, 8);
                if (DateTime.TryParseExact(datePart, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out var logDate))
                {
                    if (logDate < threshold)
                        File.Delete(file);      
                }
            }
        }
    }
}
