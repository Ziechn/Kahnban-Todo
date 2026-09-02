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
    public partial class FileReferenceForm : Form
    {
        // Local Memory
        private long _userStoryId = -1;

        public FileReferenceForm(long userStoryId)
        {
            InitializeComponent();
            _userStoryId = userStoryId;

            Button_Save_State();
        }

        #region Interaction: Button ================================
        private void Button_Browse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select a file",
                Filter = "All Files (*.*)|*.*",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string fileName = openFileDialog.FileName;
            TextBox_Location_Populate(fileName);
            Button_Save_State();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            string title = TextBox_Title.Text.Trim();
            string location = TextBox_Location.Text.Trim();

            bool hasTitle = title.Equals("") == false;
            bool hasLocation = Location.Equals("") == false;

            bool hasUnsavedChanges = hasTitle || hasLocation;

            if (hasUnsavedChanges)
            {
                string message = "Discard unsaved changes?";
                DialogResult result = MessageBox.Show(
                    message,
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.No) return;
            }

            Close();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string title = TextBox_Title.Text.Trim();
            string location = TextBox_Location.Text.Trim();

            string? originalFilePath = Path.GetDirectoryName(location);
            string? fileName = Path.GetFileName(location);

            Controller controller = new();
            FileReference? fileReference = new FileReference();

            long id = controller.CreateId();
            fileReference.Id = id;
            fileReference.Title = title;
            fileReference.FileName = fileName;

            string organizationPath = AppStore.organizationPath;
            string projectId = AppStore.project?.Id.ToString() ?? "";
            string userStoryId = _userStoryId.ToString();

            string filePath = Path.Combine(organizationPath, projectId, userStoryId);

            try
            {
                controller.Save(fileReference, filePath, id, typeof(Reference));
                controller.CopyFile(location, filePath, fileName);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            Close();
        }

        private void Button_Save_State()
        {
            string title = TextBox_Title.Text.Trim();
            string location = TextBox_Location.Text.Trim();

            bool hasTitle = title.Equals("") == false;
            bool hasLocation = Location.Equals("") == false;

            bool isEnabled = hasTitle && hasLocation;
            Button_Save.Enabled = isEnabled;
        }
        #endregion Interaction: Button

        #region Interaction: Textbox ===============================
        private void TextBox_Location_KeyUp(object sender, KeyEventArgs e)
        {
            Button_Save_State();
        }

        private void TextBox_Title_KeyUp(object sender, KeyEventArgs e)
        {
            Button_Save_State();
        }
        #endregion Interaction: TextBox

        #region Populate ===========================================
        private void TextBox_Location_Populate(string text)
        {
            TextBox_Location.Text = text;
        }
        #endregion Populate
    }
}
