namespace Kahnban_ToDo
{
    partial class ProjectDetailsForm
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
            Label_Project = new Label();
            flowLayoutPanel_controls = new FlowLayoutPanel();
            Button_SideBar = new Button();
            label_pipe = new Label();
            TextBox_UserStory = new TextBox();
            ComboBox_Category = new ComboBox();
            ComboBox_Status = new ComboBox();
            label_pipe2 = new Label();
            Button_UserStory_Create = new Button();
            Button_UserStory_Update = new Button();
            Button_UserStory_Delete = new Button();
            TableLayoutPanel_Content = new TableLayoutPanel();
            TableLayoutPanel_TagCount = new TableLayoutPanel();
            Label_Status = new Label();
            DataGridView_Status = new DataGridView();
            TableLayoutPanel_UserStories = new TableLayoutPanel();
            Label_UserStories = new Label();
            DataGridView_UserStories = new DataGridView();
            TableLayoutPanel_Body.SuspendLayout();
            FlowLayoutPanel_Navigation.SuspendLayout();
            flowLayoutPanel_controls.SuspendLayout();
            TableLayoutPanel_Content.SuspendLayout();
            TableLayoutPanel_TagCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Status).BeginInit();
            TableLayoutPanel_UserStories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_UserStories).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel_Body
            // 
            TableLayoutPanel_Body.ColumnCount = 1;
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.Controls.Add(FlowLayoutPanel_Navigation, 0, 0);
            TableLayoutPanel_Body.Controls.Add(flowLayoutPanel_controls, 0, 1);
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
            FlowLayoutPanel_Navigation.Controls.Add(Label_Project);
            FlowLayoutPanel_Navigation.Dock = DockStyle.Fill;
            FlowLayoutPanel_Navigation.Location = new Point(0, 0);
            FlowLayoutPanel_Navigation.Margin = new Padding(0);
            FlowLayoutPanel_Navigation.Name = "FlowLayoutPanel_Navigation";
            FlowLayoutPanel_Navigation.Size = new Size(984, 30);
            FlowLayoutPanel_Navigation.TabIndex = 0;
            // 
            // LinkLabel_Start
            // 
            LinkLabel_Start.AutoSize = true;
            LinkLabel_Start.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel_Start.LinkColor = Color.DodgerBlue;
            LinkLabel_Start.Location = new Point(3, 0);
            LinkLabel_Start.Name = "LinkLabel_Start";
            LinkLabel_Start.Size = new Size(56, 25);
            LinkLabel_Start.TabIndex = 3;
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
            label_navigation_separator1.TabIndex = 4;
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
            // Label_Project
            // 
            Label_Project.AutoSize = true;
            Label_Project.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Project.Location = new Point(243, 0);
            Label_Project.Name = "Label_Project";
            Label_Project.Size = new Size(75, 25);
            Label_Project.TabIndex = 2;
            Label_Project.Text = "project";
            // 
            // flowLayoutPanel_controls
            // 
            flowLayoutPanel_controls.Controls.Add(Button_SideBar);
            flowLayoutPanel_controls.Controls.Add(label_pipe);
            flowLayoutPanel_controls.Controls.Add(TextBox_UserStory);
            flowLayoutPanel_controls.Controls.Add(ComboBox_Category);
            flowLayoutPanel_controls.Controls.Add(ComboBox_Status);
            flowLayoutPanel_controls.Controls.Add(label_pipe2);
            flowLayoutPanel_controls.Controls.Add(Button_UserStory_Create);
            flowLayoutPanel_controls.Controls.Add(Button_UserStory_Update);
            flowLayoutPanel_controls.Controls.Add(Button_UserStory_Delete);
            flowLayoutPanel_controls.Dock = DockStyle.Fill;
            flowLayoutPanel_controls.Location = new Point(3, 33);
            flowLayoutPanel_controls.Name = "flowLayoutPanel_controls";
            flowLayoutPanel_controls.Size = new Size(978, 29);
            flowLayoutPanel_controls.TabIndex = 2;
            // 
            // Button_SideBar
            // 
            Button_SideBar.Location = new Point(3, 3);
            Button_SideBar.Name = "Button_SideBar";
            Button_SideBar.Size = new Size(100, 23);
            Button_SideBar.TabIndex = 0;
            Button_SideBar.Text = "Side Bar";
            Button_SideBar.UseVisualStyleBackColor = true;
            Button_SideBar.Click += Button_SideBar_Click;
            // 
            // label_pipe
            // 
            label_pipe.Location = new Point(109, 0);
            label_pipe.Name = "label_pipe";
            label_pipe.Size = new Size(10, 23);
            label_pipe.TabIndex = 1;
            label_pipe.Text = "|";
            label_pipe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBox_UserStory
            // 
            TextBox_UserStory.Location = new Point(125, 3);
            TextBox_UserStory.Name = "TextBox_UserStory";
            TextBox_UserStory.Size = new Size(125, 23);
            TextBox_UserStory.TabIndex = 4;
            TextBox_UserStory.Enter += TextBox_UserStory_Enter;
            TextBox_UserStory.KeyUp += TextBox_UserStory_KeyUp;
            TextBox_UserStory.Leave += TextBox_UserStory_Leave;
            // 
            // ComboBox_Category
            // 
            ComboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Category.FormattingEnabled = true;
            ComboBox_Category.Location = new Point(256, 3);
            ComboBox_Category.Name = "ComboBox_Category";
            ComboBox_Category.Size = new Size(150, 23);
            ComboBox_Category.TabIndex = 2;
            ComboBox_Category.SelectedIndexChanged += ComboBox_Category_SelectedIndexChanged;
            // 
            // ComboBox_Status
            // 
            ComboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Status.FormattingEnabled = true;
            ComboBox_Status.Location = new Point(412, 3);
            ComboBox_Status.Name = "ComboBox_Status";
            ComboBox_Status.Size = new Size(150, 23);
            ComboBox_Status.TabIndex = 3;
            ComboBox_Status.SelectedIndexChanged += ComboBox_Status_SelectedIndexChanged;
            // 
            // label_pipe2
            // 
            label_pipe2.Location = new Point(568, 0);
            label_pipe2.Name = "label_pipe2";
            label_pipe2.RightToLeft = RightToLeft.Yes;
            label_pipe2.Size = new Size(10, 23);
            label_pipe2.TabIndex = 5;
            label_pipe2.Text = "|";
            label_pipe2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Button_UserStory_Create
            // 
            Button_UserStory_Create.Location = new Point(584, 3);
            Button_UserStory_Create.Name = "Button_UserStory_Create";
            Button_UserStory_Create.Size = new Size(100, 23);
            Button_UserStory_Create.TabIndex = 6;
            Button_UserStory_Create.Text = "Add";
            Button_UserStory_Create.UseVisualStyleBackColor = true;
            Button_UserStory_Create.Click += Button_UserStory_Create_Click;
            // 
            // Button_UserStory_Update
            // 
            Button_UserStory_Update.Enabled = false;
            Button_UserStory_Update.Location = new Point(690, 3);
            Button_UserStory_Update.Name = "Button_UserStory_Update";
            Button_UserStory_Update.Size = new Size(100, 23);
            Button_UserStory_Update.TabIndex = 7;
            Button_UserStory_Update.Text = "Edit";
            Button_UserStory_Update.UseVisualStyleBackColor = true;
            Button_UserStory_Update.Click += Button_UserStory_Update_Click;
            // 
            // Button_UserStory_Delete
            // 
            Button_UserStory_Delete.Enabled = false;
            Button_UserStory_Delete.Location = new Point(796, 3);
            Button_UserStory_Delete.Name = "Button_UserStory_Delete";
            Button_UserStory_Delete.Size = new Size(100, 23);
            Button_UserStory_Delete.TabIndex = 8;
            Button_UserStory_Delete.Text = "Delete";
            Button_UserStory_Delete.UseVisualStyleBackColor = true;
            Button_UserStory_Delete.Click += Button_UserStory_Delete_Click;
            // 
            // TableLayoutPanel_Content
            // 
            TableLayoutPanel_Content.ColumnCount = 2;
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_TagCount, 0, 0);
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_UserStories, 1, 0);
            TableLayoutPanel_Content.Dock = DockStyle.Fill;
            TableLayoutPanel_Content.Location = new Point(3, 68);
            TableLayoutPanel_Content.Name = "TableLayoutPanel_Content";
            TableLayoutPanel_Content.RowCount = 1;
            TableLayoutPanel_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Content.Size = new Size(978, 470);
            TableLayoutPanel_Content.TabIndex = 1;
            // 
            // TableLayoutPanel_TagCount
            // 
            TableLayoutPanel_TagCount.ColumnCount = 1;
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.Controls.Add(Label_Status, 0, 0);
            TableLayoutPanel_TagCount.Controls.Add(DataGridView_Status, 0, 1);
            TableLayoutPanel_TagCount.Dock = DockStyle.Fill;
            TableLayoutPanel_TagCount.Location = new Point(3, 3);
            TableLayoutPanel_TagCount.Name = "TableLayoutPanel_TagCount";
            TableLayoutPanel_TagCount.RowCount = 2;
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.Size = new Size(244, 464);
            TableLayoutPanel_TagCount.TabIndex = 0;
            // 
            // Label_Status
            // 
            Label_Status.Dock = DockStyle.Fill;
            Label_Status.Location = new Point(3, 0);
            Label_Status.Name = "Label_Status";
            Label_Status.Size = new Size(238, 20);
            Label_Status.TabIndex = 0;
            Label_Status.Text = "Status";
            Label_Status.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataGridView_Status
            // 
            DataGridView_Status.AllowUserToAddRows = false;
            DataGridView_Status.AllowUserToDeleteRows = false;
            DataGridView_Status.AllowUserToResizeColumns = false;
            DataGridView_Status.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Status.BackgroundColor = SystemColors.ControlDarkDark;
            DataGridView_Status.BorderStyle = BorderStyle.None;
            DataGridView_Status.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Status.Dock = DockStyle.Fill;
            DataGridView_Status.Location = new Point(3, 23);
            DataGridView_Status.Name = "DataGridView_Status";
            DataGridView_Status.ReadOnly = true;
            DataGridView_Status.RowHeadersVisible = false;
            DataGridView_Status.ShowCellToolTips = false;
            DataGridView_Status.Size = new Size(238, 438);
            DataGridView_Status.TabIndex = 1;
            // 
            // TableLayoutPanel_UserStories
            // 
            TableLayoutPanel_UserStories.ColumnCount = 1;
            TableLayoutPanel_UserStories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_UserStories.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_UserStories.Controls.Add(Label_UserStories, 0, 0);
            TableLayoutPanel_UserStories.Controls.Add(DataGridView_UserStories, 0, 1);
            TableLayoutPanel_UserStories.Dock = DockStyle.Fill;
            TableLayoutPanel_UserStories.Location = new Point(253, 3);
            TableLayoutPanel_UserStories.Name = "TableLayoutPanel_UserStories";
            TableLayoutPanel_UserStories.RowCount = 2;
            TableLayoutPanel_UserStories.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_UserStories.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_UserStories.Size = new Size(722, 464);
            TableLayoutPanel_UserStories.TabIndex = 1;
            // 
            // Label_UserStories
            // 
            Label_UserStories.Dock = DockStyle.Fill;
            Label_UserStories.Location = new Point(3, 0);
            Label_UserStories.Name = "Label_UserStories";
            Label_UserStories.Size = new Size(716, 20);
            Label_UserStories.TabIndex = 0;
            Label_UserStories.Text = "User Stories";
            Label_UserStories.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataGridView_UserStories
            // 
            DataGridView_UserStories.AllowUserToAddRows = false;
            DataGridView_UserStories.AllowUserToDeleteRows = false;
            DataGridView_UserStories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_UserStories.BackgroundColor = SystemColors.ControlDarkDark;
            DataGridView_UserStories.BorderStyle = BorderStyle.None;
            DataGridView_UserStories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_UserStories.Dock = DockStyle.Fill;
            DataGridView_UserStories.Location = new Point(3, 23);
            DataGridView_UserStories.Name = "DataGridView_UserStories";
            DataGridView_UserStories.ReadOnly = true;
            DataGridView_UserStories.RowHeadersVisible = false;
            DataGridView_UserStories.ShowCellToolTips = false;
            DataGridView_UserStories.Size = new Size(716, 438);
            DataGridView_UserStories.TabIndex = 1;
            DataGridView_UserStories.CellClick += DataGridView_UserStories_CellClick;
            DataGridView_UserStories.CellDoubleClick += DataGridView_UserStories_CellDoubleClick;
            DataGridView_UserStories.CellEndEdit += DataGridView_UserStories_CellEndEdit;
            DataGridView_UserStories.CellValueChanged += DataGridView_UserStories_CellValueChanged;
            DataGridView_UserStories.CurrentCellDirtyStateChanged += DataGridView_UserStories_CurrentCellDirtyStateChanged;
            DataGridView_UserStories.UserDeletingRow += DataGridView_UserStories_UserDeletingRow;
            // 
            // ProjectDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(TableLayoutPanel_Body);
            Name = "ProjectDetailsForm";
            Text = "projectForm";
            TableLayoutPanel_Body.ResumeLayout(false);
            FlowLayoutPanel_Navigation.ResumeLayout(false);
            FlowLayoutPanel_Navigation.PerformLayout();
            flowLayoutPanel_controls.ResumeLayout(false);
            flowLayoutPanel_controls.PerformLayout();
            TableLayoutPanel_Content.ResumeLayout(false);
            TableLayoutPanel_TagCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Status).EndInit();
            TableLayoutPanel_UserStories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_UserStories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_Body;
        private FlowLayoutPanel FlowLayoutPanel_Navigation;
        private LinkLabel LinkLabel_Organization;
        private Label label_navigation_separator2;
        private Label Label_Project;
        private TableLayoutPanel TableLayoutPanel_Content;
        private TableLayoutPanel TableLayoutPanel_TagCount;
        private Label Label_Status;
        private DataGridView DataGridView_Status;
        private TableLayoutPanel TableLayoutPanel_UserStories;
        private Label Label_UserStories;
        private DataGridView DataGridView_UserStories;
        private FlowLayoutPanel flowLayoutPanel_controls;
        private Button Button_SideBar;
        private Label label_pipe;
        private ComboBox ComboBox_Category;
        private ComboBox ComboBox_Status;
        private LinkLabel LinkLabel_Start;
        private Label label_navigation_separator1;
        private TextBox TextBox_UserStory;
        private Label label_pipe2;
        private Button Button_UserStory_Create;
        private Button Button_UserStory_Update;
        private Button Button_UserStory_Delete;
    }
}