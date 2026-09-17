using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kahnban_ToDo
{
    public partial class MainForm : Form
    {
        // CONSTANTS
        private const string NAME_APP_STATE = "AppState";
        public MainForm()
        {
            InitializeComponent();
            MainForm_Initialize();

            // Load AppState
            string application = Application.ExecutablePath;
            string applicationPath = Path.GetDirectoryName(application);
            AppState? appState = null;

            try
            {
                Controller controller = new();
                appState = controller.ReadObject<AppState>(applicationPath, NAME_APP_STATE);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return;
            }

            if (appState == null) return;

            string path = appState.Path;
            AppStore.path = path;

            // Open Select (Organization) Form
            SelectForm selectForm = new SelectForm();
            FormUtilities.NavigateTo(selectForm);
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
            string path = dialog.SelectedPath;

            AppStore.path = path; // User selected folder path;
            string application = Application.ExecutablePath;
            string applicationPath = Path.GetDirectoryName(application);

            // Save AppState
            AppState appState = new(path);

            try
            {
                Cursor = Cursors.WaitCursor;
                Controller controller = new();
                controller.Save(appState, applicationPath, NAME_APP_STATE);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            // Open Select (Organization) Form
            SelectForm selectForm = new SelectForm();
            FormUtilities.NavigateTo(selectForm);
        }
        #endregion Interaction
    }
}
