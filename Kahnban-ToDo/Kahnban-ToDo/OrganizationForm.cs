using System.Diagnostics;
using System.Text.Json;

namespace Kahnban_ToDo
{
    public partial class OrganizationForm : Form
    {
        // CONSTANTS - DataGridView Columns
        private const string COLUMN_DESCRIPTION = "description";
        private const string COLUMN_ID = "id";
        private const string COLUMN_PROJECT = "project";
        private const string COLUMN_STATUS = "status";
        private const string COLUMN_VERSION = "version";

        // CONSTANTS - DataGridView Headers
        private const string HEADER_DESCRIPTION = "Description";
        private const string HEADER_ID = "ID";
        private const string HEADER_PROJECT = "Project";
        private const string HEADER_STATUS = "Status";
        private const string HEADER_VERSION = "Version";

        // CONSTANTS - DataGridView Properties
        private const int PROPERTY_WIDTH_PROJECT = 250;
        private const int PROPERTY_WIDTH_STATUS = 100;
        private const int PROPERTY_WIDTH_VERSION = 100;

        public OrganizationForm()
        {
            InitializeComponent();
            DataGridView_Projects_Intialize();

            Label_Organization_Display();
            Projects_Load();

            // Reset the store
            AppStore.project = null;
            AppStore.projectFilterCategory = -1;
            AppStore.projectFilterSearch = "";
            AppStore.projectFilterStatus = -1;
        }

        #region Display ============================================
        private void Label_Organization_Display()
        {
            Label_Organization.Text = AppStore.organization;
        }
        #endregion Display

        #region Initialize =========================================
        private void DataGridView_Projects_Intialize()
        {
            DataGridView_Projects.Columns.Clear();

            // Id Column
            DataGridView_Projects.Columns.Add(COLUMN_ID, HEADER_ID);

            // Project Column
            DataGridViewColumn projectColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_PROJECT,
                Name = COLUMN_PROJECT,
                SortMode = DataGridViewColumnSortMode.Automatic,
                Width = PROPERTY_WIDTH_PROJECT
            };

            DataGridView_Projects.Columns.Add(projectColumn);

            // Description Column
            DataGridView_Projects.Columns.Add(COLUMN_DESCRIPTION, HEADER_DESCRIPTION);

            // Status Column
            DataGridViewColumn statusColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_STATUS,
                Name = COLUMN_STATUS,
                SortMode = DataGridViewColumnSortMode.Automatic,
                Width = PROPERTY_WIDTH_STATUS
            };

            DataGridView_Projects.Columns.Add(statusColumn);

            // Version Column
            DataGridViewColumn versionColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_VERSION,
                Name = COLUMN_VERSION,
                SortMode = DataGridViewColumnSortMode.Automatic,
                Width = PROPERTY_WIDTH_VERSION
            };

            DataGridView_Projects.Columns.Add(versionColumn);

            // Formatting
            DataGridView_Projects.Columns[COLUMN_ID]?.Visible = false;
        }
        #endregion Initialize

        #region Interaction ========================================
        private void Button_Back_Click(object sender, EventArgs e)
        {
            StartForm selectForm = new StartForm();
            FormUtilities.NavigateTo(selectForm);
        }

        private void Button_Project_Add_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm();
            projectForm.ShowDialog();

            Projects_Load();
        }

        private void Button_Project_Delete_Click(object sender, EventArgs e)
        {
            int rowIndex = DataGridView_Projects.SelectedCells[0].RowIndex;
            DataGridViewRow row = DataGridView_Projects.Rows[rowIndex];
            if (row == null) return;

            long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);
            string name = DataGridViewUtilities.GetCellValue_String(row, COLUMN_PROJECT);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {name} and all related user stories?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.No) return;

            Controller controller = new();
            try
            {
                controller.DeleteProject(id);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            Projects_Load();
            Button_Project_Delete_State();
            Button_Project_Edit_State();
        }

        private void Button_Project_Delete_State(int rowIndex = -1)
        {
            if (rowIndex < 0)
            {
                Button_Project_Delete.Enabled = false;
                return;
            }

            DataGridViewRow row = DataGridView_Projects.Rows[rowIndex];
            if (row == null) return;

            long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);
            bool isIdValid = id > 0;

            Button_Project_Delete.Enabled = isIdValid;
        }

        private void Button_Project_Edit_Click(object sender, EventArgs e)
        {
            int rowIndex = DataGridView_Projects.SelectedCells[0].RowIndex;
            DataGridViewRow row = DataGridView_Projects.Rows[rowIndex];
            if (row == null) return;

            long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);

            ProjectForm projectForm = new ProjectForm(id);
            projectForm.ShowDialog();

            Projects_Load();
            Button_Project_Delete_State();
            Button_Project_Edit_State();
        }

        private void Button_Project_Edit_State(int rowIndex = -1)
        {
            if (rowIndex < 0)
            {
                Button_Project_Edit.Enabled = false;
                return;
            }

            DataGridViewRow row = DataGridView_Projects.Rows[rowIndex];
            if (row == null) return;

            long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);
            bool isIdValid = id > 0;

            Button_Project_Edit.Enabled = isIdValid;
        }

        private void DataGridView_Projects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            Button_Project_Delete_State(rowIndex);
            Button_Project_Edit_State(rowIndex);
        }

        private void DataGridView_Projects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            DataGridViewRow row = DataGridView_Projects.Rows[rowIndex];
            if (row == null) return;

            (bool isIdValid, long id) = CellValue_Long_Validate(row, COLUMN_ID);
            if (isIdValid == false) return;

            Project? project = null;
            Controller controller = new();

            string organizationPath = AppStore.organizationPath;

            try
            {
                project = controller.ReadObject<Project>(organizationPath, id);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            AppStore.project = project;

            ProjectDetailsForm projectform = new ProjectDetailsForm();
            FormUtilities.NavigateTo(projectform);
        }

        private void LinkLabel_Start_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller controller = new();
            controller.ResetStore();

            StartForm startForm = new();
            FormUtilities.NavigateTo(startForm);
        }
        #endregion Interaction

        #region Load ===============================================
        private void Projects_Load()
        {
            string organizationPath = AppStore.organizationPath;
            List<Project> projects = new List<Project>();

            try
            {
                string[] jsonFiles = Directory.GetFiles(organizationPath, "*.json");

                foreach (string jsonFile in jsonFiles)
                {
                    string json = File.ReadAllText(jsonFile);
                    Project? project = JsonSerializer.Deserialize<Project>(json);
                    if (project == null) continue;

                    projects.Add(project);
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            DataGridView_Projects_Populate(projects);
        }
        #endregion Load

        #region Populate: DataGridView =============================
        private void DataGridView_Projects_Populate(List<Project> projects)
        {
            DataGridView_Projects.Rows.Clear();

            foreach (Project project in projects)
            {
                DataGridView_Projects.Rows.Add(
                project.Id,
                project.Name,
                project.Description,
                project.Status,
                project.Version
                );
            }
        }
        #endregion Populate: DataGridView

        #region Validation =========================================
        private (bool, long) CellValue_Long_Validate(DataGridViewRow row, string columnName)
        {
            long cellValue = DataGridViewUtilities.GetCellValue_Long(row, columnName);
            bool isValid = cellValue > 0;
            return (isValid, cellValue);
        }
        #endregion Validation
    }
}
