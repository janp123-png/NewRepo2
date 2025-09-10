using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Tmds.DBus.Protocol;

namespace StammDatenModul.Utility;
public static class SecureDecryptHelper
{
    private static readonly byte[] aesKey = new byte[32]
{
    0x0F, 0x1E, 0x2D, 0x3C, 0x4B, 0x5A, 0x69, 0x78,
    0x87, 0x96, 0xA5, 0xB4, 0xC3, 0xD2, 0xE1, 0xF0,
    0xFF, 0xEE, 0xDD, 0xCC, 0xBB, 0xAA, 0x99, 0x88,
    0x77, 0x66, 0x55, 0x44, 0x33, 0x22, 0x11, 0x00
};
    private static readonly string signature = "ZE76M2jhLpIoN8iGgcv+P5A0RIA1O+VYIAgCbSm7JKc=";
    private static string ReadContainer(string encryptedContainerJson)
    {

        // Container wiederherstellen
        var container = JsonSerializer.Deserialize<EncryptedContainer>(encryptedContainerJson);

        if (container == null)
            throw new InvalidOperationException("Container konnte nicht geladen werden.");

        // JSON entschlüsseln
        byte[] cipherJson = Convert.FromBase64String(container.ciphertextJson);
        byte[] ivJson = Convert.FromBase64String(container.ivJson);
        byte[] plainJson = Decrypt(cipherJson, aesKey, ivJson);
        string jsonContent = Encoding.UTF8.GetString(plainJson);

        // Signatur entschlüsseln
        byte[] cipherSig = Convert.FromBase64String(container.encryptedSignature);
        byte[] ivSig = Convert.FromBase64String(container.ivSig);
        byte[] plainSig = Decrypt(cipherSig, aesKey, ivSig);
        string signatureEntcrypt = Encoding.UTF8.GetString(plainSig);

        if (signature != signatureEntcrypt)
            throw new InvalidOperationException("Die Signatur stimmt nicht überein. Die Daten könnten manipuliert worden sein.");
        return jsonContent;
    }
    private static byte[] Decrypt(byte[] ciphertext, byte[] key, byte[] iv)
    {
        using (var aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using (var decryptor = aes.CreateDecryptor())
            {
                return decryptor.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
            }
        }
    }
    public static string ReadContainerFromFile(string fileName)
    {
        // Nur Dateien mit der Endung ".geConf" akzeptieren
        if (!fileName.EndsWith(".geConf", StringComparison.OrdinalIgnoreCase))
            throw new ArgumentException("Nur Dateien mit der Endung '.geConf' sind erlaubt.", nameof(fileName));

        // Fester Pfad zum Verzeichnis
        string basePath = Path.Combine(AppContext.BaseDirectory, "Config");
        string fullPath = Path.Combine(basePath, fileName);

        if (!File.Exists(fullPath))
            throw new FileNotFoundException($"Die Datei '{fullPath}' wurde nicht gefunden.");

        string encryptedContainerJson = File.ReadAllText(fullPath);


        return ReadContainer(encryptedContainerJson);
    }
}
