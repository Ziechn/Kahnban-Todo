using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kahnban_ToDo
{
    public partial class UserStoryForm : Form
    {
        // CONSTANTS - COMBOBOX
        private const string ITEMS_STATUS_PENDING = "PENDING";
        private const string ITEMS_STATUS_RELEASED = "RELEASED";
        private const string ITEMS_STATUS_SELECT = "Select Status...";

        // CONSTANTS - CONTACT METHOD
        private const string CONTACT_EMAIL = "EMAIL";
        private const string CONTACT_PHONE = "PHONE";

        // CONSTANTS - DATATABLEVIEW - References
        private const string HEADER_ID = "Id";
        private const string HEADER_TITLE = "Title";
        private const string HEADER_TYPE = "Type";

        // CONSTANTS - DATAGRIDVIEW - Status
        private const string COLUMN_COUNT = "count";
        private const string COLUMN_STATUS = "status";
        private const string HEADER_COUNT = "Count";
        private const string HEADER_STATUS = "Status";

        // CONSTANTS - PLACEHOLDERS
        private const string PLACEHOLDER_CATEGORY = "Enter Category...";
        private const string PLACEHOLDER_USERSTORY = "Enter a User Story...";
        private const string PLACEHOLDER_VERSION = "Enter Version...";

        // CONSTANTS - TABLE LAYOUT PANELS
        private const int COLUMN_SIDEBAR_INDEX = 0;
        private const float COLUMN_SIDEBAR_SIZE = 250f;
        private const int ROW_SUMMARY_INDEX = 0;
        private const float ROW_SUMMARY_SIZE = 20f;
        private const int ROW_SUMMARY_TEXT_INDEX = 1;
        private const float ROW_SUMMARY_TEXT_SIZE = 120f;

        // CONSTANTS - Reference Types
        private const string REFERENCE_FILE = "File";
        private const string REFERENCE_TEXT = "Text";

        // Constants - Status Counts
        private const string STATUS_COMPLETE = "COMPLETE";
        private const string TEXT_TASKS = "Tasks";

        // Local Memory
        string _projectPath = "";
        UserStory? _userStory;
        bool isLoading = true;

        public UserStoryForm()
        {
            InitializeComponent();
            ComboBox_Assignee_Initialize();
            ComboBox_Status_Initialize();
            DateTimePicker_End_Initialize();
            DateTimePicker_Start_Initialize();
            Label_Contact_Display();

            Project? project = AppStore.project;
            long projectId = project?.Id ?? -1;
            _projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());

            Label_TaskList_Display();
            LinkLabel_Organization_Display(project);
            LinkLabel_Project_Display(project);

            TextBox_Category_DiplayPlaceholder();
            TextBox_UserStoryName_Display();
            TextBox_Version_Display();

            Controls_State();

            isLoading = false;
        }

        public UserStoryForm(long id)
        {
            InitializeComponent();
            ComboBox_Assignee_Initialize();
            ComboBox_Status_Initialize();
            DateTimePicker_End_Initialize();
            DateTimePicker_Start_Initialize();
            Label_Contact_Display();

            long projectId = AppStore.project?.Id ?? -1;
            _projectPath = Path.Combine(AppStore.organizationPath, projectId.ToString());

            UserStory_Load(id);

            Label_TaskList_Display();
            TextBox_Category_DiplayPlaceholder();
            TextBox_Version_Display();
            References_Load(id);

            Controls_State();

            isLoading = false;
        }

        #region Display ============================================
        private void ComboBox_Assignee_Display(UserStory userStory)
        {
            long assigneeId = userStory.AssigneeId ?? 0;
            if (assigneeId <= 0)
            {
                ComboBox_Assignee.SelectedIndex = 0;
                return;
            }

            ComboBox_Assignee.SelectedValue = assigneeId;
        }
        
        private void ComboBox_Status_Display(UserStory userStory)
        {
            ComboBox_Status.Text = userStory.Status;
        }

        private void Label_TaskList_Display()
        {
            string taskList = RichTextBox_TaskList.Text.ToUpper();

            int taskCount = 0;
            if (taskList.Length > 0)
            {
                taskCount = taskList.Split('\n').Count(line => string.IsNullOrWhiteSpace(line) == false);
            }

            // Count completed tasks.
            Controller controller = new();
            List<StatusCount> statusCounts = controller.CountStatuses(taskList);
            int completeCount = statusCounts.FirstOrDefault(statusCount => statusCount.Status.Equals(STATUS_COMPLETE))?.Count ?? 0;
            taskCount -= completeCount;

            if (taskCount < 0) taskCount = 0;

            Label_TaskList.Text = $"{TEXT_TASKS} (remaining: {taskCount})";
        }

        private void DataGridView_References_Display(DataTable dataTable)
        {
            DataGridView_References.DataSource = dataTable;
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

        private void Label_Contact_Display(Contact? contact = null)
        {
            string text = "";

            if (contact == null)
            {
                Controller controller = new();
                List<Contact> contacts = new List<Contact>();

                try
                {
                    contacts = controller.ReadContacts();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return;
                }

                Contact? selectedContact = ComboBox_Assignee.SelectedItem as Contact;
                if (selectedContact == null)
                {
                    Label_Contact.Text = "";
                    return;
                }

                contact = selectedContact;
            }

            string primaryContactMethod = contact.PrimaryContactMethod;

            bool isEmptyContact = primaryContactMethod.Equals("");
            bool isEmailContact = primaryContactMethod.ToUpper().Contains(CONTACT_EMAIL);
            bool isPhoneContact = primaryContactMethod.ToUpper().Contains(CONTACT_PHONE);

            if (isEmptyContact)
            {
                text = "";
            }
            else if (isPhoneContact)
            {
                string phoneNumber = contact.PhoneNumber;
                text = $"Phone Number: {phoneNumber}";
            }
            else if (isEmailContact)
            {
                string email = contact.Email;
                text = $"email: {email}";
            }
            else
            {
                string primaryContact = contact.PrimaryContact;
                text = $"{primaryContactMethod} (username): {primaryContact}";
            }

            Label_Contact.Text = text;
        }

        private void LinkLabel_Organization_Display(Project? project)
        {
            if (project == null) return;
            LinkLabel_Organization.Text = project.Organization;
        }

        private void LinkLabel_Organization_Display(UserStory userStory)
        {
            LinkLabel_Organization.Text = userStory.Organization;
        }

        private void LinkLabel_Project_Display(Project? project)
        {
            if (project == null) return;
            LinkLabel_Project.Text = project.Name;
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

        private void TextBox_UserStoryName_Display(UserStory? userStory = null)
        {
            if (userStory == null)
            {
                FormUtilities.DisplayPlaceholder(TextBox_UserStoryName, PLACEHOLDER_USERSTORY);
                return;
            }

            string userStoryName = userStory.Name;
            TextBox_UserStoryName.Text = userStoryName;
        }

        private void TextBox_Version_Display(UserStory? userStory = null)
        {
            if (userStory == null)
            {
                FormUtilities.DisplayPlaceholder(TextBox_Version, PLACEHOLDER_VERSION);
                return;
            }

            string version = userStory.Version;
            TextBox_Version.Text = version;
        }
        #endregion Display

        #region Event Handlers =====================================
        private void DataGridView_References_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView_References.Columns[HEADER_ID]?.Visible = false;
        }
        #endregion Event Handlers

        #region Initialize =========================================
        private void ComboBox_Assignee_Initialize()
        {
            ComboBox_Assignee.Items.Clear();
            List<Contact> contacts = new List<Contact>();
            Contact contact = new(
                "",
                -1,
                "Select an Assignee...",
                "",
                "",
                ""
                );

            contacts.Add(contact);

            Controller controller = new();
            try
            {
                List<Contact> contactsToAdd = controller.ReadContacts();
                contacts.AddRange(contactsToAdd);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return;
            }

            if (contacts.Count < 1) return;

            ComboBox_Assignee.DataSource = contacts;
            ComboBox_Assignee.DisplayMember = "Name";
            ComboBox_Assignee.ValueMember = "Id";

            ComboBox_Assignee.SelectedIndex = 0;
        }

        private void ComboBox_Status_Initialize()
        {
            ComboBox_Status.Items.Clear();
            ComboBox_Status.Items.Add(ITEMS_STATUS_SELECT);

            Controller controller = new();
            List<string> statusList = controller.GetStatusList();
            int selectedIndex = 0;

            for (int i = 0; i < statusList.Count; i++)
            {
                string status = statusList[i];
                ComboBox_Status.Items.Add(status);

                if (status.Equals(ITEMS_STATUS_PENDING) == false) continue;
                selectedIndex = i + 1;
            }

            ComboBox_Status.SelectedIndex = selectedIndex;
        }

        private void Controls_State()
        {
            // Determine user story editable state based on the status and user story
            string userStoryNameText = TextBox_UserStoryName.Text;
            string userStoryName = userStoryNameText.Equals(PLACEHOLDER_USERSTORY) ? "" : userStoryNameText;
            bool hasUserStoryName = userStoryName.Equals("") == false;

            string status = ComboBox_Status.Text;
            bool isInProgress = status.Equals(ITEMS_STATUS_RELEASED) == false;

            Button_AddMedia.Enabled = isInProgress && hasUserStoryName;
            Button_AddText.Enabled = isInProgress && hasUserStoryName;
            ComboBox_Assignee.Enabled = isInProgress && hasUserStoryName;
            DateTimePicker_End.Enabled = isInProgress && hasUserStoryName;
            DateTimePicker_Start.Enabled = isInProgress && hasUserStoryName;
            TextBox_Category.Enabled = isInProgress && hasUserStoryName;
            TextBox_Version.Enabled = isInProgress && hasUserStoryName;
            RichTextBox_Summary.Enabled = isInProgress && hasUserStoryName;
            RichTextBox_TaskList.Enabled = isInProgress && hasUserStoryName;

            // This can be edited even if the project is set to "RELEASED"
            ComboBox_Status.Enabled = hasUserStoryName;

            // This can only be edited if this is in progress
            TextBox_UserStoryName.Enabled = isInProgress;
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

        private void Button_AddText_Click(object sender, EventArgs e)
        {
            long userStoryId = _userStory.Id;
            TextReferenceForm textReferenceForm = new TextReferenceForm(userStoryId);
            textReferenceForm.ShowDialog();

            References_Load(userStoryId);
        }

        private void Button_AddMedia_Click(object sender, EventArgs e)
        {
            long userStoryId = _userStory.Id;
            FileReferenceForm fileReferenceForm = new FileReferenceForm(userStoryId);
            fileReferenceForm.ShowDialog();

            References_Load(userStoryId);
        }
        #endregion Interaction: Buttons

        #region Interaction: ComboBox ==============================
        private void ComboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveUserStory();
            Controls_State();
        }

        private void ComboBox_Assignee_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveUserStory();

            Contact? contact = ComboBox_Assignee.SelectedItem as Contact;
            Label_Contact_Display(contact);
        }
        #endregion Interaction: ComboBox

        #region Interaction: DataGridView ==========================
        private void DataGridView_References_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            DataGridViewRow row = DataGridView_References.Rows[rowIndex];
            if (row == null) return;

            long referenceId = DataGridViewUtilities.GetCellValue_Long(row, HEADER_ID);
            if (referenceId < 0) return;

            string referenceType = DataGridViewUtilities.GetCellValue_String(row, HEADER_TYPE);
            if (string.IsNullOrEmpty(referenceType)) return;

            long userStoryId = _userStory.Id;

            bool isTextReference = referenceType.Equals(REFERENCE_TEXT);
            if (isTextReference)
            {
                TextReferenceForm textReferenceForm = new TextReferenceForm(userStoryId, referenceId);
                textReferenceForm.ShowDialog(this);
            }

            bool isFileReference = referenceType.Equals(REFERENCE_FILE);
            if (isFileReference)
            {
                // Find the file
                string organizaitonPath = AppStore.organizationPath;
                string projectId = AppStore.project?.Id.ToString() ?? "";
                string userStoryIdString = _userStory.Id.ToString();

                string path = Path.Combine(organizaitonPath, projectId, userStoryIdString);

                FileReference? fileReference = null;
                Controller controller = new();
                try
                {
                    fileReference = controller.ReadObject<FileReference>(path, referenceId);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception);
                    return;
                }

                if (fileReference == null) return;

                string fileName = fileReference.FileName;
                string filePath = Path.Combine(path, fileName);

                // Open the file using windows.
                Process.Start(
                    new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
            }

            References_Load(_userStory.Id);
        }
        #endregion Interaction: DataGridView

        #region Interaction: DateTimePicker ========================
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
            Label_TaskList_Display();
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
            ProjectDetailsForm projectForm = new ProjectDetailsForm();
            FormUtilities.NavigateTo(projectForm);
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

        private void TextBox_UserStoryName_Enter(object sender, EventArgs e)
        {
            FormUtilities.DisplayPlaceholder(TextBox_UserStoryName, PLACEHOLDER_USERSTORY);
        }

        private void TextBox_UserStoryName_KeyUp(object sender, KeyEventArgs e)
        {
            SaveUserStory();
            Controls_State();
        }

        private void TextBox_UserStoryName_Leave(object sender, EventArgs e)
        {
            FormUtilities.DisplayPlaceholder(TextBox_UserStoryName, PLACEHOLDER_USERSTORY);
        }

        private void TextBox_Version_Enter(object sender, EventArgs e)
        {
            FormUtilities.DisplayPlaceholder(TextBox_Version, PLACEHOLDER_VERSION);
        }

        private void TextBox_Version_KeyUp(object sender, KeyEventArgs e)
        {
            SaveUserStory();
        }

        private void TextBox_Version_Leave(object sender, EventArgs e)
        {
            FormUtilities.DisplayPlaceholder(TextBox_Version, PLACEHOLDER_VERSION);
        }
        #endregion Interaction: TextBox

        #region Load ===============================================
        private void References_Load(long id)
        {
            string idString = id.ToString();
            string organizationPath = AppStore.organizationPath;
            string projectId = AppStore.project?.Id.ToString() ?? "";

            string filePath = Path.Combine(organizationPath, projectId, idString);

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(HEADER_ID);
            dataTable.Columns.Add(HEADER_TITLE);
            dataTable.Columns.Add(HEADER_TYPE);

            Controller controller = new();
            List<string> jsonFiles = controller.GetFiles(filePath);
            foreach (string jsonFile in jsonFiles)
            {
                string json = File.ReadAllText(jsonFile);
                Reference? reference = JsonSerializer.Deserialize<Reference>(json);
                if (reference == null) continue;

                if (reference is TextReference textReference)
                {
                    dataTable.Rows.Add(
                        textReference.Id,
                        textReference.Title,
                        REFERENCE_TEXT
                        );
                }

                if (reference is FileReference fileReference)
                {
                    dataTable.Rows.Add(
                        fileReference.Id,
                        fileReference.Title,
                        REFERENCE_FILE
                        );
                }
            }

            if (dataTable.Rows.Count == 0) return;
            DataGridView_References_Display(dataTable);
        }

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

            ComboBox_Assignee_Display(userStory);
            ComboBox_Status_Display(userStory);
            DateTimePicker_End_Display(userStory);
            DateTimePicker_Start_Display(userStory);
            LinkLabel_Organization_Display(userStory);
            LinkLabel_Project_Display(userStory);
            RichTextBox_Summary_Populate(userStory);
            RichTextBox_TaskList_Populate(userStory);
            TextBox_Category_Display(userStory);
            TextBox_UserStoryName_Display(userStory);
            TextBox_Version_Display(userStory);

            Label_Contact_Display();
        }
        #endregion Load

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

            Controller controller = new();
            UserStory? userStory = null;

            long id = -1;

            if (_userStory == null)
            {
                userStory = new UserStory();
                id = controller.GenerateId();
                userStory.Id = id;

                Project? project = AppStore.project;
                string organization = project.Organization;
                userStory.Organization = organization;

                string projectName = project.Name;
                userStory.Project = projectName;
            }
            else
            {
                userStory = _userStory;
                id = userStory.Id;
            }

            if (userStory == null) return;

            string userStoryNameText = TextBox_UserStoryName.Text;
            string userStoryName = userStoryNameText.Equals(PLACEHOLDER_USERSTORY) ? "" : userStoryNameText;
            userStory.Name = userStoryName;

            string categoryText = TextBox_Category.Text;
            string category = categoryText.Equals(PLACEHOLDER_CATEGORY) ? "" : categoryText;
            userStory.Category = category;

            string statusText = ComboBox_Status.Text;
            string status = statusText.Equals(ITEMS_STATUS_SELECT) ? "" : statusText;
            userStory.Status = status;

            string versionText = TextBox_Version.Text;
            string version = versionText.Equals(PLACEHOLDER_VERSION) ? "" : versionText;
            userStory.Version = version;

            string summary = RichTextBox_Summary.Text;
            userStory.Summary = summary;

            string taskList = RichTextBox_TaskList.Text;
            userStory.TaskList = taskList;

            DateTime? endDate = DateTimePicker_End.Checked ? DateTimePicker_End.Value : null;
            userStory.DateEnd = endDate;

            DateTime? startDate = DateTimePicker_Start.Checked ? DateTimePicker_Start.Value : null;
            userStory.DateStart = startDate;

            long assigneeId = (long?)ComboBox_Assignee.SelectedValue ?? -1;
            userStory.AssigneeId = assigneeId;

            try
            {
                controller.CreateDirectory(_projectPath, id);
                controller.Save(userStory, _projectPath, id);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }

            if (_userStory != null) return;
            try
            {
                _userStory = controller.GetUserStory(_projectPath, id);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
        #endregion Save
    }
}