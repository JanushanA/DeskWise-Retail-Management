using System;
using System.Windows.Forms;
using DeskWise.Forms;
using DeskWise.Services;

namespace DeskWise
{
    // Application entry point: load data, show login, then main shell until the user exits.
    internal static class Program
    {
        // Starts the WinForms app and loops between login and main window when the user logs out.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load JSON data (or seed default data on first run) before any UI shows.
            AppState.Initialize();

            // Login -> Main -> Logout loops back to Login.
            // MainShellForm returns DialogResult.Retry when the user clicks "Logout" so we re-show the login.
            while (true)
            {
                using (LoginForm login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        return; // user closed the login window - exit the app
                    }
                }

                using (MainShellForm main = new MainShellForm())
                {
                    DialogResult result = main.ShowDialog();
                    if (result != DialogResult.Retry)
                    {
                        return; // user closed or quit the main form - exit
                    }
                    AppState.Logout();
                }
            }
        }
    }
}
