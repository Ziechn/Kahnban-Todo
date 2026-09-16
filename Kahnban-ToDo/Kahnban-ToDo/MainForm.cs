using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kahnban_ToDo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainForm_Initialize();

            Form_Text_Display("ProjectZ - 0.7.0");
        }

        #region Display ============================================
        private void Form_Text_Display(string title)
        {
            Text = title;
        }
        #endregion Display

        #region Initialize =========================================
        private void MainForm_Initialize()
        {
            AppStore.mainPanel = Panel_Main;
        }
        #endregion Initialize

        #region Interaction ========================================
        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_OpenFolder_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Pick a folder.";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.Cancel) return;

            // Selected path is the ApplicationPath
            AppStore.applicationPath = dialog.SelectedPath;

            // Open Select (Organization) Form
            SelectForm selectForm = new SelectForm();
            FormUtilities.NavigateTo(selectForm);
        }
        #endregion Interaction
    }
}
