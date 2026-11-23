using System.Data;
using System.Diagnostics;
using System.Text.Json;

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
        bool isLoading = true;
        long _projectId = -1;
        long _userStoryId = -1;

        public UserStoryForm(long projectId)
        {
            InitializeComponent();

            _projectId = projectId;

            ComboBox_Assignee_Initialize();
            ComboBox_Status_Initialize();
            DateTimePicker_End_Initialize();
            DateTimePicker_Start_Initialize();
            Label_Contact_Display();

            Label_TaskList_Display();
            LinkLabel_Organization_Display();
            LinkLabel_Project_Display();

            TextBox_Category_DiplayPlaceholder();
            TextBox_UserStoryName_Display();
            TextBox_Version_Display();

            Controls_State();
            LinkLabel_DisableTabStop();

            EventBus.Subscribe(EventEnum.OnContactManaged, HandleOnContactManaged);

            isLoading = false;
        }

        public UserStoryForm(long projectId, long userStoryId)
        {
            InitializeComponent();

            _projectId = projectId;
            _userStoryId= userStoryId;

            ComboBox_Assignee_Initialize();
            ComboBox_Status_Initialize();
            DateTimePicker_End_Initialize();
            DateTimePicker_Start_Initialize();
            Label_Contact_Display();

            UserStory_Load();

            LinkLabel_Organization_Display();
            LinkLabel_Project_Display();

            Label_TaskList_Display();
            TextBox_Category_DiplayPlaceholder();
            TextBox_Version_Display();
            References_Load();

            Controls_State();
            LinkLabel_DisableTabStop();

            EventBus.Subscribe(EventEnum.OnContactManaged, HandleOnContactManaged);

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

        private void LinkLabel_Organization_Display()
        {
            LinkLabel_Organization.Text = AppStore.organization;
        }

        private void LinkLabel_Project_Display()
        {
            Project? project = Project_Read();
            LinkLabel_Project.Text = project != null ? project.Name : "Error";
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

        private void UserStoryForm_Load(object sender, EventArgs e)
        {
            TextBox_UserStoryName.Focus();
            TextBox_UserStoryName.Select(TextBox_UserStoryName.TextLength, 0);
        }

        private void HandleOnContactManaged()
        {
            ComboBox_Assignee_Initialize();
        }
        #endregion Event Handlers

        #region Initialize =========================================
        private void ComboBox_Assignee_Initialize()
        {
            ComboBox_Assignee.DataSource = null;
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
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            // Get the reference ID
            int rowIndex = DataGridView_References.SelectedCells[0].RowIndex;
            if (rowIndex < 0) return;

            DataGridViewRow row = DataGridView_References.Rows[rowIndex];
            if (row == null) return;

            long referenceId = DataGridViewUtilities.GetCellValue_Long(row, HEADER_ID);
            string referenceTitle = DataGridViewUtilities.GetCellValue_String(row, HEADER_TITLE);

            DialogResult result = MessageBox.Show(
                $"Delete {referenceTitle}?",
                "Are you sure?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.No) return;

            // Get the path
            string projectPath = AppStore.projectPath;
            string userStoryId = _userStoryId.ToString();
            string userStoryPath = Path.Combine(projectPath, userStoryId);

            // Delete the reference
            Controller controller = new();
            controller.DeleteReference(userStoryPath, referenceId);

            // Refresh the reference DataGridView
            References_Load();
            Button_Delete_State();
        }

        private void Button_Delete_State(bool isEnabled = false)
        {
            Button_Delete.Enabled = isEnabled;
        }

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
            TextReferenceForm textReferenceForm = new TextReferenceForm(_userStoryId);
            textReferenceForm.ShowDialog();

            References_Load();
        }

        private void Button_AddMedia_Click(object sender, EventArgs e)
        {
            FileReferenceForm fileReferenceForm = new FileReferenceForm(_userStoryId);
            fileReferenceForm.ShowDialog();

            References_Load();
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
        private void DataGridView_References_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                Button_Delete_State();
                return;
            }

            DataGridViewRow row = DataGridView_References.Rows[rowIndex];
            if (row == null)
            {
                Button_Delete_State();
                return;
            }

            long referenceId = DataGridViewUtilities.GetCellValue_Long(row, HEADER_ID);
            bool isReferenceIdValid = referenceId >= 0;

            Button_Delete_State(isReferenceIdValid);
        }

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

            bool isTextReference = referenceType.Equals(REFERENCE_TEXT);
            if (isTextReference)
            {
                TextReferenceForm textReferenceForm = new TextReferenceForm(_userStoryId, referenceId);
                textReferenceForm.ShowDialog(this);
            }

            bool isFileReference = referenceType.Equals(REFERENCE_FILE);
            if (isFileReference)
            {
                // Find the file
                string userStoryId = _userStoryId.ToString();
                string projectPath = AppStore.projectPath;
                string userStoryPath = Path.Combine(projectPath, userStoryId);

                FileReference? fileReference = null;
                Controller controller = new();
                try
                {
                    fileReference = controller.ReadObject<FileReference>(userStoryPath, referenceId);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception);
                    return;
                }

                if (fileReference == null) return;

                string fileName = fileReference.FileName;
                string filePath = Path.Combine(userStoryPath, fileName);

                // Open the file using windows.
                Process.Start(
                    new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
            }

            References_Load();
        }

        private void DataGridView_References_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            toolTip_dataGridView_references.Hide(DataGridView_References);
        }

        private void DataGridView_References_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            bool isValidRow = rowIndex >= 0;
            bool isColumnValid = columnIndex >= 0;

            if (isValidRow && isColumnValid)
            {
                Point point = DataGridView_References.PointToClient(Cursor.Position);
                toolTip_dataGridView_references.Show(
                    AppProperties.TOOLTIP_MESSAGE_DATAGRIDVIEW,
                    DataGridView_References,
                    point.X + AppProperties.TOOLTIP_OFFSET.x,
                    point.Y + AppProperties.TOOLTIP_OFFSET.y
                    );
            }
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
        private void LinkLabel_DisableTabStop()
        {
            LinkLabel_Organization.TabStop = false;
            LinkLabel_Project.TabStop = false;
            LinkLabel_Start.TabStop = false;
        }

        private void LinkLabel_Organization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventBus.Unsubscribe(EventEnum.OnContactManaged, HandleOnContactManaged);

            OrganizationForm organizationForm = new OrganizationForm();
            FormUtilities.NavigateTo(organizationForm);
        }

        private void LinkLabel_Project_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventBus.Unsubscribe(EventEnum.OnContactManaged, HandleOnContactManaged);

            ProjectDetailsForm projectForm = new ProjectDetailsForm(_projectId);
            FormUtilities.NavigateTo(projectForm);
        }

        private void LinkLabel_Start_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controller controller = new();
            controller.ResetStore_Start();

            EventBus.Unsubscribe(EventEnum.OnContactManaged, HandleOnContactManaged);

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
        private void References_Load()
        {
            string userStoryId = _userStoryId.ToString();
            string projectPath = AppStore.projectPath;
            string filePath = Path.Combine(projectPath, userStoryId);

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

            DataGridView_References_Display(dataTable);
        }

        private void UserStory_Load()
        {
            string projectPath = AppStore.projectPath;

            Controller controller = new();
            UserStory? userStory = controller.GetUserStory(projectPath, _userStoryId);
            if (userStory == null)
            {
                Debug.WriteLine("Error loading User Story");
                return;
            }

            ComboBox_Assignee_Display(userStory);
            ComboBox_Status_Display(userStory);
            DateTimePicker_End_Display(userStory);
            DateTimePicker_Start_Display(userStory);
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
            UserStory userStory = new();

            long userStoryId = _userStoryId;
            if (userStoryId < 0)
            {
                userStoryId = controller.GenerateId();
                _userStoryId = userStoryId;
            }

            userStory.Id = userStoryId;

            string organization = AppStore.organization;
            userStory.Organization = organization;

            Project? project = Project_Read();
            string projectName = project != null ? project.Name : "";
            userStory.Project = projectName;

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

            string projectPath = AppStore.projectPath;
            try
            {
                controller.CreateDirectory(projectPath, userStoryId);
                controller.Save(userStory, projectPath, userStoryId);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
        #endregion Save

        #region Read ===============================================
        private Project? Project_Read()
        {
            Controller controller = new();
            return controller.ReadObject<Project>(AppStore.organizationPath, _projectId);
        }
        #endregion Read
    }
}