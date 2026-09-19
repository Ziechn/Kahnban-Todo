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
        private Project? _project;

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

            _project = LoadProject(id);
            if (_project == null) return;

            RichTextBox_Description_Populate();
            TextBox_Name_Populate();

            Button_Submit_State();
        }

        #region Interaction ========================================
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            string name = TextBox_Name.Text;
            string description = RichTextBox_Description.Text;

            bool hasDescription = false;
            bool hasName = false;
            bool updateDescription = false;
            bool updateName = false;

            if (_project != null)
            {
                string nameToUpdate = _project.Name;
                string descriptionToUpdate = _project.Description;

                updateDescription = description.Equals(descriptionToUpdate) == false;
                updateName = name.Equals(nameToUpdate) == false;
            }
            else
            {
                hasDescription = string.IsNullOrEmpty(description) == false;
                hasName = string.IsNullOrEmpty(name) == false;
            }

            bool hasUnsavedChanges = hasName || hasDescription || updateDescription || updateName;

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
            long id = -1;
            string organization = AppStore.organization;

            Controller controller = new();
            Project? project = null;

            if (_project != null)
            {
                project = _project;
                id = _project.Id;
            }
            else
            {
                project = new Project();

                id = controller.GenerateId();
                project.Id = id;
            }

            if (project == null) return;
            
            string description = RichTextBox_Description.Text;
            project.Description = description;

            string name = TextBox_Name.Text.Trim();
            project.Name = name;

            string organizationPath = AppStore.organizationPath;
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

        #region Load ===============================================
        private Project? LoadProject(long id)
        {
            string organizationPath = AppStore.organizationPath;
            Controller controller = new();

            try
            {
                return controller.ReadObject<Project>(organizationPath, id);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return null;
            }
        }
        #endregion Load

        #region Populate ===========================================
        private void RichTextBox_Description_Populate()
        {
            if (_project == null) return;
            RichTextBox_Description.Text = _project.Description;
        }

        private void TextBox_Name_Populate()
        {
            if (_project == null) return;
            TextBox_Name.Text = _project.Name;
        }
        #endregion Populate
    }
}
