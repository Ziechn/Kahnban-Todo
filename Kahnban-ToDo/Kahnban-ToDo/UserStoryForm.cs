using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;

namespace Kahnban_ToDo
{
    public partial class UserStoryForm : Form
    {
        // CONSTANTS - TABLE LAYOUT PANELS
        private const int COLUMN_SIDEBAR_INDEX = 0;
        private const float COLUMN_SIDEBAR_SIZE = 250f;
        private const int ROW_SUMMARY_INDEX = 0;
        private const float ROW_SUMMARY_SIZE = 20f;
        private const int ROW_SUMMARY_TEXT_INDEX = 1;
        private const float ROW_SUMMARY_TEXT_SIZE = 120f;

        // Local Memory
        private long _id;
        private string _name = "";
        private string _organization = "";
        private string _project = "";
        private string _projectPath = "";
        private string _status = "";
        private List<string> tags = new List<string>();

        public UserStoryForm(UserStory userStory, string projectPath)
        {
            InitializeComponent();

            _id = userStory.Id;
            _name = userStory.Name;
            _organization = userStory.Organization;
            _project = userStory.Project;
            _projectPath = projectPath;
            _status = userStory.Status;

            LinkLabel_Organization_Display(userStory);
            LinkLabel_Project_Display(userStory);
            Label_UserStory_Display(userStory);
            RichTextBox_Summary_Populate(userStory);
            RichTextBox_TaskList_Populate(userStory);

            TagList_Initialize();
            DataGridView_TagCount_Initialize();
            CountTags();
        }

        #region Display ============================================
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
        #endregion Display

        #region Initialize =========================================
        private void DataGridView_TagCount_Initialize()
        {
            DataGridView_Status.Columns.Add("tag", "Tag");
            DataGridView_Status.Columns.Add("count", "Count");

            foreach (string tag in tags)
            {
                int tagCount = CountTag(tag);
                DataGridView_Status.Rows.Add(tag, tagCount);
            }
        }

        private void TagList_Initialize()
        {
            tags.Add("BUG");
            tags.Add("RFT");
            tags.Add("WIP");
            tags.Add("X");
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

        #region Interaction: RichTextBox ===========================
        private void RichTextBox_Summary_KeyUp(object sender, KeyEventArgs e)
        {
            SaveUserStory();
        }

        private void RichTextBox_TaskList_KeyUp(object sender, KeyEventArgs e)
        {
            SaveUserStory();
            CountTags();
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

        #region Logic ==============================================
        private void CountTags()
        {
            foreach (string tag in tags)
            {
                int tagCount = CountTag(tag);
                DataGridView_TagCount_Display(tag, tagCount);
            }
        }

        private int CountTag(string tagName)
        {
            string taskList = RichTextBox_TaskList.Text;
            return taskList.Split(tagName).Length - 1;
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
            UserStory userStory = new UserStory();
            userStory.Id = _id;
            userStory.Name = _name;
            userStory.Organization = _organization;
            userStory.Project = _project;
            userStory.Status = _status;

            string summary = RichTextBox_Summary.Text;
            userStory.Summary = summary;

            string taskList = RichTextBox_TaskList.Text;
            userStory.TaskList = taskList;

            string fileName = $"{_id}.json";
            string filePath = Path.Combine(_projectPath, fileName);

            Controller controller = new();
            controller.Save(userStory, filePath);
        }
        #endregion Save
    }
}