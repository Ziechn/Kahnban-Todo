namespace Kahnban_ToDo
{
    partial class UserStoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableLayoutPanel_Body = new TableLayoutPanel();
            FlowLayoutPanel_Navigation = new FlowLayoutPanel();
            LinkLabel_Start = new LinkLabel();
            label_navigation_separator1 = new Label();
            LinkLabel_Organization = new LinkLabel();
            label_navigation_separator2 = new Label();
            LinkLabel_Project = new LinkLabel();
            label_navigation_separator3 = new Label();
            TextBox_UserStoryName = new TextBox();
            FlowLayoutPanel_Controls = new FlowLayoutPanel();
            Button_SideBar = new Button();
            Button_Summary = new Button();
            TableLayoutPanel_Content = new TableLayoutPanel();
            TableLayoutPanel_SideBar = new TableLayoutPanel();
            DataGridView_References = new DataGridView();
            panel_referenceControls = new Panel();
            Button_AddMedia = new Button();
            Button_AddText = new Button();
            Label_References = new Label();
            Label_Contact = new Label();
            flowLayoutPanel_assignee = new FlowLayoutPanel();
            ComboBox_Assignee = new ComboBox();
            label_assignee = new Label();
            flowLayoutPanel_dateEnd = new FlowLayoutPanel();
            DateTimePicker_End = new DateTimePicker();
            label_end = new Label();
            flowLayoutPanel_dateStart = new FlowLayoutPanel();
            DateTimePicker_Start = new DateTimePicker();
            label_start = new Label();
            flowLayoutPanel_version = new FlowLayoutPanel();
            TextBox_Version = new TextBox();
            label_version = new Label();
            flowLayoutPanel_status = new FlowLayoutPanel();
            ComboBox_Status = new ComboBox();
            label_status = new Label();
            flowLayoutPanel_category = new FlowLayoutPanel();
            TextBox_Category = new TextBox();
            label_category = new Label();
            TableLayoutPanel_UserStory = new TableLayoutPanel();
            RichTextBox_Summary = new RichTextBox();
            RichTextBox_TaskList = new RichTextBox();
            Label_Summary = new Label();
            Label_TaskList = new Label();
            TableLayoutPanel_Body.SuspendLayout();
            FlowLayoutPanel_Navigation.SuspendLayout();
            FlowLayoutPanel_Controls.SuspendLayout();
            TableLayoutPanel_Content.SuspendLayout();
            TableLayoutPanel_SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_References).BeginInit();
            panel_referenceControls.SuspendLayout();
            flowLayoutPanel_assignee.SuspendLayout();
            flowLayoutPanel_dateEnd.SuspendLayout();
            flowLayoutPanel_dateStart.SuspendLayout();
            flowLayoutPanel_version.SuspendLayout();
            flowLayoutPanel_status.SuspendLayout();
            flowLayoutPanel_category.SuspendLayout();
            TableLayoutPanel_UserStory.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel_Body
            // 
            TableLayoutPanel_Body.ColumnCount = 1;
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.Controls.Add(FlowLayoutPanel_Navigation, 0, 0);
            TableLayoutPanel_Body.Controls.Add(FlowLayoutPanel_Controls, 0, 1);
            TableLayoutPanel_Body.Controls.Add(TableLayoutPanel_Content, 0, 2);
            TableLayoutPanel_Body.Dock = DockStyle.Fill;
            TableLayoutPanel_Body.Location = new Point(0, 0);
            TableLayoutPanel_Body.Name = "TableLayoutPanel_Body";
            TableLayoutPanel_Body.RowCount = 4;
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Body.Size = new Size(984, 561);
            TableLayoutPanel_Body.TabIndex = 0;
            // 
            // FlowLayoutPanel_Navigation
            // 
            FlowLayoutPanel_Navigation.Controls.Add(LinkLabel_Start);
            FlowLayoutPanel_Navigation.Controls.Add(label_navigation_separator1);
            FlowLayoutPanel_Navigation.Controls.Add(LinkLabel_Organization);
            FlowLayoutPanel_Navigation.Controls.Add(label_navigation_separator2);
            FlowLayoutPanel_Navigation.Controls.Add(LinkLabel_Project);
            FlowLayoutPanel_Navigation.Controls.Add(label_navigation_separator3);
            FlowLayoutPanel_Navigation.Controls.Add(TextBox_UserStoryName);
            FlowLayoutPanel_Navigation.Dock = DockStyle.Fill;
            FlowLayoutPanel_Navigation.Location = new Point(0, 0);
            FlowLayoutPanel_Navigation.Margin = new Padding(0);
            FlowLayoutPanel_Navigation.Name = "FlowLayoutPanel_Navigation";
            FlowLayoutPanel_Navigation.Size = new Size(984, 30);
            FlowLayoutPanel_Navigation.TabIndex = 1;
            // 
            // LinkLabel_Start
            // 
            LinkLabel_Start.AutoSize = true;
            LinkLabel_Start.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel_Start.LinkColor = Color.DodgerBlue;
            LinkLabel_Start.Location = new Point(3, 0);
            LinkLabel_Start.Name = "LinkLabel_Start";
            LinkLabel_Start.Size = new Size(56, 25);
            LinkLabel_Start.TabIndex = 5;
            LinkLabel_Start.TabStop = true;
            LinkLabel_Start.Text = "Start";
            LinkLabel_Start.LinkClicked += LinkLabel_Start_LinkClicked;
            // 
            // label_navigation_separator1
            // 
            label_navigation_separator1.AutoSize = true;
            label_navigation_separator1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_navigation_separator1.Location = new Point(65, 0);
            label_navigation_separator1.Name = "label_navigation_separator1";
            label_navigation_separator1.Size = new Size(20, 25);
            label_navigation_separator1.TabIndex = 6;
            label_navigation_separator1.Text = "/";
            // 
            // LinkLabel_Organization
            // 
            LinkLabel_Organization.AutoSize = true;
            LinkLabel_Organization.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel_Organization.LinkColor = Color.DodgerBlue;
            LinkLabel_Organization.Location = new Point(91, 0);
            LinkLabel_Organization.Name = "LinkLabel_Organization";
            LinkLabel_Organization.Size = new Size(126, 25);
            LinkLabel_Organization.TabIndex = 0;
            LinkLabel_Organization.TabStop = true;
            LinkLabel_Organization.Text = "organization";
            LinkLabel_Organization.LinkClicked += LinkLabel_Organization_LinkClicked;
            // 
            // label_navigation_separator2
            // 
            label_navigation_separator2.AutoSize = true;
            label_navigation_separator2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_navigation_separator2.Location = new Point(220, 0);
            label_navigation_separator2.Margin = new Padding(0);
            label_navigation_separator2.Name = "label_navigation_separator2";
            label_navigation_separator2.Size = new Size(20, 25);
            label_navigation_separator2.TabIndex = 1;
            label_navigation_separator2.Text = "/";
            // 
            // LinkLabel_Project
            // 
            LinkLabel_Project.AutoSize = true;
            LinkLabel_Project.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel_Project.LinkColor = Color.DodgerBlue;
            LinkLabel_Project.Location = new Point(243, 0);
            LinkLabel_Project.Name = "LinkLabel_Project";
            LinkLabel_Project.Size = new Size(75, 25);
            LinkLabel_Project.TabIndex = 2;
            LinkLabel_Project.TabStop = true;
            LinkLabel_Project.Text = "project";
            LinkLabel_Project.LinkClicked += LinkLabel_Project_LinkClicked;
            // 
            // label_navigation_separator3
            // 
            label_navigation_separator3.AutoSize = true;
            label_navigation_separator3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_navigation_separator3.Location = new Point(321, 0);
            label_navigation_separator3.Margin = new Padding(0);
            label_navigation_separator3.Name = "label_navigation_separator3";
            label_navigation_separator3.Size = new Size(20, 25);
            label_navigation_separator3.TabIndex = 3;
            label_navigation_separator3.Text = "/";
            // 
            // TextBox_UserStoryName
            // 
            TextBox_UserStoryName.Location = new Point(344, 3);
            TextBox_UserStoryName.Name = "TextBox_UserStoryName";
            TextBox_UserStoryName.Size = new Size(200, 23);
            TextBox_UserStoryName.TabIndex = 7;
            TextBox_UserStoryName.Enter += TextBox_UserStoryName_Enter;
            TextBox_UserStoryName.KeyUp += TextBox_UserStoryName_KeyUp;
            TextBox_UserStoryName.Leave += TextBox_UserStoryName_Leave;
            // 
            // FlowLayoutPanel_Controls
            // 
            FlowLayoutPanel_Controls.Controls.Add(Button_SideBar);
            FlowLayoutPanel_Controls.Controls.Add(Button_Summary);
            FlowLayoutPanel_Controls.Dock = DockStyle.Fill;
            FlowLayoutPanel_Controls.Location = new Point(3, 33);
            FlowLayoutPanel_Controls.Name = "FlowLayoutPanel_Controls";
            FlowLayoutPanel_Controls.Size = new Size(978, 29);
            FlowLayoutPanel_Controls.TabIndex = 0;
            // 
            // Button_SideBar
            // 
            Button_SideBar.Location = new Point(3, 3);
            Button_SideBar.Name = "Button_SideBar";
            Button_SideBar.Size = new Size(100, 23);
            Button_SideBar.TabIndex = 5;
            Button_SideBar.Text = "Side Bar";
            Button_SideBar.UseVisualStyleBackColor = true;
            Button_SideBar.Click += Button_SideBar_Click;
            // 
            // Button_Summary
            // 
            Button_Summary.Location = new Point(109, 3);
            Button_Summary.Name = "Button_Summary";
            Button_Summary.Size = new Size(100, 23);
            Button_Summary.TabIndex = 4;
            Button_Summary.Text = "Summary";
            Button_Summary.UseVisualStyleBackColor = true;
            Button_Summary.Click += Button_Summary_Click;
            // 
            // TableLayoutPanel_Content
            // 
            TableLayoutPanel_Content.ColumnCount = 2;
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_SideBar, 0, 0);
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_UserStory, 1, 0);
            TableLayoutPanel_Content.Dock = DockStyle.Fill;
            TableLayoutPanel_Content.Location = new Point(0, 65);
            TableLayoutPanel_Content.Margin = new Padding(0);
            TableLayoutPanel_Content.Name = "TableLayoutPanel_Content";
            TableLayoutPanel_Content.RowCount = 1;
            TableLayoutPanel_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.Size = new Size(984, 476);
            TableLayoutPanel_Content.TabIndex = 2;
            // 
            // TableLayoutPanel_SideBar
            // 
            TableLayoutPanel_SideBar.ColumnCount = 1;
            TableLayoutPanel_SideBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_SideBar.Controls.Add(DataGridView_References, 0, 8);
            TableLayoutPanel_SideBar.Controls.Add(panel_referenceControls, 0, 9);
            TableLayoutPanel_SideBar.Controls.Add(Label_References, 0, 7);
            TableLayoutPanel_SideBar.Controls.Add(Label_Contact, 0, 6);
            TableLayoutPanel_SideBar.Controls.Add(flowLayoutPanel_assignee, 0, 5);
            TableLayoutPanel_SideBar.Controls.Add(flowLayoutPanel_dateEnd, 0, 4);
            TableLayoutPanel_SideBar.Controls.Add(flowLayoutPanel_dateStart, 0, 3);
            TableLayoutPanel_SideBar.Controls.Add(flowLayoutPanel_version, 0, 2);
            TableLayoutPanel_SideBar.Controls.Add(flowLayoutPanel_status, 0, 1);
            TableLayoutPanel_SideBar.Controls.Add(flowLayoutPanel_category, 0, 0);
            TableLayoutPanel_SideBar.Dock = DockStyle.Fill;
            TableLayoutPanel_SideBar.Location = new Point(3, 3);
            TableLayoutPanel_SideBar.Name = "TableLayoutPanel_SideBar";
            TableLayoutPanel_SideBar.RowCount = 10;
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TableLayoutPanel_SideBar.Size = new Size(244, 470);
            TableLayoutPanel_SideBar.TabIndex = 3;
            // 
            // DataGridView_References
            // 
            DataGridView_References.AllowUserToAddRows = false;
            DataGridView_References.AllowUserToDeleteRows = false;
            DataGridView_References.AllowUserToResizeColumns = false;
            DataGridView_References.AllowUserToResizeRows = false;
            DataGridView_References.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_References.BackgroundColor = SystemColors.ControlDarkDark;
            DataGridView_References.BorderStyle = BorderStyle.None;
            DataGridView_References.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_References.Dock = DockStyle.Fill;
            DataGridView_References.Location = new Point(3, 253);
            DataGridView_References.Name = "DataGridView_References";
            DataGridView_References.ReadOnly = true;
            DataGridView_References.RowHeadersVisible = false;
            DataGridView_References.ShowCellToolTips = false;
            DataGridView_References.Size = new Size(238, 184);
            DataGridView_References.TabIndex = 0;
            DataGridView_References.CellDoubleClick += DataGridView_References_CellDoubleClick;
            DataGridView_References.DataBindingComplete += DataGridView_References_DataBindingComplete;
            // 
            // panel_referenceControls
            // 
            panel_referenceControls.Controls.Add(Button_AddMedia);
            panel_referenceControls.Controls.Add(Button_AddText);
            panel_referenceControls.Dock = DockStyle.Fill;
            panel_referenceControls.Location = new Point(0, 440);
            panel_referenceControls.Margin = new Padding(0);
            panel_referenceControls.Name = "panel_referenceControls";
            panel_referenceControls.Size = new Size(244, 30);
            panel_referenceControls.TabIndex = 2;
            // 
            // Button_AddMedia
            // 
            Button_AddMedia.Location = new Point(3, 4);
            Button_AddMedia.Name = "Button_AddMedia";
            Button_AddMedia.Size = new Size(115, 23);
            Button_AddMedia.TabIndex = 0;
            Button_AddMedia.Text = "Add Media";
            Button_AddMedia.UseVisualStyleBackColor = true;
            Button_AddMedia.Click += Button_AddMedia_Click;
            // 
            // Button_AddText
            // 
            Button_AddText.Location = new Point(126, 4);
            Button_AddText.Name = "Button_AddText";
            Button_AddText.Size = new Size(115, 23);
            Button_AddText.TabIndex = 1;
            Button_AddText.Text = "Add Text";
            Button_AddText.UseVisualStyleBackColor = true;
            Button_AddText.Click += Button_AddText_Click;
            // 
            // Label_References
            // 
            Label_References.Dock = DockStyle.Fill;
            Label_References.Location = new Point(3, 230);
            Label_References.Name = "Label_References";
            Label_References.Size = new Size(238, 20);
            Label_References.TabIndex = 1;
            Label_References.Text = "References";
            Label_References.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label_Contact
            // 
            Label_Contact.AutoSize = true;
            Label_Contact.Dock = DockStyle.Fill;
            Label_Contact.Location = new Point(3, 210);
            Label_Contact.Name = "Label_Contact";
            Label_Contact.Size = new Size(238, 20);
            Label_Contact.TabIndex = 3;
            Label_Contact.Text = "<<asignee_contact>>";
            Label_Contact.TextAlign = ContentAlignment.TopRight;
            // 
            // flowLayoutPanel_assignee
            // 
            flowLayoutPanel_assignee.Controls.Add(ComboBox_Assignee);
            flowLayoutPanel_assignee.Controls.Add(label_assignee);
            flowLayoutPanel_assignee.Dock = DockStyle.Fill;
            flowLayoutPanel_assignee.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_assignee.Location = new Point(3, 178);
            flowLayoutPanel_assignee.Name = "flowLayoutPanel_assignee";
            flowLayoutPanel_assignee.RightToLeft = RightToLeft.No;
            flowLayoutPanel_assignee.Size = new Size(238, 29);
            flowLayoutPanel_assignee.TabIndex = 4;
            // 
            // ComboBox_Assignee
            // 
            ComboBox_Assignee.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Assignee.FormattingEnabled = true;
            ComboBox_Assignee.Location = new Point(85, 3);
            ComboBox_Assignee.Name = "ComboBox_Assignee";
            ComboBox_Assignee.Size = new Size(150, 23);
            ComboBox_Assignee.TabIndex = 1;
            ComboBox_Assignee.SelectedIndexChanged += ComboBox_Assignee_SelectedIndexChanged;
            // 
            // label_assignee
            // 
            label_assignee.AutoSize = true;
            label_assignee.Dock = DockStyle.Fill;
            label_assignee.Location = new Point(22, 0);
            label_assignee.Name = "label_assignee";
            label_assignee.Size = new Size(57, 29);
            label_assignee.TabIndex = 0;
            label_assignee.Text = "Assignee:";
            label_assignee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel_dateEnd
            // 
            flowLayoutPanel_dateEnd.Controls.Add(DateTimePicker_End);
            flowLayoutPanel_dateEnd.Controls.Add(label_end);
            flowLayoutPanel_dateEnd.Dock = DockStyle.Fill;
            flowLayoutPanel_dateEnd.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_dateEnd.Location = new Point(3, 143);
            flowLayoutPanel_dateEnd.Name = "flowLayoutPanel_dateEnd";
            flowLayoutPanel_dateEnd.RightToLeft = RightToLeft.No;
            flowLayoutPanel_dateEnd.Size = new Size(238, 29);
            flowLayoutPanel_dateEnd.TabIndex = 5;
            // 
            // DateTimePicker_End
            // 
            DateTimePicker_End.Format = DateTimePickerFormat.Short;
            DateTimePicker_End.Location = new Point(85, 3);
            DateTimePicker_End.Name = "DateTimePicker_End";
            DateTimePicker_End.Size = new Size(150, 23);
            DateTimePicker_End.TabIndex = 12;
            DateTimePicker_End.ValueChanged += DateTimePicker_End_ValueChanged;
            // 
            // label_end
            // 
            label_end.Dock = DockStyle.Fill;
            label_end.Location = new Point(51, 0);
            label_end.Margin = new Padding(3, 0, 0, 0);
            label_end.Name = "label_end";
            label_end.Size = new Size(31, 29);
            label_end.TabIndex = 11;
            label_end.Text = "End:";
            label_end.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel_dateStart
            // 
            flowLayoutPanel_dateStart.Controls.Add(DateTimePicker_Start);
            flowLayoutPanel_dateStart.Controls.Add(label_start);
            flowLayoutPanel_dateStart.Dock = DockStyle.Fill;
            flowLayoutPanel_dateStart.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_dateStart.Location = new Point(3, 108);
            flowLayoutPanel_dateStart.Name = "flowLayoutPanel_dateStart";
            flowLayoutPanel_dateStart.RightToLeft = RightToLeft.No;
            flowLayoutPanel_dateStart.Size = new Size(238, 29);
            flowLayoutPanel_dateStart.TabIndex = 6;
            // 
            // DateTimePicker_Start
            // 
            DateTimePicker_Start.Format = DateTimePickerFormat.Short;
            DateTimePicker_Start.Location = new Point(85, 3);
            DateTimePicker_Start.Name = "DateTimePicker_Start";
            DateTimePicker_Start.Size = new Size(150, 23);
            DateTimePicker_Start.TabIndex = 6;
            DateTimePicker_Start.ValueChanged += DateTimePicker_Start_ValueChanged;
            // 
            // label_start
            // 
            label_start.Dock = DockStyle.Fill;
            label_start.Location = new Point(47, 0);
            label_start.Margin = new Padding(3, 0, 0, 0);
            label_start.Name = "label_start";
            label_start.Size = new Size(35, 29);
            label_start.TabIndex = 8;
            label_start.Text = "Start:";
            label_start.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel_version
            // 
            flowLayoutPanel_version.Controls.Add(TextBox_Version);
            flowLayoutPanel_version.Controls.Add(label_version);
            flowLayoutPanel_version.Dock = DockStyle.Fill;
            flowLayoutPanel_version.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_version.Location = new Point(3, 73);
            flowLayoutPanel_version.Name = "flowLayoutPanel_version";
            flowLayoutPanel_version.Size = new Size(238, 29);
            flowLayoutPanel_version.TabIndex = 7;
            // 
            // TextBox_Version
            // 
            TextBox_Version.Location = new Point(85, 3);
            TextBox_Version.Name = "TextBox_Version";
            TextBox_Version.Size = new Size(150, 23);
            TextBox_Version.TabIndex = 16;
            TextBox_Version.Enter += TextBox_Version_Enter;
            TextBox_Version.KeyUp += TextBox_Version_KeyUp;
            TextBox_Version.Leave += TextBox_Version_Leave;
            // 
            // label_version
            // 
            label_version.AutoSize = true;
            label_version.Dock = DockStyle.Fill;
            label_version.Location = new Point(31, 0);
            label_version.Name = "label_version";
            label_version.Size = new Size(48, 29);
            label_version.TabIndex = 17;
            label_version.Text = "Version:";
            label_version.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel_status
            // 
            flowLayoutPanel_status.Controls.Add(ComboBox_Status);
            flowLayoutPanel_status.Controls.Add(label_status);
            flowLayoutPanel_status.Dock = DockStyle.Fill;
            flowLayoutPanel_status.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_status.Location = new Point(3, 38);
            flowLayoutPanel_status.Name = "flowLayoutPanel_status";
            flowLayoutPanel_status.Size = new Size(238, 29);
            flowLayoutPanel_status.TabIndex = 8;
            // 
            // ComboBox_Status
            // 
            ComboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Status.FormattingEnabled = true;
            ComboBox_Status.Location = new Point(85, 3);
            ComboBox_Status.Name = "ComboBox_Status";
            ComboBox_Status.Size = new Size(150, 23);
            ComboBox_Status.TabIndex = 15;
            ComboBox_Status.SelectedIndexChanged += ComboBox_Status_SelectedIndexChanged;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Dock = DockStyle.Fill;
            label_status.Location = new Point(37, 0);
            label_status.Name = "label_status";
            label_status.Size = new Size(42, 29);
            label_status.TabIndex = 16;
            label_status.Text = "Status:";
            label_status.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel_category
            // 
            flowLayoutPanel_category.Controls.Add(TextBox_Category);
            flowLayoutPanel_category.Controls.Add(label_category);
            flowLayoutPanel_category.Dock = DockStyle.Fill;
            flowLayoutPanel_category.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_category.Location = new Point(3, 3);
            flowLayoutPanel_category.Name = "flowLayoutPanel_category";
            flowLayoutPanel_category.Size = new Size(238, 29);
            flowLayoutPanel_category.TabIndex = 9;
            // 
            // TextBox_Category
            // 
            TextBox_Category.Location = new Point(85, 3);
            TextBox_Category.Name = "TextBox_Category";
            TextBox_Category.Size = new Size(150, 23);
            TextBox_Category.TabIndex = 13;
            TextBox_Category.Enter += TextBox_Category_Enter;
            TextBox_Category.KeyUp += TextBox_Category_KeyUp;
            TextBox_Category.Leave += TextBox_Category_Leave;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Dock = DockStyle.Fill;
            label_category.Location = new Point(21, 0);
            label_category.Name = "label_category";
            label_category.Size = new Size(58, 29);
            label_category.TabIndex = 14;
            label_category.Text = "Category:";
            label_category.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TableLayoutPanel_UserStory
            // 
            TableLayoutPanel_UserStory.ColumnCount = 1;
            TableLayoutPanel_UserStory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_UserStory.Controls.Add(RichTextBox_Summary, 0, 1);
            TableLayoutPanel_UserStory.Controls.Add(RichTextBox_TaskList, 0, 3);
            TableLayoutPanel_UserStory.Controls.Add(Label_Summary, 0, 0);
            TableLayoutPanel_UserStory.Controls.Add(Label_TaskList, 0, 2);
            TableLayoutPanel_UserStory.Dock = DockStyle.Fill;
            TableLayoutPanel_UserStory.Location = new Point(253, 3);
            TableLayoutPanel_UserStory.Name = "TableLayoutPanel_UserStory";
            TableLayoutPanel_UserStory.RowCount = 4;
            TableLayoutPanel_UserStory.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_UserStory.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            TableLayoutPanel_UserStory.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_UserStory.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_UserStory.Size = new Size(728, 470);
            TableLayoutPanel_UserStory.TabIndex = 2;
            // 
            // RichTextBox_Summary
            // 
            RichTextBox_Summary.BorderStyle = BorderStyle.None;
            RichTextBox_Summary.Dock = DockStyle.Fill;
            RichTextBox_Summary.Location = new Point(3, 23);
            RichTextBox_Summary.Name = "RichTextBox_Summary";
            RichTextBox_Summary.Size = new Size(722, 114);
            RichTextBox_Summary.TabIndex = 3;
            RichTextBox_Summary.Text = "";
            RichTextBox_Summary.KeyUp += RichTextBox_Summary_KeyUp;
            // 
            // RichTextBox_TaskList
            // 
            RichTextBox_TaskList.AcceptsTab = true;
            RichTextBox_TaskList.BorderStyle = BorderStyle.None;
            RichTextBox_TaskList.Dock = DockStyle.Fill;
            RichTextBox_TaskList.Location = new Point(3, 163);
            RichTextBox_TaskList.Name = "RichTextBox_TaskList";
            RichTextBox_TaskList.Size = new Size(722, 304);
            RichTextBox_TaskList.TabIndex = 4;
            RichTextBox_TaskList.Text = "";
            RichTextBox_TaskList.KeyUp += RichTextBox_TaskList_KeyUp;
            // 
            // Label_Summary
            // 
            Label_Summary.Dock = DockStyle.Fill;
            Label_Summary.Location = new Point(3, 3);
            Label_Summary.Margin = new Padding(3);
            Label_Summary.Name = "Label_Summary";
            Label_Summary.Size = new Size(722, 14);
            Label_Summary.TabIndex = 2;
            Label_Summary.Text = "Summary";
            Label_Summary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label_TaskList
            // 
            Label_TaskList.Dock = DockStyle.Fill;
            Label_TaskList.Location = new Point(3, 143);
            Label_TaskList.Margin = new Padding(3);
            Label_TaskList.Name = "Label_TaskList";
            Label_TaskList.Size = new Size(722, 14);
            Label_TaskList.TabIndex = 3;
            Label_TaskList.Text = "Tasks";
            Label_TaskList.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserStoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(TableLayoutPanel_Body);
            MinimumSize = new Size(960, 600);
            Name = "UserStoryForm";
            Text = "userStoryForm";
            TableLayoutPanel_Body.ResumeLayout(false);
            FlowLayoutPanel_Navigation.ResumeLayout(false);
            FlowLayoutPanel_Navigation.PerformLayout();
            FlowLayoutPanel_Controls.ResumeLayout(false);
            TableLayoutPanel_Content.ResumeLayout(false);
            TableLayoutPanel_SideBar.ResumeLayout(false);
            TableLayoutPanel_SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_References).EndInit();
            panel_referenceControls.ResumeLayout(false);
            flowLayoutPanel_assignee.ResumeLayout(false);
            flowLayoutPanel_assignee.PerformLayout();
            flowLayoutPanel_dateEnd.ResumeLayout(false);
            flowLayoutPanel_dateStart.ResumeLayout(false);
            flowLayoutPanel_version.ResumeLayout(false);
            flowLayoutPanel_version.PerformLayout();
            flowLayoutPanel_status.ResumeLayout(false);
            flowLayoutPanel_status.PerformLayout();
            flowLayoutPanel_category.ResumeLayout(false);
            flowLayoutPanel_category.PerformLayout();
            TableLayoutPanel_UserStory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_Body;
        private LinkLabel LinkLabel_Organization;
        private FlowLayoutPanel flowLayoutPanel_dateEnd;
        private Label label_navigation_separator2;
        private LinkLabel LinkLabel_Project;
        private Label label_navigation_separator3;
        private TableLayoutPanel TableLayoutPanel_Content;
        private Label Label_Summary;
        private Label Label_TaskList;
        private Button Button_HideSummary;
        private Button Button_HideReferences;
        private TableLayoutPanel TableLayoutPanel_UserStory;
        private FlowLayoutPanel FlowLayoutPanel_Controls;
        private TableLayoutPanel TableLayoutPanel_TagCount;
        private Label Label_TaskCount;
        private TableLayoutPanel TableLayoutPanel_SideBar;
        private DataGridView DataGridView_References;
        private Label Label_References;
        private FlowLayoutPanel FlowLayoutPanel_Navigation;
        private Button Button_Summary;
        private Button Button_SideBar;
        private RichTextBox RichTextBox_Summary;
        private RichTextBox RichTextBox_TaskList;
        private Label label_start;
        private DateTimePicker DateTimePicker_Start;
        private Button Button_AddMedia;
        private Button Button_AddText;
        private Panel panel_referenceControls;
        private Label label_end;
        private DateTimePicker DateTimePicker_End;
        private TextBox TextBox_Category;
        private Label label_pipe2;
        private ComboBox ComboBox_Status;
        private LinkLabel LinkLabel_Start;
        private Label label_navigation_separator1;
        private TextBox TextBox_UserStoryName;
        private TextBox TextBox_Version;
        private Label Label_Contact;
        private FlowLayoutPanel flowLayoutPanel_assignee;
        private Label label_assignee;
        private FlowLayoutPanel flowLayoutPanel_dateStart;
        private FlowLayoutPanel flowLayoutPanel_version;
        private Label label_version;
        private FlowLayoutPanel flowLayoutPanel_status;
        private Label label_status;
        private FlowLayoutPanel flowLayoutPanel_category;
        private Label label_category;
        private ComboBox ComboBox_Assignee;
    }
}