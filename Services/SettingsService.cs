using System;

using DeskWise.Models;

using DeskWise;



namespace DeskWise.Services

{

    // Application settings (company, tax, theme, receipt text) loaded from deskwise.json.

    public static class SettingsService

    {

        private static AppSettings _settings = new AppSettings();



        // Current settings snapshot used across the app.

        public static AppSettings Current

        {

            get { return _settings; }

        }



        // Raised after settings are saved so UI can refresh theme.

        public static event EventHandler SettingsChanged;



        // Loads settings from the data store into memory.

        public static void BindFromStore()

        {

            _settings = DataStoreService.Store.Settings ?? new AppSettings();

            if (DataStoreService.Store.Settings == null)

            {

                DataStoreService.Store.Settings = _settings;

            }

        }



        // Copies in-memory settings back into the store model.

        public static void SyncToStore()

        {

            DataStoreService.Store.Settings = _settings;

        }



        // Updates settings, persists, notifies listeners, and reapplies theme on main form.

        public static void Save(AppSettings updated)

        {

            _settings = updated;

            SyncToStore();

            DataStoreService.Save();

            if (SettingsChanged != null)

            {

                SettingsChanged(null, EventArgs.Empty);

            }

            MainShellForm main = GetOpenMainForm();

            if (main != null)

            {

                ThemeService.ApplyToForm(main);

            }

        }



        // Returns the open main shell form if the user is past login.

        private static MainShellForm GetOpenMainForm()

        {

            foreach (System.Windows.Forms.Form openForm in System.Windows.Forms.Application.OpenForms)

            {

                MainShellForm mainForm = openForm as MainShellForm;

                if (mainForm != null) return mainForm;

            }

            return null;

        }

    }

}


