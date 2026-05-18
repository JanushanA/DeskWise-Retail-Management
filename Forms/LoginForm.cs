using System;
using System.Drawing;
using System.Windows.Forms;
using DeskWise.Models;
using DeskWise.Services;

namespace DeskWise.Forms
{
    // Authenticates against users.json via AuthService. On success the chosen User is
    // stored in AppState.CurrentUser and DialogResult.OK is returned so Program.Main
    // can open the main shell. Closing the form without success exits the app.
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Attempt login with the entered credentials and open the shell on success.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ShowStatus("Please enter both username and password.");
                return;
            }

            User user = AuthService.Login(username, password);
            if (user == null)
            {
                ShowStatus("Invalid username or password.");
                txtPassword.SelectAll();
                txtPassword.Focus();
                return;
            }

            AppState.CurrentUser = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Show an error message in the status label below the form fields.
        private void ShowStatus(string message)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.FromArgb(220, 38, 38);
        }
    }
}
