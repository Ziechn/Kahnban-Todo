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
        // CONSTANTS - ComboBox
        private const string ITEM_CATEGORY_ALL = "All Categories";
        private const string ITEM_STATUS_ALL = "All Statuses";

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

        // CONSTANTS - TABLE LAYOUT PANELS
        private const int COLUMN_SIDEBAR_INDEX = 0;
        private const float COLUMN_SIDEBAR_SIZE = 250f;

        // Local Memory
        private int _categorySelectedIndex = 0;

        public ProjectForm()
        {
            InitializeComponent();
            DataGridView_Projects_Intialize();
            ComboBox_Status_Initialize();

            Label_Project_Display();
            LinkLabel_Organization_Display();
            DataGridView_UserStories_Load();

            DataGridView_Status_Display();
            ComboBox_Category_Load();
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

            Controller controller = new();
            List<string> statusList = controller.GetStatusList();

            foreach (string status in statusList)
            {
                ComboBox_Status.Items.Add(status);
            }

            ComboBox_Status.SelectedIndex = 0;
        }

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
            Controller controller = new();
            List<string> statusList = controller.GetStatusList();

            DataGridViewComboBoxCell statusCell = new DataGridViewComboBoxCell();
            foreach (string status in statusList)
            {
                statusCell.Items.Add(status);
            }

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
            //DataGridView_UserStories.Columns[COLUMN_CATEGORY]?.ReadOnly = true;
            DataGridView_UserStories.Columns[COLUMN_DATE_DUE]?.ReadOnly = true;
            DataGridView_UserStories.Columns[COLUMN_TASKS]?.ReadOnly = true;

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
        #endregion Interaction: Button

        #region Interaction: ComboBox ==============================
        private void ComboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView_UserStories_FilterRows();
        }

        private void ComboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView_UserStories_FilterRows();
        }
        #endregion Interaction: ComboBox

        #region Interaction: DataGridView ==========================
        private void DataGridView_UserStories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Controller controller = new();
            
            long projectId = AppStore.project?.Id ?? -1;
            string projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());

            foreach (DataGridViewRow row in DataGridView_UserStories.Rows)
            {
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
                    id = controller.CreateId();
                    row.Cells[COLUMN_ID]?.Value = id;

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
                // END Map to User Story object

                // Create a Directory is non exists
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

            long projectId = AppStore.project?.Id ?? -1;
            string projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());

            UserStoryForm userStoryForm = new UserStoryForm(projectPath, id);
            FormUtilities.NavigateTo(userStoryForm);
        }

        private void DataGridView_UserStories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView_Status_Display();
            ComboBox_Category_Load();
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
        private void ComboBox_Category_Load()
        {
            ComboBox_Category.Items.Clear();
            ComboBox_Category.Items.Add(ITEM_CATEGORY_ALL);

            foreach (DataGridViewRow row in DataGridView_UserStories.Rows)
            {
                if (row.IsNewRow) continue;
                string category = DataGridViewUtilities.GetCellValue_String(row, COLUMN_CATEGORY);
                bool isInList = ComboBox_Category.Items.Contains(category);
                if (isInList) continue;

                ComboBox_Category.Items.Add(category);
            }

            ComboBox_Category.SelectedIndex = _categorySelectedIndex;
        }

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

        #region Logic ==============================================
        private void DataGridView_UserStories_FilterRows()
        {
            string selectedCategory = ComboBox_Category.Text;
            string selectedStatus = ComboBox_Status.Text;

            foreach (DataGridViewRow row in DataGridView_UserStories.Rows)
            {
                if (row.IsNewRow)continue;

                string category = DataGridViewUtilities.GetCellValue_String(row, COLUMN_CATEGORY);
                string status = DataGridViewUtilities.GetCellValue_String(row, COLUMN_STATUS);

                bool categoryShowAll = selectedCategory == ITEM_CATEGORY_ALL;
                bool matchCategory = category == selectedCategory;
                bool categoryMatches = categoryShowAll || matchCategory;

                bool statusShowAll = selectedStatus == ITEM_STATUS_ALL;
                bool matchStatus = status == selectedStatus;
                bool statusMatches = statusShowAll || matchStatus;

                row.Visible = categoryMatches && statusMatches;
            }
        }
        #endregion Logic

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
                userStory.DateDue?.ToShortDateString() ?? ""
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
