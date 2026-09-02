namespace Kahnban_ToDo
{
    partial class ProjectForm
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
            LinkLabel_Organization = new LinkLabel();
            Label_Separator = new Label();
            Label_Project = new Label();
            flowLayoutPanel_controls = new FlowLayoutPanel();
            Button_SideBar = new Button();
            label_pipe = new Label();
            ComboBox_Category = new ComboBox();
            ComboBox_Status = new ComboBox();
            TableLayoutPanel_Content = new TableLayoutPanel();
            TableLayoutPanel_TagCount = new TableLayoutPanel();
            label_status = new Label();
            DataGridView_Status = new DataGridView();
            TableLayoutPanel_UserStories = new TableLayoutPanel();
            label_userStory = new Label();
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
            TableLayoutPanel_Body.Size = new Size(981, 719);
            TableLayoutPanel_Body.TabIndex = 0;
            // 
            // FlowLayoutPanel_Navigation
            // 
            FlowLayoutPanel_Navigation.Controls.Add(LinkLabel_Organization);
            FlowLayoutPanel_Navigation.Controls.Add(Label_Separator);
            FlowLayoutPanel_Navigation.Controls.Add(Label_Project);
            FlowLayoutPanel_Navigation.Dock = DockStyle.Fill;
            FlowLayoutPanel_Navigation.Location = new Point(0, 0);
            FlowLayoutPanel_Navigation.Margin = new Padding(0);
            FlowLayoutPanel_Navigation.Name = "FlowLayoutPanel_Navigation";
            FlowLayoutPanel_Navigation.Size = new Size(981, 30);
            FlowLayoutPanel_Navigation.TabIndex = 0;
            // 
            // LinkLabel_Organization
            // 
            LinkLabel_Organization.AutoSize = true;
            LinkLabel_Organization.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel_Organization.Location = new Point(3, 0);
            LinkLabel_Organization.Name = "LinkLabel_Organization";
            LinkLabel_Organization.Size = new Size(126, 25);
            LinkLabel_Organization.TabIndex = 0;
            LinkLabel_Organization.TabStop = true;
            LinkLabel_Organization.Text = "organization";
            LinkLabel_Organization.LinkClicked += LinkLabel_Organization_LinkClicked;
            // 
            // Label_Separator
            // 
            Label_Separator.AutoSize = true;
            Label_Separator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Separator.Location = new Point(132, 0);
            Label_Separator.Margin = new Padding(0);
            Label_Separator.Name = "Label_Separator";
            Label_Separator.Size = new Size(20, 25);
            Label_Separator.TabIndex = 1;
            Label_Separator.Text = "/";
            // 
            // Label_Project
            // 
            Label_Project.AutoSize = true;
            Label_Project.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Project.Location = new Point(155, 0);
            Label_Project.Name = "Label_Project";
            Label_Project.Size = new Size(75, 25);
            Label_Project.TabIndex = 2;
            Label_Project.Text = "project";
            // 
            // flowLayoutPanel_controls
            // 
            flowLayoutPanel_controls.Controls.Add(Button_SideBar);
            flowLayoutPanel_controls.Controls.Add(label_pipe);
            flowLayoutPanel_controls.Controls.Add(ComboBox_Category);
            flowLayoutPanel_controls.Controls.Add(ComboBox_Status);
            flowLayoutPanel_controls.Dock = DockStyle.Fill;
            flowLayoutPanel_controls.Location = new Point(3, 33);
            flowLayoutPanel_controls.Name = "flowLayoutPanel_controls";
            flowLayoutPanel_controls.Size = new Size(975, 29);
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
            // ComboBox_Category
            // 
            ComboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Category.FormattingEnabled = true;
            ComboBox_Category.Location = new Point(125, 3);
            ComboBox_Category.Name = "ComboBox_Category";
            ComboBox_Category.Size = new Size(150, 23);
            ComboBox_Category.TabIndex = 2;
            ComboBox_Category.SelectedIndexChanged += ComboBox_Category_SelectedIndexChanged;
            // 
            // ComboBox_Status
            // 
            ComboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Status.FormattingEnabled = true;
            ComboBox_Status.Location = new Point(281, 3);
            ComboBox_Status.Name = "ComboBox_Status";
            ComboBox_Status.Size = new Size(150, 23);
            ComboBox_Status.TabIndex = 3;
            ComboBox_Status.SelectedIndexChanged += ComboBox_Status_SelectedIndexChanged;
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
            TableLayoutPanel_Content.Size = new Size(975, 628);
            TableLayoutPanel_Content.TabIndex = 1;
            // 
            // TableLayoutPanel_TagCount
            // 
            TableLayoutPanel_TagCount.ColumnCount = 1;
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.Controls.Add(label_status, 0, 0);
            TableLayoutPanel_TagCount.Controls.Add(DataGridView_Status, 0, 1);
            TableLayoutPanel_TagCount.Dock = DockStyle.Fill;
            TableLayoutPanel_TagCount.Location = new Point(3, 3);
            TableLayoutPanel_TagCount.Name = "TableLayoutPanel_TagCount";
            TableLayoutPanel_TagCount.RowCount = 2;
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.Size = new Size(244, 622);
            TableLayoutPanel_TagCount.TabIndex = 0;
            // 
            // label_status
            // 
            label_status.Dock = DockStyle.Fill;
            label_status.Location = new Point(3, 0);
            label_status.Name = "label_status";
            label_status.Size = new Size(238, 20);
            label_status.TabIndex = 0;
            label_status.Text = "Status";
            label_status.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataGridView_Status
            // 
            DataGridView_Status.AllowUserToAddRows = false;
            DataGridView_Status.AllowUserToDeleteRows = false;
            DataGridView_Status.AllowUserToResizeColumns = false;
            DataGridView_Status.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Status.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Status.Dock = DockStyle.Fill;
            DataGridView_Status.Location = new Point(3, 23);
            DataGridView_Status.Name = "DataGridView_Status";
            DataGridView_Status.Size = new Size(238, 596);
            DataGridView_Status.TabIndex = 1;
            // 
            // TableLayoutPanel_UserStories
            // 
            TableLayoutPanel_UserStories.ColumnCount = 1;
            TableLayoutPanel_UserStories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_UserStories.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_UserStories.Controls.Add(label_userStory, 0, 0);
            TableLayoutPanel_UserStories.Controls.Add(DataGridView_UserStories, 0, 1);
            TableLayoutPanel_UserStories.Dock = DockStyle.Fill;
            TableLayoutPanel_UserStories.Location = new Point(253, 3);
            TableLayoutPanel_UserStories.Name = "TableLayoutPanel_UserStories";
            TableLayoutPanel_UserStories.RowCount = 2;
            TableLayoutPanel_UserStories.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_UserStories.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_UserStories.Size = new Size(719, 622);
            TableLayoutPanel_UserStories.TabIndex = 1;
            // 
            // label_userStory
            // 
            label_userStory.Dock = DockStyle.Fill;
            label_userStory.Location = new Point(3, 0);
            label_userStory.Name = "label_userStory";
            label_userStory.Size = new Size(713, 20);
            label_userStory.TabIndex = 0;
            label_userStory.Text = "User Stories";
            label_userStory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataGridView_UserStories
            // 
            DataGridView_UserStories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_UserStories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_UserStories.Dock = DockStyle.Fill;
            DataGridView_UserStories.Location = new Point(3, 23);
            DataGridView_UserStories.Name = "DataGridView_UserStories";
            DataGridView_UserStories.Size = new Size(713, 596);
            DataGridView_UserStories.TabIndex = 1;
            DataGridView_UserStories.CellDoubleClick += DataGridView_UserStories_CellDoubleClick;
            DataGridView_UserStories.CellEndEdit += DataGridView_UserStories_CellEndEdit;
            DataGridView_UserStories.CellValueChanged += DataGridView_UserStories_CellValueChanged;
            DataGridView_UserStories.CurrentCellDirtyStateChanged += DataGridView_UserStories_CurrentCellDirtyStateChanged;
            DataGridView_UserStories.UserDeletingRow += DataGridView_UserStories_UserDeletingRow;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 719);
            Controls.Add(TableLayoutPanel_Body);
            Name = "ProjectForm";
            Text = "projectForm";
            TableLayoutPanel_Body.ResumeLayout(false);
            FlowLayoutPanel_Navigation.ResumeLayout(false);
            FlowLayoutPanel_Navigation.PerformLayout();
            flowLayoutPanel_controls.ResumeLayout(false);
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
        private Label Label_Separator;
        private Label Label_Project;
        private TableLayoutPanel TableLayoutPanel_Content;
        private TableLayoutPanel TableLayoutPanel_TagCount;
        private Label label_status;
        private DataGridView DataGridView_Status;
        private TableLayoutPanel TableLayoutPanel_UserStories;
        private Label label_userStory;
        private DataGridView DataGridView_UserStories;
        private FlowLayoutPanel flowLayoutPanel_controls;
        private Button Button_SideBar;
        private Label label_pipe;
        private ComboBox ComboBox_Category;
        private ComboBox ComboBox_Status;
    }
}