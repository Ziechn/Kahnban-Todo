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
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            Button_Submit_State();
        }

        public ProjectForm(long id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            // Load project

            Button_Submit_State();
        }

        #region Interaction ========================================
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            string name = TextBox_Name.Text;
            string decription = RichTextBox_Description.Text;

            bool hasName = string.IsNullOrEmpty(name) == false;
            bool hasDescription = string.IsNullOrEmpty(decription) == false;

            bool hasUnsavedChanges = hasName || hasDescription;

            if (hasUnsavedChanges)
            {
                DialogResult result = MessageBox.Show(
                    "Discard unsaved changes?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.No) return;
            }

            Close();
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            string name = TextBox_Name.Text.Trim();
            string description = RichTextBox_Description.Text;

            Controller controller = new();
            long id = controller.GenerateId();

            string organization = AppStore.organization;
            string organizationPath = AppStore.organizationPath;

            Project project = new Project(
                id,
                name,
                description,
                organization
                );

            try
            {
                controller.CreateDirectory(organizationPath, id);
                controller.Save(project, organizationPath, id);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            Close();
        }

        private void Button_Submit_State()
        {
            string name = TextBox_Name.Text.Trim();
            string description = RichTextBox_Description.Text.Trim();

            bool hasName = string.IsNullOrEmpty(name) == false;
            bool hasDescription = string.IsNullOrEmpty(description) == false;

            bool isEnabled = hasName && hasDescription;

            Button_Submit.Enabled = isEnabled;
        }

        private void RichTextBox_Description_KeyUp(object sender, KeyEventArgs e)
        {
            Button_Submit_State();
        }

        private void TextBox_Name_KeyUp(object sender, KeyEventArgs e)
        {
            Button_Submit_State();
        }
        #endregion Interaction
    }
}
