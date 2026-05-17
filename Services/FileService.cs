using System;
using System.IO;
using System.Text.Json;

namespace DeskWise.Services
{
    // Centralised, defensive JSON I/O. All persistence in DeskWise goes through here so
    // the file root, error handling and serializer options live in exactly one place.
    public static class FileService
    {
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        // Root folder for JSON data files next to the executable.
        public static string DataDirectory
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data"); }
        }

        // Folder where text receipts are saved.
        public static string ReceiptsDirectory
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Receipts"); }
        }

        // Folder reserved for future backup exports.
        public static string BackupsDirectory
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups"); }
        }

        // Ensures Data exists and returns the full path for a data file name.
        public static string GetDataPath(string fileName)
        {
            EnsureDirectory(DataDirectory);
            return Path.Combine(DataDirectory, fileName);
        }

        // Creates the directory when it does not exist yet.
        public static void EnsureDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        // Deserializes JSON from Data folder or returns fallback on missing or bad file.
        public static T LoadJson<T>(string fileName, T fallback)
        {
            try
            {
                string fullPath = GetDataPath(fileName);
                if (!File.Exists(fullPath))
                {
                    return fallback;
                }

                string json = File.ReadAllText(fullPath);
                if (string.IsNullOrWhiteSpace(json))
                {
                    return fallback;
                }

                T data = JsonSerializer.Deserialize<T>(json, JsonOptions);
                return data == null ? fallback : data;
            }
            catch (Exception)
            {
                // A corrupt JSON file shouldn't crash the app - fall back to defaults.
                return fallback;
            }
        }

        // Serializes and writes JSON to the Data folder; returns false on failure.
        public static bool SaveJson<T>(string fileName, T data)
        {
            try
            {
                string fullPath = GetDataPath(fileName);
                string json = JsonSerializer.Serialize(data, JsonOptions);
                File.WriteAllText(fullPath, json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Writes plain text to any path, creating parent folders when needed.
        public static void WriteText(string fullPath, string contents)
        {
            try
            {
                string folder = Path.GetDirectoryName(fullPath);
                if (!string.IsNullOrEmpty(folder)) EnsureDirectory(folder);
                File.WriteAllText(fullPath, contents);
            }
            catch (Exception)
            {
                // Suppress write errors here - callers can decide what to do via try/catch around the call.
            }
        }
    }
}
