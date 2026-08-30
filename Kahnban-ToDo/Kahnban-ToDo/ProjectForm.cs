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
        private const string COLUMN_CATEGORY = "category";
        private const string COLUMN_DATE_DUE = "dateDue";
        private const string COLUMN_ID = "id";
        private const string COLUMN_STATUS = "status";
        private const string COLUMN_SUMMARY = "summary";
        private const string COLUMN_TASKLIST = "taskList";
        private const string COLUMN_TASKS = "tasks";
        private const string COLUMN_USER_STORY = "userStory";

        // CONSTANTS - DataGridView Headers
        private const string HEADER_CATEGORY = "Category";
        private const string HEADER_DATE_DUE = "Due Date";
        private const string HEADER_ID = "ID";
        private const string HEADER_STATUS = "Status";
        private const string HEADER_SUMMARY = "Summary";
        private const string HEADER_TASKLIST = "Task List";
        private const string HEADER_TASKS = "Tasks";
        private const string HEADER_USER_STORY = "User Story";

        // CONSTANTS - DataGridView Properties
        private const int PROPERTY_WIDTH_CATEGORY = 100;
        private const int PROPERTY_WIDTH_DATE_DUE = 100;
        private const int PROPERTY_WIDTH_STATUS = 100;
        private const int PROPERTY_WIDTH_TASKS = 100;

        public ProjectForm()
        {
            InitializeComponent();
            DataGridView_Projects_Intialize();

            Label_Project_Display();
            LinkLabel_Organization_Display();
            DataGridView_UserStories_Load();

            DataGridView_Status_Display();
        }

        #region Display ============================================
        private void DataGridView_Status_Display()
        {
            DataGridView_Status.DataSource = null;

            List<StatusCount> statusList = new List<StatusCount>();
            foreach (DataGridViewRow row in DataGridView_UserStories.Rows)
            {
                if (row.IsNewRow) continue;
                string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);

                StatusCount? statusCount = statusList.FirstOrDefault(s => s.Status.Equals(status));

                if (statusCount != null)
                {
                    statusCount.Count++;
                    continue;
                }

                statusCount = new StatusCount(status, 1);
                statusList.Add(statusCount);
            }

            DataGridView_Status.DataSource = statusList;
        }

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

            // BEGIN Creating Columns
            // Id Column
            DataGridView_UserStories.Columns.Add(COLUMN_ID, HEADER_ID);
            DataGridView_UserStories.Columns.Add(COLUMN_USER_STORY, HEADER_USER_STORY);
            DataGridView_UserStories.Columns.Add(COLUMN_SUMMARY, HEADER_SUMMARY);

            // Category
            DataGridViewColumn categoryColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_CATEGORY,
                Name = COLUMN_CATEGORY,
                Width = PROPERTY_WIDTH_CATEGORY
            };
            DataGridView_UserStories.Columns.Add(categoryColumn);

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

            DataGridViewColumn dateDueColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_DATE_DUE,
                Name = COLUMN_DATE_DUE,
                Width = PROPERTY_WIDTH_DATE_DUE
            };

            DataGridView_UserStories.Columns.Add(dateDueColumn);
            // END Creating Columns

            // Readonly
            DataGridView_UserStories.Columns[COLUMN_CATEGORY]?.ReadOnly = true;
            DataGridView_UserStories.Columns[COLUMN_DATE_DUE]?.ReadOnly = true;
            DataGridView_UserStories.Columns[COLUMN_TASKS]?.ReadOnly = true;

            // Visibility
            DataGridView_UserStories.Columns[COLUMN_ID]?.Visible = false;
            DataGridView_UserStories.Columns[COLUMN_SUMMARY]?.Visible = false;
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

                // BEGIN Map to User Story object
                UserStory userStory = new UserStory();
                userStory.Id = id;
                userStory.Name = userStoryName;
                userStory.Organization = AppStore.organization;
                userStory.Project = AppStore.project?.Name ?? "";

                string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);
                userStory.Status = status;

                string summary = DataGridViewUtilities.GetCellValue_String(row, COLUMN_SUMMARY);
                userStory.Summary = summary;

                string taskList = DataGridViewUtilities.GetCellValue_String(row, COLUMN_TASKLIST);
                userStory.TaskList = taskList;
                // END Map to User Story object

                // Create a Directory is non exists
                long projectId = AppStore.project?.Id ?? -1;
                string projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());
                controller.CreateDirectory(projectPath, id.ToString());

                // Save the file
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

            // BEING Map to User Story object
            UserStory userStory = new UserStory();
            userStory.Id = id;
            userStory.Name = userStoryName;
            userStory.Organization = AppStore.organization;
            userStory.Project = AppStore.project?.Name ?? "";

            string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);
            userStory.Status = status;

            string summary = DataGridViewUtilities.GetCellValue_String(row, COLUMN_SUMMARY);
            userStory.Summary = summary;

            string taskList = DataGridViewUtilities.GetCellValue_String(row, COLUMN_TASKLIST);
            userStory.TaskList = taskList;
            // END Map to User Story object

            long projectId = AppStore.project?.Id ?? -1;
            string projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());

            UserStoryForm userStoryForm = new UserStoryForm(userStory, projectPath);
            FormUtilities.NavigateTo(userStoryForm);
        }

        private void DataGridView_UserStories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView_Status_Display();
        }

        private void DataGridView_UserStories_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataGridView_UserStories.IsCurrentCellDirty)
            {
                DataGridView_UserStories.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
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
            int taskCount = 0;
            if (taskList.Length > 0)
            {
                taskCount = taskList.Split('\n').Count(line => string.IsNullOrWhiteSpace(line) == false);
            }

            DataGridView_UserStories.Rows.Add(
                userStory.Id,
                userStory.Name,
                userStory.Summary,
                userStory.Category,
                userStory.Status,
                taskList,
                taskCount,
                userStory.DateDue.ToShortDateString()
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
