using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text.Json;

namespace Kahnban_ToDo
{
    public partial class ProjectForm : Form
    {
        // CONSTANTS - DataGridView Columns
        private const string COLUMN_ID = "id";
        private const string COLUMN_STATUS = "status";
        private const string COLUMN_SUMMARY = "summary";
        private const string COLUMN_TASKLIST = "taskList";
        private const string COLUMN_TASKS = "tasks";
        private const string COLUMN_USER_STORY = "userStory";

        // CONSTANTS - DataGridView Headers
        private const string HEADER_ID = "ID";
        private const string HEADER_STATUS = "Status";
        private const string HEADER_SUMMARY = "Summary";
        private const string HEADER_TASKLIST = "Task List";
        private const string HEADER_TASKS = "Tasks";
        private const string HEADER_USER_STORY = "User Story";

        // CONSTANTS - DataGridView Properties
        private const int PROPERTY_WIDTH_STATUS = 150;
        private const int PROPERTY_WIDTH_TASKS = 150;
        private const int PROPERTY_WIDTH_USER_STORY = 250;

        public ProjectForm()
        {
            InitializeComponent();
            DataGridView_Projects_Intialize();

            Label_Project_Display();
            LinkLabel_Organization_Display();
            DataGridView_UserStories_Load();
        }

        #region Display ============================================
        private void Label_Project_Display()
        {
            Label_Project.Text = AppStore.project?.Name ?? "";
        }

        private void LinkLabel_Organization_Display()
        {
            LinkLabel_Organization.Text = AppStore.organization;
        }
        #endregion Display

        #region Initialize =========================================
        private void DataGridView_Projects_Intialize()
        {
            DataGridView_UserStories.Columns.Clear();

            // Id Column
            DataGridView_UserStories.Columns.Add(COLUMN_ID, HEADER_ID);

            // User Story Column
            DataGridViewColumn userStoryColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_USER_STORY,
                Name = COLUMN_USER_STORY,
                Width = PROPERTY_WIDTH_USER_STORY
            };

            DataGridView_UserStories.Columns.Add(userStoryColumn);

            // Summary Column
            DataGridView_UserStories.Columns.Add(COLUMN_SUMMARY, HEADER_SUMMARY);

            // Status
            DataGridViewComboBoxCell statusCell = new DataGridViewComboBoxCell();
            statusCell.Items.Add("COMPLETE");
            statusCell.Items.Add("PENDING");
            statusCell.Items.Add("RELEASED");
            statusCell.Items.Add("RFT");
            statusCell.Items.Add("WIP");

            DataGridViewColumn statusColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = statusCell,
                HeaderText = HEADER_STATUS,
                Name = COLUMN_STATUS,
                Width = PROPERTY_WIDTH_STATUS
            };

            DataGridView_UserStories.Columns.Add(statusColumn);

            // Task List
            DataGridView_UserStories.Columns.Add(COLUMN_TASKLIST, HEADER_TASKLIST);

            // Tasks
            DataGridViewColumn tasksColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_TASKS,
                Name = COLUMN_TASKS,
                Width = PROPERTY_WIDTH_TASKS
            };

            DataGridView_UserStories.Columns.Add(tasksColumn);

            // Formatting
            DataGridView_UserStories.Columns[COLUMN_ID]?.Visible = false;
            DataGridView_UserStories.Columns[COLUMN_TASKLIST]?.Visible = false;
        }
        #endregion Initialize

        #region Interaction: DataGridView ==========================
        private void DataGridView_UserStories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Controller controller = new();

            foreach (DataGridViewRow row in DataGridView_UserStories.Rows)
            {
                (bool isUserStoryValid, string userStoryName) = CellValue_String_Validate(row, COLUMN_USER_STORY);
                if (isUserStoryValid == false) return;

                (bool isIdValid, long id) = CellValue_Long_Validate(row, COLUMN_ID);
                if (isIdValid == false)
                {
                    id = controller.CreateId();
                    row.Cells[COLUMN_ID]?.Value = id;
                }

                string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);
                string summary = DataGridViewUtilities.GetCellValue_String(row, COLUMN_SUMMARY);
                string taskList = DataGridViewUtilities.GetCellValue_String(row, COLUMN_TASKLIST);

                UserStory userStory = new UserStory(
                    id,
                    userStoryName,
                    AppStore.organization,
                    AppStore.project?.Name ?? "",
                    status,
                    summary,
                    taskList
                    );

                long projectId = AppStore.project?.Id ?? -1;
                string projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());
                controller.CreateDirectory(projectPath, id.ToString());

                string fileName = $"{id}.json";
                string filePath = Path.Combine(projectPath, fileName);

                try
                {
                    controller.Save(userStory, filePath);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception);
                }
            }
        }

        private void DataGridView_UserStories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            DataGridViewRow row = DataGridView_UserStories.Rows[rowIndex];
            if (row == null) return;

            (bool isIdValid, long id) = CellValue_Long_Validate(row, COLUMN_ID);
            if (isIdValid == false) return;

            (bool isUserStoryValid, string userStoryName) = CellValue_String_Validate(row, COLUMN_USER_STORY);
            if (isUserStoryValid == false) return;

            string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);
            string summary = DataGridViewUtilities.GetCellValue_String(row, COLUMN_SUMMARY);
            string taskList = DataGridViewUtilities.GetCellValue_String(row, COLUMN_TASKLIST);

            UserStory userStory = new UserStory(
                id,
                userStoryName,
                AppStore.organization,
                AppStore.project?.Name ?? "",
                status,
                summary,
                taskList
                );

            long projectId = AppStore.project?.Id ?? -1;
            string projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());

            UserStoryForm userStoryForm = new UserStoryForm(userStory, projectPath);
            FormUtilities.NavigateTo(userStoryForm);
        }
        #endregion Interaction: DataGridView

        #region Interaction: LinkLabel =============================
        private void LinkLabel_Organization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizationForm organizationForm = new OrganizationForm();
            FormUtilities.NavigateTo(organizationForm);
        }
        #endregion Interaction: LinkLabel

        #region Load ===============================================
        private void DataGridView_UserStories_Load()
        {
            try
            {
                long projectId = AppStore.project?.Id ?? -1;
                string projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());
                string[] jsonFiles = Directory.GetFiles(projectPath, "*.json");

                foreach (string jsonFile in jsonFiles)
                {
                    string json = File.ReadAllText(jsonFile);
                    UserStory? userStory = JsonSerializer.Deserialize<UserStory>(json);
                    if (userStory == null) continue;

                    DataGridView_UserStories_Populate(userStory);
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
        #endregion Load

        #region Populate: DataGridView =============================
        private void DataGridView_UserStories_Populate(UserStory userStory)
        {
            string taskList = userStory.TaskList;
            int lineCount = 0;
            if (taskList.Length > 0)
            {
                lineCount = taskList.Split('\n').Length;
            }

            DataGridView_UserStories.Rows.Add(
                userStory.Id,
                userStory.Name,
                userStory.Summary,
                userStory.Status,
                taskList,
                lineCount
                );
        }
        #endregion Populate: DataGridView

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
