using System.Diagnostics;

namespace Kahnban_ToDo
{
    public partial class FileBrowseForm : Form
    {
        private Project? _project;
        private long _projectId;

        public FileBrowseForm(long projectId)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            _projectId = projectId;
            Project_Load(projectId);

            Button_Submit_State();
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
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            string location = TextBox_Location.Text.Trim();
            bool hasLocation = string.IsNullOrEmpty(location) == false;

            if (hasLocation)
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

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            string location = TextBox_Location.Text.Trim();
            Image_Copy(location);
            Project_Save(location);
            Close();
        }

        private void Button_Submit_State(bool isEnabled = false)
        {
            Button_Submit.Enabled = isEnabled;
        }
        #endregion Interaction: Button

        #region Interaction: TextBox ===============================
        private void TextBox_Location_TextChanged(object sender, EventArgs e)
        {
            string location = TextBox_Location.Text.Trim();
            bool hasLocation = string.IsNullOrEmpty(location) == false;
            Button_Submit_State(hasLocation);
        }
        #endregion Interaction: TextBox

        #region Load ===============================================
        private void Project_Load(long projectId)
        {
            Controller controller = new();
            string organizationPath = AppStore.organizationPath;
            try
            {
                _project = controller.ReadObject<Project>(organizationPath, projectId);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            if (_project == null) return;

            string projectPath = Path.Combine(organizationPath, projectId.ToString());
            AppStore.projectPath = projectPath;
            AppStore.project = _project;
        }
        #endregion Load

        #region Logic ==============================================
        private void Image_Copy(string originalFileLocation)
        {
            string? originalFilePath = Path.GetDirectoryName(originalFileLocation);
            string? fileName = Path.GetFileName(originalFileLocation);

            Controller controller = new();

            try
            {
                controller.CopyFile(originalFileLocation, AppStore.projectPath, fileName);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }

        private void Project_Save(string originalFileLocation)
        {
            string? fileName = Path.GetFileName(originalFileLocation);
            string newFileLocation = Path.Combine(AppStore.projectPath, fileName);

            if (_project == null) return;
            _project.ImageFileLocation = newFileLocation;

            Controller controller = new();
            controller.Save(_project, AppStore.organizationPath, _projectId);
        }
        #endregion Logic

        #region Populate ===========================================
        private void TextBox_Location_Populate(string location)
        {
            TextBox_Location.Text = location;
        }
        #endregion Populate
    }
}
