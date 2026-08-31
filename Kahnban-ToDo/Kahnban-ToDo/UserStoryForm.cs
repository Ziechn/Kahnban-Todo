using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Diagnostics;

namespace Kahnban_ToDo
{
    public partial class UserStoryForm : Form
    {
        // CONSTANTS - COMBOBOX
        private const string ITEMS_STATUS_SELECT = "Select Status...";

        // CONSTANTS - PLACEHOLDERS
        private const string PLACEHOLDER_CATEGORY = "Enter Category...";

        // CONSTANTS - TABLE LAYOUT PANELS
        private const int COLUMN_SIDEBAR_INDEX = 0;
        private const float COLUMN_SIDEBAR_SIZE = 250f;
        private const int ROW_SUMMARY_INDEX = 0;
        private const float ROW_SUMMARY_SIZE = 20f;
        private const int ROW_SUMMARY_TEXT_INDEX = 1;
        private const float ROW_SUMMARY_TEXT_SIZE = 120f;

        // Local Memory
        string _projectPath = "";
        UserStory _userStory;
        bool isLoading = true;

        public UserStoryForm(string projectPath, long id)
        {
            InitializeComponent();
            ComboBox_Status_Initialize();
            DateTimePicker_Due_Initialize();
            DateTimePicker_End_Initialize();
            DateTimePicker_Start_Initialize();

            _projectPath = projectPath;
            UserStory_Load(id);

            TextBox_Category_DiplayPlaceholder();
            DataGridView_StatusCount_Initialize();
            CountStatuses();

            isLoading = false;
        }

        #region Display ============================================
        private void ComboBox_Status_Display(UserStory userStory)
        {
            ComboBox_Status.Text = userStory.Status;
        }

        private void DataGridView_TagCount_Display(string tag, int count)
        {
            foreach (DataGridViewRow row in DataGridView_Status.Rows)
            {
                string rowTag = row.Cells["tag"].Value?.ToString() ?? "";
                bool isMatch = rowTag.Equals(tag);
                if (isMatch == false) continue;

                row.Cells["count"].Value = count;
            }
        }

        private void DateTimePicker_Due_Display(UserStory userStory)
        {
            if (userStory.DateDue == null) return;
            DateTimePicker_Due.Value = userStory.DateDue.Value;
            DateTimePicker_Due.Checked = true;
        }

        private void DateTimePicker_End_Display(UserStory userStory)
        {
            if (userStory.DateEnd == null) return;
            DateTimePicker_End.Value = userStory.DateEnd.Value;
            DateTimePicker_End.Checked = true;
        }

        private void DateTimePicker_Start_Display(UserStory userStory)
        {
            if (userStory.DateStart == null) return;
            DateTimePicker_Start.Value = userStory.DateStart.Value;
            DateTimePicker_Start.Checked = true;
        }

        private void Label_UserStory_Display(UserStory userStory)
        {
            Label_UserStory.Text = userStory.Name;
        }

        private void LinkLabel_Organization_Display(UserStory userStory)
        {
            LinkLabel_Organization.Text = userStory.Organization;
        }

        private void LinkLabel_Project_Display(UserStory userStory)
        {
            LinkLabel_Project.Text = userStory.Project;
        }

        private void TableLayoutPanel_Content_Display()
        {
            float columnWidth = TableLayoutPanel_Content.ColumnStyles[COLUMN_SIDEBAR_INDEX].Width;
            bool isHidden = columnWidth == 0;
            TableLayoutPanel_Content.ColumnStyles[COLUMN_SIDEBAR_INDEX].Width = isHidden ? COLUMN_SIDEBAR_SIZE : 0;
        }

        private void TableLayoutPanel_Summary_Display()
        {
            float rowHeight = TableLayoutPanel_UserStory.RowStyles[ROW_SUMMARY_INDEX].Height;
            bool isHidden = rowHeight == 0;
            TableLayoutPanel_UserStory.RowStyles[ROW_SUMMARY_INDEX].Height = isHidden ? ROW_SUMMARY_SIZE : 0;
            TableLayoutPanel_UserStory.RowStyles[ROW_SUMMARY_TEXT_INDEX].Height = isHidden ? ROW_SUMMARY_TEXT_SIZE : 0;
        }

        private void TextBox_Category_Display(UserStory userStory)
        {
            TextBox_Category.Text = userStory.Category;
        }

        private void TextBox_Category_DiplayPlaceholder()
        {
            FormUtilities.DisplayPlaceholder(TextBox_Category, PLACEHOLDER_CATEGORY);
        }
        #endregion Display

        #region Initialize =========================================
        private void ComboBox_Status_Initialize()
        {
            ComboBox_Status.Items.Clear();
            ComboBox_Status.Items.Add(ITEMS_STATUS_SELECT);

            Controller controller = new();
            List<string> statusList = controller.GetStatusList();
            
            foreach (string status in statusList)
            {
                ComboBox_Status.Items.Add(status);
            }

            ComboBox_Status.SelectedIndex = 0;
        }
        private void DataGridView_StatusCount_Initialize()
        {
            DataGridView_Status.Columns.Add("tag", "Tag");
            DataGridView_Status.Columns.Add("count", "Count");

            Controller controller = new();
            List<string> statusList = controller.GetStatusList();
            foreach (string status in statusList)
            {
                int tagCount = CountStatus(status);
                DataGridView_Status.Rows.Add(status, tagCount);
            }
        }

        private void DateTimePicker_Due_Initialize()
        {
            DateTimePicker_Due.ShowCheckBox = true;
            DateTimePicker_Due.Checked = false;
        }

