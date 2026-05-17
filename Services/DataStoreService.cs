using System;

using System.IO;

using DeskWise.Models;



namespace DeskWise.Services

{

    // Loads and saves the entire application database from one JSON file.

    public static class DataStoreService

    {

        private const string StoreFileName = "deskwise.json";

        private static DeskWiseDataStore _store = new DeskWiseDataStore();



        // The single in-memory copy of all app data.

        public static DeskWiseDataStore Store

        {

            get { return _store; }

        }



        // Full path to deskwise.json under the Data folder.

        public static string StoreFilePath

        {

            get { return FileService.GetDataPath(StoreFileName); }

        }



        // Reads deskwise.json into memory, or uses an empty store if the file is missing.

        public static void Load()

        {

            _store = FileService.LoadJson(StoreFileName, new DeskWiseDataStore());

            if (_store.Settings == null)

            {

                _store.Settings = new AppSettings();

            }

        }



        // Writes the in-memory store back to deskwise.json.

        public static void Save()

        {

            FileService.SaveJson(StoreFileName, _store);

        }



        // True when the store file already exists on disk.

        public static bool StoreFileExists()

        {

            return File.Exists(StoreFilePath);

        }

    }

}


