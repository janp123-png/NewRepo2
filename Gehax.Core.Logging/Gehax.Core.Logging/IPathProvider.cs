using System;
using System.Collections.Generic;
using System.Text;

namespace Gehax.Core.Logging
{
    /// <summary>
    /// Liefert das Basisverzeichnis der Anwendung, in dem der Logger einen Unterordner "Logs" anlegt.
    /// 
    /// Implementierungsvorschläge für gängige Plattformen:
    /// - **Windows**: AppDomain.CurrentDomain.BaseDirectory
    /// - **Linux**: AppContext.BaseDirectory
    /// - **Android (Uno/Maui)**: Android.App.Application.Context.FilesDir.AbsolutePath
    /// - **iOS (Uno/Maui)**: Foundation.NSFileManager.DefaultManager.GetUrls(Foundation.NSSearchPathDirectory.DocumentDirectory, Foundation.NSSearchPathDomain.User)[0].Path
    ///
    /// Der Nutzer muss nur diesen Basisordner zurückgeben; die Bibliothek erstellt automatisch den Unterordner "Logs".
    /// </summary>
    public interface IPathProvider
    {
        /// <summary>
        /// Gibt das Basisverzeichnis der Anwendung zurück, in dem der Logger einen Unterordner "Logs" erstellt.
        /// 
        /// Hinweise für gängige Plattformen:
        /// - Windows: AppDomain.CurrentDomain.BaseDirectory
        /// - Linux: AppContext.BaseDirectory
        /// - Android (Uno/Maui): Android.App.Application.Context.FilesDir.AbsolutePath
        /// - iOS (Uno/Maui): Foundation.NSFileManager.DefaultManager
        ///   .GetUrls(Foundation.NSSearchPathDirectory.DocumentDirectory, Foundation.NSSearchPathDomain.User)[0].Path
        /// 
        /// Der Logger erstellt automatisch den Unterordner "Logs", daher muss nur das Basisverzeichnis zurückgegeben werden.
        /// </summary>
        /// <returns>Vollständiger Pfad zum Basisverzeichnis der Anwendung.</returns>

        string GetBaseDirectory();
    }
}
