using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text.Json;

namespace Kahnban_ToDo
{
    public partial class ProjectDetailsForm : Form
    {
        // CONSTANTS - ComboBox
        private const string ITEM_CATEGORY_ALL = "All Categories";
        private const string ITEM_STATUS_BACKLOG = "BACKLOG";
        private const string ITEM_STATUS_CANCELLED = "CANCELLED";
        private const string ITEM_STATUS_ALL = "All Statuses";
        private const string ITEM_STATUS_ALL_ACTIVE = "All Active Statuses";
        private const string ITEM_STATUS_RELEASED = "RELEASED";

        // CONSTANTS - DataGridView Columns
        private const string COLUMN_ASSIGNEE = "asignee";
        private const string COLUMN_CATEGORY = "category";
        private const string COLUMN_COUNT = "count";
        private const string COLUMN_DATE_END = "dateEnd";
        private const string COLUMN_ID = "id";
        private const string COLUMN_STATUS = "status";
        private const string COLUMN_SUMMARY = "summary";
        private const string COLUMN_TASKLIST = "taskList";
        private const string COLUMN_TASKS = "tasks";
        private const string COLUMN_USER_STORY = "userStory";
        private const string COLUMN_VERSION = "version";

        // CONSTANTS  DataGridView Defaults
        private const string DEFAULT_STATUS = "PENDING";
        private const int DEFAULT_TASKS = 0;

        // CONSTANTS - DataGridView Headers
        private const string HEADER_ASSIGNEE = "Asignee";
        private const string HEADER_CATEGORY = "Category";
        private const string HEADER_DATE_END = "End Date";
        private const string HEADER_ID = "ID";
        private const string HEADER_STATUS = "Status";
        private const string HEADER_SUMMARY = "Summary";
        private const string HEADER_TASKLIST = "Task List";
        private const string HEADER_TASKS = "Tasks";
        private const string HEADER_USER_STORY = "User Story";
        private const string HEADER_VERSION = "Version";

        // CONSTANTS - DataGridView Properties
        private const int PROPERTY_WIDTH_CATEGORY = 100;
        private const int PROPERTY_WIDTH_DATE_END = 100;
        private const int PROPERTY_WIDTH_STATUS = 100;
        private const int PROPERTY_WIDTH_TASKS = 100;
        private const int PROPERTY_WIDTH_VERSION = 100;

        // CONSTANTS - PLACEHOLDERS
        private const string PLACEHOLDER_USER_STORY = "Search...";

        // CONSTANTS - TABLE LAYOUT PANELS
        private const int COLUMN_SIDEBAR_INDEX = 0;
        private const float COLUMN_SIDEBAR_SIZE = 250f;

        // Local Memory
        private int _categorySelectedIndex = 0;

        public ProjectDetailsForm()
        {
            InitializeComponent();
            DataGridView_UserStories_Intialize();
            ComboBox_Status_Initialize();

            Label_Project_Display();
            LinkLabel_Organization_Display();
            DataGridView_UserStories_Load();

            DataGridView_Status_Display();
            ComboBox_Category_Load();

            Label_Status_Display();
            Label_UserStories_Display();

            FormUtilities.DisplayPlaceholder(TextBox_UserStory, PLACEHOLDER_USER_STORY);
        }

        #region CRUD ===============================================
        private void Update_UserStory(int rowIndex)
        {
            DataGridViewRow row = DataGridView_UserStories.Rows[rowIndex];
            if (row == null) return;

            (bool isIdValid, long id) = CellValue_Long_Validate(row, COLUMN_ID);
            if (isIdValid == false) return;

            UserStoryForm userStoryForm = new UserStoryForm(id);
            FormUtilities.NavigateTo(userStoryForm);
        }
        #endregion CRUD

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
            Label_Status_Display();
        }

        private void Label_Project_Display()
        {
            Label_Project.Text = AppStore.project?.Name ?? "";
        }

        private void Label_Status_Display()
        {
            int remaining = 0;
            int total = 0;

            foreach (DataGridViewRow row in DataGridView_Status.Rows)
            {
                if (row.Visible == false) continue;
                int count = DataGridViewUtilities.GetCellValue_Int(row, COLUMN_COUNT);
                total += count;

                // Only count statuses that are not complete.
                string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);

                bool isCancelled = status.Equals(ITEM_STATUS_CANCELLED);
                bool isReleased = status.Equals(ITEM_STATUS_RELEASED);

                bool doNotAddToRemainingCount = isReleased || isCancelled;
                if (doNotAddToRemainingCount) continue;

                remaining += count;
            }