        private void DateTimePicker_End_Initialize()
        {
            DateTimePicker_End.ShowCheckBox = true;
            DateTimePicker_End.Checked = false;
        }

        private void DateTimePicker_Start_Initialize()
        {
            DateTimePicker_Start.ShowCheckBox = true;
            DateTimePicker_Start.Checked = false;
        }
        #endregion Initialize

        #region Interaction: Buttons ===============================
        private void Button_SideBar_Click(object sender, EventArgs e)
        {
            TableLayoutPanel_Content_Display();
        }

        private void Button_Summary_Click(object sender, EventArgs e)
        {
            TableLayoutPanel_Summary_Display();
        }
        #endregion Interaction: Buttons

        #region Interaction: ComboBox ==============================
        private void ComboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveUserStory();
        }
        #endregion Interaction: ComboBox

        #region Interaction: DateTimePicker ========================
        private void DateTimePicker_Due_ValueChanged(object sender, EventArgs e)
        {
            SaveUserStory();
        }

        private void DateTimePicker_End_ValueChanged(object sender, EventArgs e)
        {
            SaveUserStory();
        }

        private void DateTimePicker_Start_ValueChanged(object sender, EventArgs e)
        {
            SaveUserStory();
        }
        #endregion Interaction: DateTimePicker

        #region Interaction: RichTextBox ===========================
        private void RichTextBox_Summary_KeyUp(object sender, KeyEventArgs e)
        {
            SaveUserStory();
        }

        private void RichTextBox_TaskList_KeyUp(object sender, KeyEventArgs e)
        {
            SaveUserStory();
            CountStatuses();
        }
        #endregion Interaction: RichTextBox

        #region Interaction: LinkLabel =============================
        private void LinkLabel_Organization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizationForm organizationForm = new OrganizationForm();
            FormUtilities.NavigateTo(organizationForm);
        }

        private void LinkLabel_Project_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectForm projectForm = new ProjectForm();
            FormUtilities.NavigateTo(projectForm);
        }
        #endregion Interaction: LinkLabel

        #region Interaction: TextBox ===============================
        private void TextBox_Category_Enter(object sender, EventArgs e)
        {
            TextBox_Category_DiplayPlaceholder();
        }

        private void TextBox_Category_KeyUp(object sender, KeyEventArgs e)
        {
            SaveUserStory();
        }

        private void TextBox_Category_Leave(object sender, EventArgs e)
        {
            TextBox_Category_DiplayPlaceholder();
        }
        #endregion Interaction: TextBox

        #region Load ===============================================
        private void UserStory_Load(long id)
        {
            Controller controller = new();
            UserStory? userStory = controller.GetUserStory(_projectPath, id);
            if (userStory == null)
            {
                Debug.WriteLine("Error loading User Story");
                return;
            }

            _userStory = userStory;

            ComboBox_Status_Display(userStory);
            DateTimePicker_Due_Display(userStory);
            DateTimePicker_End_Display(userStory);
            DateTimePicker_Start_Display(userStory);
            LinkLabel_Organization_Display(userStory);
            LinkLabel_Project_Display(userStory);
            Label_UserStory_Display(userStory);
            RichTextBox_Summary_Populate(userStory);
            RichTextBox_TaskList_Populate(userStory);
            TextBox_Category_Display(userStory);
        }
        #endregion Load

        #region Logic ==============================================
        private void CountStatuses()
        {
            Controller controller = new();
            List<string> statusList = controller.GetStatusList();
            foreach (string status in statusList)
            {
                int tagCount = CountStatus(status);
                DataGridView_TagCount_Display(status, tagCount);
            }
        }

        private int CountStatus(string status)
        {
            string taskList = RichTextBox_TaskList.Text;
            return taskList.Split(status).Length - 1;
        }
        #endregion Logic

        #region Populate ===========================================
        private void RichTextBox_Summary_Populate(UserStory userStory)
        {
            RichTextBox_Summary.Text = userStory.Summary;
        }

        private void RichTextBox_TaskList_Populate(UserStory userStory)
        {
            RichTextBox_TaskList.Text = userStory.TaskList;
        }
        #endregion Populate

        #region Save ===============================================
        private void SaveUserStory()
        {
            if (isLoading) return;
            UserStory userStory = _userStory;

            string categoryText = TextBox_Category.Text;
            string category = categoryText.Equals(PLACEHOLDER_CATEGORY) ? "" : categoryText;
            userStory.Category = category;

            string statusText = ComboBox_Status.Text;
            string status = statusText.Equals(ITEMS_STATUS_SELECT) ? "" : statusText;
            userStory.Status = status;

            string summary = RichTextBox_Summary.Text;
            userStory.Summary = summary;

            string taskList = RichTextBox_TaskList.Text;
            userStory.TaskList = taskList;

            DateTime? dueDate = DateTimePicker_Due.Checked ? DateTimePicker_Due.Value : null;
            userStory.DateDue = dueDate;

            DateTime? endDate = DateTimePicker_End.Checked ? DateTimePicker_End.Value : null;
            userStory.DateEnd = endDate;

            DateTime? startDate = DateTimePicker_Start.Checked ? DateTimePicker_Start.Value : null;
            userStory.DateStart = startDate;

            long id = userStory.Id;
            string fileName = $"{id}.json";
            string filePath = Path.Combine(_projectPath, fileName);

            Controller controller = new();
            controller.Save(userStory, filePath);
        }
        #endregion Save
    }
}