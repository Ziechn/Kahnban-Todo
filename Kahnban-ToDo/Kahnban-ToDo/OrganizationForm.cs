using System.Data.Common;
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

        // CONSTANTS - DataGridView Headers
        private const string HEADER_DESCRIPTION = "Description";
        private const string HEADER_ID = "ID";
        private const string HEADER_PROJECT = "Project";

        // CONSTANTS - DataGridView Properties
        private const int PROPERTY_WIDTH_PROJECT = 250;

        public OrganizationForm()
        {
            InitializeComponent();
            DataGridView_Projects_Intialize();

            Label_Organization_Display();
            Projects_Load();

            AppStore.project = null;
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
                Width = PROPERTY_WIDTH_PROJECT
            };

            DataGridView_Projects.Columns.Add(projectColumn);

            // Description Column
            DataGridView_Projects.Columns.Add(COLUMN_DESCRIPTION, HEADER_DESCRIPTION);

            // Formatting
            DataGridView_Projects.Columns[COLUMN_ID]?.Visible = false;
        }
        #endregion Initialize

        #region Interaction: DataGridView ==========================
        private void DataGridView_Projects_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Projects_Save();
        }

        private void DataGridView_Projects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            DataGridViewRow row = DataGridView_Projects.Rows[rowIndex];
            if (row == null) return;

            (bool isIdValid, long id) = CellValue_Long_Validate(row, COLUMN_ID);
            if (isIdValid == false) return;

            string projectName = DataGridViewUtilities.GetCellValue_String(row, COLUMN_PROJECT);
            string description = DataGridViewUtilities.GetCellValue_String(row, COLUMN_DESCRIPTION);

            Project project = new(
                id,
                projectName,
                description,
                AppStore.organization
                );

            AppStore.project = project;

            ProjectForm projectform = new ProjectForm();
            FormUtilities.NavigateTo(projectform);
        }

        private void DataGridView_Projects_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row == null) return;
            DataGridViewRow row = e.Row;

            (bool isValid, long id) = CellValue_Long_Validate(row, COLUMN_ID);
            if (isValid == false) return;

            string projectName = DataGridViewUtilities.GetCellValue_String(row, COLUMN_PROJECT);
            string message = $"Are you sure you want to delete project: {projectName}?";

            DialogResult result = MessageBox.Show(
                message,
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.No) return;

            string fileName = $"{id}.json";
            string path = Path.Combine(AppStore.organizationPath, fileName);

            File.Delete(path);
        }
        #endregion Interaction: DataGridView

        #region Load ===============================================
        private void Projects_Load()
        {
            try
            {
                string[] jsonFiles = Directory.GetFiles(AppStore.organizationPath, "*.json");

                foreach (string jsonFile in jsonFiles)
                {
                    string json = File.ReadAllText(jsonFile);
                    Project? project = JsonSerializer.Deserialize<Project>(json);
                    if (project == null) continue;

                    DataGridView_Projects_Populate(project);
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
        #endregion Load

        #region Populate: DataGridView =============================
        private void DataGridView_Projects_Populate(Project project)
        {
            DataGridView_Projects.Rows.Add(
                project.Id,
                project.Name,
                project.Description
                );
        }
        #endregion Populate: DataGridView

        #region Save ===============================================
        private void Projects_Save()
        {
            Controller controller = new();

            foreach (DataGridViewRow row in DataGridView_Projects.Rows)
            {
                (bool isProjectValid, string projectName) = CellValue_String_Validate(row, COLUMN_PROJECT);
                if (isProjectValid == false) continue;

                (bool isIdValid, long id) = CellValue_Long_Validate(row, COLUMN_ID);
                if (isIdValid == false)
                {
                    id = controller.CreateId();
                    row.Cells[COLUMN_ID]?.Value = id;
                }

                string description = DataGridViewUtilities.GetCellValue_String(row, COLUMN_DESCRIPTION);

                Project project = new(
                    id,
                    projectName,
                    description,
                    AppStore.organization
                );

                controller.CreateDirectory(AppStore.organizationPath, id);
                try
                {
                    controller.Save(project, AppStore.organizationPath, id);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception);
                }
            }
        }
        #endregion Save

        #region Validation =========================================
        private (bool, long) CellValue_Long_Validate(DataGridViewRow row, string columnName)
        {
            long cellValue = DataGridViewUtilities.GetCellValue_Long(row, columnName);
            bool isValid = cellValue > 0;
            return (isValid, cellValue);
        }

        private (bool, string) CellValue_String_Validate(DataGridViewRow row, string columnName)
        {
            string cellValue = DataGridViewUtilities.GetCellValue_String(row, columnName);
            bool isValid = cellValue.Equals("") == false;
            return (isValid, cellValue);
        }
        #endregion Validation
    }
}
