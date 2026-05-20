using System;

using System.Drawing;

using System.Windows.Forms;

using DeskWise.Models;



namespace DeskWise.Services

{

    // Applies Light or Dark theme colours to the main shell and loaded screens.

    public static class ThemeService

    {

        // True when app settings specify the Dark theme.

        public static bool IsDark

        {

            get

            {

                AppSettings settings = SettingsService.Current;

                return settings != null && string.Equals(settings.Theme, "Dark", StringComparison.OrdinalIgnoreCase);

            }

        }



        // Re-applies the current theme starting from the main form downward.

        public static void ApplyToForm(Form mainForm)

        {

            if (mainForm == null) return;



            if (IsDark)

            {

                ApplyDarkTheme(mainForm);

            }

            else

            {

                ApplyLightTheme(mainForm);

            }

        }



        // Sets light palette on the shell and walks all child controls.

        private static void ApplyLightTheme(Control root)

        {

            if (root is MainShellForm)

            {

                root.BackColor = Color.FromArgb(248, 250, 252);

            }

            ApplyRecursive(root, light: true);

        }



        // Sets dark palette on the shell and walks all child controls.

        private static void ApplyDarkTheme(Control root)

        {

            if (root is MainShellForm)

            {

                root.BackColor = Color.FromArgb(15, 23, 42);

            }

            ApplyRecursive(root, light: false);

        }



        // Applies background and foreground colours by control type and name.

        private static void ApplyRecursive(Control control, bool light)

        {

            Color panelBack = light ? Color.White : Color.FromArgb(30, 41, 59);

            Color panelAlt = light ? Color.FromArgb(248, 250, 252) : Color.FromArgb(15, 23, 42);

            Color textPrimary = light ? Color.FromArgb(15, 23, 42) : Color.FromArgb(241, 245, 249);

            Color textMuted = light ? Color.FromArgb(100, 116, 139) : Color.FromArgb(148, 163, 184);

            Color inputBack = light ? Color.White : Color.FromArgb(51, 65, 85);

            Color gridHeader = light ? Color.FromArgb(241, 245, 249) : Color.FromArgb(51, 65, 85);

            Color gridBack = light ? Color.White : Color.FromArgb(30, 41, 59);



            if (control is Panel || control is GroupBox || control is UserControl)

            {

                if (control.Name == "pnlSidebar" || control.Name == "pnlBrand" || control.Name == "flowNav")

                {

                    // Sidebar stays dark in both themes for brand consistency.

                }

                else if (control.Name == "pnlContent")

                {

                    control.BackColor = panelAlt;

                }

                else if (control.Name == "pnlTop")

                {

                    control.BackColor = panelBack;

                }

                else

                {

                    control.BackColor = panelBack;

                }

            }



            if (control is Label label && label.Name != "lblBrand" && label.Name != "lblBrandSub")

            {

                if (label.Name.Contains("Subtitle") || label.ForeColor == Color.FromArgb(100, 116, 139))

                {

                    label.ForeColor = textMuted;

                }

                else if (!(label.Parent != null && label.Parent.Name == "pnlSidebar"))

                {

                    label.ForeColor = textPrimary;

                }

            }



            if (control is TextBox textBox)

            {

                textBox.BackColor = inputBack;

                textBox.ForeColor = textPrimary;

            }



            if (control is ComboBox comboBox)

            {

                comboBox.BackColor = inputBack;

                comboBox.ForeColor = textPrimary;

            }



            if (control is NumericUpDown numericUpDown)

            {

                numericUpDown.BackColor = inputBack;

                numericUpDown.ForeColor = textPrimary;

            }



            if (control is DataGridView grid)

            {

                grid.BackgroundColor = gridBack;

                grid.DefaultCellStyle.BackColor = gridBack;

                grid.DefaultCellStyle.ForeColor = textPrimary;

                grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);

                grid.DefaultCellStyle.SelectionForeColor = Color.White;

                grid.ColumnHeadersDefaultCellStyle.BackColor = gridHeader;

                grid.ColumnHeadersDefaultCellStyle.ForeColor = textPrimary;

                grid.EnableHeadersVisualStyles = false;

            }



            if (control is ListBox listBox)

            {

                listBox.BackColor = inputBack;

                listBox.ForeColor = textPrimary;

            }



            foreach (Control child in control.Controls)

            {

                ApplyRecursive(child, light);

            }

        }

    }

}