            string text = $"Status (total: {total}, remaining: {remaining})";
            Label_Status.Text = text;
        }

        private void Label_UserStories_Display()
        {
            int total = 0;

            foreach (DataGridViewRow row in DataGridView_UserStories.Rows)
            {
                if (row.IsNewRow) continue;

                // Only count tasks on incomplete user stories.
                string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);

                bool isCancelled = status.Equals(ITEM_STATUS_CANCELLED);
                bool isReleased = status.Equals(ITEM_STATUS_RELEASED);

                bool doNotCount = isReleased || isCancelled;
                if (doNotCount) continue;

                int tasks = DataGridViewUtilities.GetCellValue_Int(row, COLUMN_TASKS);
                total += tasks;
            }

            string text = $"User Stories (tasks: {total})";
            Label_UserStories.Text = text;
        }

        private void LinkLabel_Organization_Display()
        {
            LinkLabel_Organization.Text = AppStore.organization;
        }

        private void TableLayoutPanel_Content_Display()
        {
            float columnWidth = TableLayoutPanel_Content.ColumnStyles[COLUMN_SIDEBAR_INDEX].Width;
            bool isHidden = columnWidth == 0;
            TableLayoutPanel_Content.ColumnStyles[COLUMN_SIDEBAR_INDEX].Width = isHidden ? COLUMN_SIDEBAR_SIZE : 0;
        }
        #endregion Display

        #region Initialize =========================================
        private void ComboBox_Status_Initialize()
        {
            ComboBox_Status.Items.Clear();
            ComboBox_Status.Items.Add(ITEM_STATUS_ALL);
            ComboBox_Status.Items.Add(ITEM_STATUS_ALL_ACTIVE);

            Controller controller = new();
            List<string> statusList = controller.GetStatusList();

            foreach (string status in statusList)
            {
                ComboBox_Status.Items.Add(status);
            }

            ComboBox_Status.SelectedIndex = 1;
        }

        private void DataGridView_UserStories_Intialize()
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
                SortMode = DataGridViewColumnSortMode.Automatic,
                Width = PROPERTY_WIDTH_CATEGORY
            };
            DataGridView_UserStories.Columns.Add(categoryColumn);

            // Status
            DataGridViewColumn statusColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_STATUS,
                Name = COLUMN_STATUS,
                SortMode = DataGridViewColumnSortMode.Automatic,
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
                SortMode = DataGridViewColumnSortMode.Automatic,
                Width = PROPERTY_WIDTH_TASKS
            };
            DataGridView_UserStories.Columns.Add(tasksColumn);

            DataGridViewColumn endDateColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" },
                HeaderText = HEADER_DATE_END,
                Name = COLUMN_DATE_END,
                SortMode = DataGridViewColumnSortMode.Automatic,
                Width = PROPERTY_WIDTH_DATE_END,
                ValueType = typeof(DateTime)
            };
            DataGridView_UserStories.Columns.Add(endDateColumn);

            DataGridViewColumn versionColumn = new DataGridViewColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                CellTemplate = new DataGridViewTextBoxCell(),
                HeaderText = HEADER_VERSION,
                Name = COLUMN_VERSION,
                SortMode = DataGridViewColumnSortMode.Automatic,
                Width = PROPERTY_WIDTH_VERSION
            };
            DataGridView_UserStories.Columns.Add(versionColumn);
            // END Creating Columns

            // Visibility
            DataGridView_UserStories.Columns[COLUMN_ID]?.Visible = false;
            DataGridView_UserStories.Columns[COLUMN_SUMMARY]?.Visible = false;
            DataGridView_UserStories.Columns[COLUMN_TASKLIST]?.Visible = false;
        }
        #endregion Initialize

        #region Interaction: Button ================================
        private void Button_SideBar_Click(object sender, EventArgs e)
        {
            TableLayoutPanel_Content_Display();
        }

        private void Button_UserStory_Create_Click(object sender, EventArgs e)
        {
            UserStoryForm userStoryForm = new UserStoryForm();
            FormUtilities.NavigateTo(userStoryForm);
        }

        private void Button_UserStory_Delete_Click(object sender, EventArgs e)
        {
            int rowIndex = DataGridView_UserStories.SelectedCells[0].RowIndex;
            DataGridViewRow row = DataGridView_UserStories.Rows[rowIndex];
            if (row == null) return;

            long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);
            string name = DataGridViewUtilities.GetCellValue_String(row, COLUMN_USER_STORY);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {name}?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.No) return;

            Controller controller = new();
            try
            {
                controller.DeleteUserStory(id);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return;
            }

            DataGridView_UserStories_Load();

            ComboBox_Category_Load();

            Label_Status_Display();
            Label_UserStories_Display();
        }

        private void Button_UserStory_Delete_State(int rowIndex)
        {
            DataGridViewRow row = DataGridView_UserStories.Rows[rowIndex];
            if (row == null) return;

            long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);
            bool isValid = id > 0;

            Button_UserStory_Delete.Enabled = isValid;
        }

        private void Button_UserStory_Update_Click(object sender, EventArgs e)
        {
            int rowIndex = DataGridView_UserStories.SelectedCells[0].RowIndex;
            DataGridViewRow row = DataGridView_UserStories.Rows[rowIndex];
            if (row == null) return;

            Update_UserStory(rowIndex);
        }

        private void Button_UserStory_Update_State(int rowIndex)
        {
            DataGridViewRow row = DataGridView_UserStories.Rows[rowIndex];
            if (row == null) return;

            long id = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);
            bool isValid = id > 0;

            Button_UserStory_Update.Enabled = isValid;
        }
        #endregion Interaction: Button

        #region Interaction: ComboBox ==============================
        private void ComboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEditing = DataGridView_UserStories.IsCurrentCellInEditMode;
            if (isEditing) return;

            DataGridView_UserStories_FilterRows();
        }

        private void ComboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEditing = DataGridView_UserStories.IsCurrentCellInEditMode;
            if (isEditing) return;

            DataGridView_UserStories_FilterRows();
        }
        #endregion Interaction: ComboBox

        #region Interaction: DataGridView ==========================
        private void DataGridView_UserStories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int rowIndex = e.RowIndex;

            Button_UserStory_Delete_State(rowIndex);
            Button_UserStory_Update_State(rowIndex);
        }

        private void DataGridView_UserStories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = DataGridView_UserStories.Rows[rowIndex];
            if (row == null) return;
            if (row.IsNewRow) return;

            Controller controller = new();

            long projectId = AppStore.project?.Id ?? -1;
            string projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());

            (bool isUserStoryValid, string userStoryName) = CellValue_String_Validate(row, COLUMN_USER_STORY);
            if (isUserStoryValid == false) return;

            UserStory? userStory = null;

            (bool isIdValid, long id) = CellValue_Long_Validate(row, COLUMN_ID);
            if (isIdValid)
            {
                userStory = controller.GetUserStory(projectPath, id);
            }
            else
            {
                id = controller.GenerateId();
                row.Cells[COLUMN_ID]?.Value = id;
                row.Cells[COLUMN_STATUS]?.Value = DEFAULT_STATUS;
                row.Cells[COLUMN_TASKS]?.Value = DEFAULT_TASKS;

                userStory = new UserStory();
                userStory.Id = id;

                userStory.Organization = AppStore.organization;
                userStory.Project = AppStore.project?.Name ?? "";
            }

            if (userStory == null)
            {
                Debug.WriteLine("Error loading User Story");
                return;
            }

            // BEGIN Map to User Story object
            userStory.Name = userStoryName;

            string category = DataGridViewUtilities.GetCellValue_String(row, COLUMN_CATEGORY);
            userStory.Category = category;

            string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);
            userStory.Status = status;

            string version = DataGridViewUtilities.GetCellValue_String(row, COLUMN_VERSION);
            userStory.Version = version;
            // END Map to User Story object

            // Create a Directory is non exists
            controller.CreateDirectory(projectPath, id);
            try
            {
                controller.Save(userStory, projectPath, id);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }

            BeginInvoke(() => DataGridView_UserStories_FilterRows());
        }

        private void DataGridView_UserStories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            Update_UserStory(rowIndex);
        }

        private void DataGridView_UserStories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView_Status_Display();
            ComboBox_Category_Load();

            bool isStatusColumn = e.ColumnIndex == DataGridView_UserStories.Columns[COLUMN_STATUS].Index;
            if (isStatusColumn == false) return;

            DataGridView_UserStories_FilterRows();
        }

        private void DataGridView_UserStories_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataGridView_UserStories.IsCurrentCellDirty)
            {
                DataGridView_UserStories.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridView_UserStories_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row == null) return;

            DialogResult result = MessageBox.Show(
                "Send this user story to the recycling bin?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            DataGridViewRow row = e.Row;
            long userStoryId = DataGridViewUtilities.GetCellValue_Long(row, COLUMN_ID);

            string organizationPath = AppStore.organizationPath;
            string projectId = AppStore.project?.Id.ToString() ?? "";

            string directoryPath = Path.Combine(organizationPath, projectId, userStoryId.ToString());
            if (Directory.Exists(directoryPath))
            {
                FileSystem.DeleteDirectory(
                    directoryPath,
                    UIOption.OnlyErrorDialogs,
                    RecycleOption.SendToRecycleBin
                );
            }

            string fileName = $"{userStoryId}.json";
            string filePath = Path.Combine(organizationPath, projectId, fileName);
            if (File.Exists(filePath))
            {
                FileSystem.DeleteFile(
                    filePath,
                    UIOption.OnlyErrorDialogs,
                    RecycleOption.SendToRecycleBin
                );
            }
        }
        #endregion Interaction: DataGridView

        #region Interaction: LinkLabel =============================
        private void LinkLabel_Organization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizationForm organizationForm = new OrganizationForm();
            FormUtilities.NavigateTo(organizationForm);
        }

        private void LinkLabel_Start_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller controller = new();
            controller.ResetStore();

            StartForm startForm = new StartForm();
            FormUtilities.NavigateTo(startForm);
        }
        #endregion Interaction: LinkLabel

        #region Interaction: TextBox ===============================
        private void TextBox_UserStory_Enter(object sender, EventArgs e)
        {
            FormUtilities.DisplayPlaceholder(TextBox_UserStory, PLACEHOLDER_USER_STORY);
        }

        private void TextBox_UserStory_KeyUp(object sender, KeyEventArgs e)
        {
            DataGridView_UserStories_FilterRows();
        }

        private void TextBox_UserStory_Leave(object sender, EventArgs e)
        {
            FormUtilities.DisplayPlaceholder(TextBox_UserStory, PLACEHOLDER_USER_STORY);
        }
        #endregion Interaction: TextBox

        #region Load ===============================================
        private void ComboBox_Category_Load()
        {
            ComboBox_Category.Items.Clear();
            ComboBox_Category.Items.Add(ITEM_CATEGORY_ALL);

            foreach (DataGridViewRow row in DataGridView_UserStories.Rows)
            {
                if (row.IsNewRow) continue;
                string category = DataGridViewUtilities.GetCellValue_String(row, COLUMN_CATEGORY);

                bool isEmpty = string.IsNullOrEmpty(category);
                if (isEmpty) continue;

                bool isInList = ComboBox_Category.Items.Contains(category);
                if (isInList) continue;

                ComboBox_Category.Items.Add(category);
            }

            ComboBox_Category.SelectedIndex = _categorySelectedIndex;
        }

        private void DataGridView_UserStories_Load()
        {
            DataGridView_UserStories.Rows.Clear();
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

        #region Logic ==============================================
        private void DataGridView_UserStories_FilterRows()
        {
            string text = TextBox_UserStory.Text.ToUpper();
            text = text.Equals(PLACEHOLDER_USER_STORY.ToUpper()) ? string.Empty : text;

            string selectedCategory = ComboBox_Category.Text;
            string selectedStatus = ComboBox_Status.Text;

            foreach (DataGridViewRow row in DataGridView_UserStories.Rows)
            {
                if (row.IsNewRow) continue;

                string userStory = DataGridViewUtilities.GetCellValue_String(row, COLUMN_USER_STORY).ToUpper();
                bool containsText = userStory.Contains(text);

                string category = DataGridViewUtilities.GetCellValue_String(row, COLUMN_CATEGORY);
                bool categoryShowAll = selectedCategory == ITEM_CATEGORY_ALL;
                bool matchCategory = category.Equals(selectedCategory);
                bool categoryMatches = categoryShowAll || matchCategory;

                string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);
                bool defaultHiddenStatus = status.Equals(ITEM_STATUS_CANCELLED)
                    || status.Equals(ITEM_STATUS_RELEASED)
                    || status.Equals(ITEM_STATUS_BACKLOG);

                bool statusMatches = false;

                if (selectedStatus.Equals(ITEM_STATUS_ALL))
                {
                    statusMatches = true;
                }
                else if (selectedStatus.Equals(ITEM_STATUS_ALL_ACTIVE))
                {
                    statusMatches = defaultHiddenStatus == false;
                }
                else
                {
                    statusMatches = selectedStatus.Equals(status);
                }

                row.Visible = categoryMatches && statusMatches && containsText;
            }

            Label_UserStories_Display();
        }
        #endregion Logic

        #region Populate: DataGridView =============================
        private void DataGridView_UserStories_Populate(UserStory userStory)
        {
            string taskList = userStory.TaskList.ToUpper();
            int taskCount = 0;
            if (taskList.Length > 0)
            {
                taskCount = taskList.Split('\n').Count(line => string.IsNullOrWhiteSpace(line) == false);
            }

            // Count completed tasks.
            Controller controller = new();
            List<StatusCount> statusCounts = controller.CountStatuses(taskList);
            int completeCount = statusCounts.FirstOrDefault(statusCount => statusCount.Status.Equals("COMPLETE"))?.Count ?? 0;
            taskCount -= completeCount;

            if (taskCount < 0) taskCount = 0;

            DataGridView_UserStories.Rows.Add(
                userStory.Id,
                userStory.Name,
                userStory.Summary,
                userStory.Category,
                userStory.Status,
                taskList,
                taskCount,
                userStory.DateEnd,
                userStory.Version
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
