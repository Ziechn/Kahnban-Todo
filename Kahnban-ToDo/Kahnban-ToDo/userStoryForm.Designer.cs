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
            LinkLabel_Organization = new LinkLabel();
            Label_Seperator1 = new Label();
            LinkLabel_Project = new LinkLabel();
            Label_Seperator2 = new Label();
            Label_UserStory = new Label();
            TableLayoutPanel_Content = new TableLayoutPanel();
            TableLayoutPanel_UserStory = new TableLayoutPanel();
            FlowLayoutPanel_Controls = new FlowLayoutPanel();
            Button_Summary = new Button();
            Button_References = new Button();
            TableLayoutPanel_Summary = new TableLayoutPanel();
            Label_Summary = new Label();
            RichTextBox_Summary = new RichTextBox();
            TableLayoutPanel_TaskList = new TableLayoutPanel();
            Label_TaskList = new Label();
            RichTextBox_TaskList = new RichTextBox();
            TableLayoutPanel_TagCount = new TableLayoutPanel();
            Label_TagCount = new Label();
            DataGridView_TagCount = new DataGridView();
            TableLayoutPanel_References = new TableLayoutPanel();
            DataGridView_References = new DataGridView();
            Label_References = new Label();
            TableLayoutPanel_Body.SuspendLayout();
            FlowLayoutPanel_Navigation.SuspendLayout();
            TableLayoutPanel_Content.SuspendLayout();
            TableLayoutPanel_UserStory.SuspendLayout();
            FlowLayoutPanel_Controls.SuspendLayout();
            TableLayoutPanel_Summary.SuspendLayout();
            TableLayoutPanel_TaskList.SuspendLayout();
            TableLayoutPanel_TagCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_TagCount).BeginInit();
            TableLayoutPanel_References.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_References).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel_Body
            // 
            TableLayoutPanel_Body.ColumnCount = 1;
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.Controls.Add(FlowLayoutPanel_Navigation, 0, 0);
            TableLayoutPanel_Body.Controls.Add(TableLayoutPanel_Content, 0, 1);
            TableLayoutPanel_Body.Dock = DockStyle.Fill;
            TableLayoutPanel_Body.Location = new Point(0, 0);
            TableLayoutPanel_Body.Name = "TableLayoutPanel_Body";
            TableLayoutPanel_Body.RowCount = 3;
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Body.Size = new Size(1169, 803);
            TableLayoutPanel_Body.TabIndex = 0;
            // 
            // FlowLayoutPanel_Navigation
            // 
            FlowLayoutPanel_Navigation.Controls.Add(LinkLabel_Organization);
            FlowLayoutPanel_Navigation.Controls.Add(Label_Seperator1);
            FlowLayoutPanel_Navigation.Controls.Add(LinkLabel_Project);
            FlowLayoutPanel_Navigation.Controls.Add(Label_Seperator2);
            FlowLayoutPanel_Navigation.Controls.Add(Label_UserStory);
            FlowLayoutPanel_Navigation.Dock = DockStyle.Fill;
            FlowLayoutPanel_Navigation.Location = new Point(0, 0);
            FlowLayoutPanel_Navigation.Margin = new Padding(0);
            FlowLayoutPanel_Navigation.Name = "FlowLayoutPanel_Navigation";
            FlowLayoutPanel_Navigation.Size = new Size(1169, 30);
            FlowLayoutPanel_Navigation.TabIndex = 1;
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
            // Label_Seperator1
            // 
            Label_Seperator1.AutoSize = true;
            Label_Seperator1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Seperator1.Location = new Point(132, 0);
            Label_Seperator1.Margin = new Padding(0);
            Label_Seperator1.Name = "Label_Seperator1";
            Label_Seperator1.Size = new Size(20, 25);
            Label_Seperator1.TabIndex = 1;
            Label_Seperator1.Text = "/";
            // 
            // LinkLabel_Project
            // 
            LinkLabel_Project.AutoSize = true;
            LinkLabel_Project.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel_Project.Location = new Point(155, 0);
            LinkLabel_Project.Name = "LinkLabel_Project";
            LinkLabel_Project.Size = new Size(75, 25);
            LinkLabel_Project.TabIndex = 2;
            LinkLabel_Project.TabStop = true;
            LinkLabel_Project.Text = "project";
            LinkLabel_Project.LinkClicked += LinkLabel_Project_LinkClicked;
            // 
            // Label_Seperator2
            // 
            Label_Seperator2.AutoSize = true;
            Label_Seperator2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Seperator2.Location = new Point(233, 0);
            Label_Seperator2.Margin = new Padding(0);
            Label_Seperator2.Name = "Label_Seperator2";
            Label_Seperator2.Size = new Size(20, 25);
            Label_Seperator2.TabIndex = 3;
            Label_Seperator2.Text = "/";
            // 
            // Label_UserStory
            // 
            Label_UserStory.AutoSize = true;
            Label_UserStory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_UserStory.Location = new Point(256, 0);
            Label_UserStory.Name = "Label_UserStory";
            Label_UserStory.Size = new Size(99, 25);
            Label_UserStory.TabIndex = 4;
            Label_UserStory.Text = "userStory";
            // 
            // TableLayoutPanel_Content
            // 
            TableLayoutPanel_Content.ColumnCount = 3;
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_UserStory, 1, 0);
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_TagCount, 0, 0);
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_References, 2, 0);
            TableLayoutPanel_Content.Dock = DockStyle.Fill;
            TableLayoutPanel_Content.Location = new Point(0, 30);
            TableLayoutPanel_Content.Margin = new Padding(0);
            TableLayoutPanel_Content.Name = "TableLayoutPanel_Content";
            TableLayoutPanel_Content.RowCount = 1;
            TableLayoutPanel_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.Size = new Size(1169, 753);
            TableLayoutPanel_Content.TabIndex = 2;
            // 
            // TableLayoutPanel_UserStory
            // 
            TableLayoutPanel_UserStory.ColumnCount = 1;
            TableLayoutPanel_UserStory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_UserStory.Controls.Add(FlowLayoutPanel_Controls, 0, 0);
            TableLayoutPanel_UserStory.Controls.Add(TableLayoutPanel_Summary, 0, 1);
            TableLayoutPanel_UserStory.Controls.Add(TableLayoutPanel_TaskList, 0, 2);
            TableLayoutPanel_UserStory.Dock = DockStyle.Fill;
            TableLayoutPanel_UserStory.Location = new Point(253, 3);
            TableLayoutPanel_UserStory.Name = "TableLayoutPanel_UserStory";
            TableLayoutPanel_UserStory.RowCount = 3;
            TableLayoutPanel_UserStory.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_UserStory.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            TableLayoutPanel_UserStory.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_UserStory.Size = new Size(663, 747);
            TableLayoutPanel_UserStory.TabIndex = 2;
            // 
            // FlowLayoutPanel_Controls
            // 
            FlowLayoutPanel_Controls.Controls.Add(Button_Summary);
            FlowLayoutPanel_Controls.Controls.Add(Button_References);
            FlowLayoutPanel_Controls.Dock = DockStyle.Fill;
            FlowLayoutPanel_Controls.Location = new Point(3, 3);
            FlowLayoutPanel_Controls.Name = "FlowLayoutPanel_Controls";
            FlowLayoutPanel_Controls.Size = new Size(657, 29);
            FlowLayoutPanel_Controls.TabIndex = 0;
            // 
            // Button_Summary
            // 
            Button_Summary.Location = new Point(3, 3);
            Button_Summary.Name = "Button_Summary";
            Button_Summary.Size = new Size(100, 23);
            Button_Summary.TabIndex = 4;
            Button_Summary.Text = "Summary";
            Button_Summary.UseVisualStyleBackColor = true;
            Button_Summary.Click += Button_Summary_Click;
            // 
            // Button_References
            // 
            Button_References.Location = new Point(109, 3);
            Button_References.Name = "Button_References";
            Button_References.Size = new Size(100, 23);
            Button_References.TabIndex = 5;
            Button_References.Text = "References";
            Button_References.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel_Summary
            // 
            TableLayoutPanel_Summary.ColumnCount = 1;
            TableLayoutPanel_Summary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Summary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Summary.Controls.Add(Label_Summary, 0, 0);
            TableLayoutPanel_Summary.Controls.Add(RichTextBox_Summary, 0, 1);
            TableLayoutPanel_Summary.Dock = DockStyle.Fill;
            TableLayoutPanel_Summary.Location = new Point(3, 38);
            TableLayoutPanel_Summary.Name = "TableLayoutPanel_Summary";
            TableLayoutPanel_Summary.RowCount = 2;
            TableLayoutPanel_Summary.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Summary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Summary.Size = new Size(657, 114);
            TableLayoutPanel_Summary.TabIndex = 1;
            // 
            // Label_Summary
            // 
            Label_Summary.AutoSize = true;
            Label_Summary.Location = new Point(3, 3);
            Label_Summary.Margin = new Padding(3);
            Label_Summary.Name = "Label_Summary";
            Label_Summary.Size = new Size(58, 14);
            Label_Summary.TabIndex = 2;
            Label_Summary.Text = "Summary";
            // 
            // RichTextBox_Summary
            // 
            RichTextBox_Summary.Dock = DockStyle.Fill;
            RichTextBox_Summary.Location = new Point(3, 23);
            RichTextBox_Summary.Name = "RichTextBox_Summary";
            RichTextBox_Summary.Size = new Size(651, 88);
            RichTextBox_Summary.TabIndex = 3;
            RichTextBox_Summary.Text = "";
            // 
            // TableLayoutPanel_TaskList
            // 
            TableLayoutPanel_TaskList.ColumnCount = 1;
            TableLayoutPanel_TaskList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TaskList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TaskList.Controls.Add(Label_TaskList, 0, 0);
            TableLayoutPanel_TaskList.Controls.Add(RichTextBox_TaskList, 0, 1);
            TableLayoutPanel_TaskList.Dock = DockStyle.Fill;
            TableLayoutPanel_TaskList.Location = new Point(3, 158);
            TableLayoutPanel_TaskList.Name = "TableLayoutPanel_TaskList";
            TableLayoutPanel_TaskList.RowCount = 2;
            TableLayoutPanel_TaskList.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TaskList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TaskList.Size = new Size(657, 586);
            TableLayoutPanel_TaskList.TabIndex = 2;
            // 
            // Label_TaskList
            // 
            Label_TaskList.AutoSize = true;
            Label_TaskList.Location = new Point(3, 3);
            Label_TaskList.Margin = new Padding(3);
            Label_TaskList.Name = "Label_TaskList";
            Label_TaskList.Size = new Size(35, 14);
            Label_TaskList.TabIndex = 3;
            Label_TaskList.Text = "Tasks";
            // 
            // RichTextBox_TaskList
            // 
            RichTextBox_TaskList.Dock = DockStyle.Fill;
            RichTextBox_TaskList.Location = new Point(3, 23);
            RichTextBox_TaskList.Name = "RichTextBox_TaskList";
            RichTextBox_TaskList.Size = new Size(651, 560);
            RichTextBox_TaskList.TabIndex = 4;
            RichTextBox_TaskList.Text = "";
            RichTextBox_TaskList.KeyUp += RichTextBox_TaskList_KeyUp;
            // 
            // TableLayoutPanel_TagCount
            // 
            TableLayoutPanel_TagCount.ColumnCount = 1;
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.Controls.Add(Label_TagCount, 0, 0);
            TableLayoutPanel_TagCount.Controls.Add(DataGridView_TagCount, 0, 1);
            TableLayoutPanel_TagCount.Dock = DockStyle.Fill;
            TableLayoutPanel_TagCount.Location = new Point(3, 3);
            TableLayoutPanel_TagCount.Name = "TableLayoutPanel_TagCount";
            TableLayoutPanel_TagCount.RowCount = 2;
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.Size = new Size(244, 747);
            TableLayoutPanel_TagCount.TabIndex = 3;
            // 
            // Label_TagCount
            // 
            Label_TagCount.AutoSize = true;
            Label_TagCount.Location = new Point(3, 0);
            Label_TagCount.Name = "Label_TagCount";
            Label_TagCount.Size = new Size(31, 15);
            Label_TagCount.TabIndex = 0;
            Label_TagCount.Text = "Tags";
            // 
            // DataGridView_TagCount
            // 
            DataGridView_TagCount.AllowUserToAddRows = false;
            DataGridView_TagCount.AllowUserToDeleteRows = false;
            DataGridView_TagCount.AllowUserToResizeRows = false;
            DataGridView_TagCount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_TagCount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_TagCount.Dock = DockStyle.Fill;
            DataGridView_TagCount.Location = new Point(3, 23);
            DataGridView_TagCount.Name = "DataGridView_TagCount";
            DataGridView_TagCount.Size = new Size(238, 721);
            DataGridView_TagCount.TabIndex = 1;
            // 
            // TableLayoutPanel_References
            // 
            TableLayoutPanel_References.ColumnCount = 1;
            TableLayoutPanel_References.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_References.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_References.Controls.Add(DataGridView_References, 0, 1);
            TableLayoutPanel_References.Controls.Add(Label_References, 0, 0);
            TableLayoutPanel_References.Dock = DockStyle.Fill;
            TableLayoutPanel_References.Location = new Point(922, 3);
            TableLayoutPanel_References.Name = "TableLayoutPanel_References";
            TableLayoutPanel_References.RowCount = 2;
            TableLayoutPanel_References.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_References.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_References.Size = new Size(244, 747);
            TableLayoutPanel_References.TabIndex = 4;
            // 
            // DataGridView_References
            // 
            DataGridView_References.AllowUserToAddRows = false;
            DataGridView_References.AllowUserToDeleteRows = false;
            DataGridView_References.AllowUserToResizeColumns = false;
            DataGridView_References.AllowUserToResizeRows = false;
            DataGridView_References.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_References.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_References.Dock = DockStyle.Fill;
            DataGridView_References.Location = new Point(3, 23);
            DataGridView_References.Name = "DataGridView_References";
            DataGridView_References.Size = new Size(238, 721);
            DataGridView_References.TabIndex = 0;
            // 
            // Label_References
            // 
            Label_References.AutoSize = true;
            Label_References.Location = new Point(3, 0);
            Label_References.Name = "Label_References";
            Label_References.Size = new Size(64, 15);
            Label_References.TabIndex = 1;
            Label_References.Text = "References";
            // 
            // UserStoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 803);
            Controls.Add(TableLayoutPanel_Body);
            Name = "UserStoryForm";
            Text = "userStoryForm";
            TableLayoutPanel_Body.ResumeLayout(false);
            FlowLayoutPanel_Navigation.ResumeLayout(false);
            FlowLayoutPanel_Navigation.PerformLayout();
            TableLayoutPanel_Content.ResumeLayout(false);
            TableLayoutPanel_UserStory.ResumeLayout(false);
            FlowLayoutPanel_Controls.ResumeLayout(false);
            TableLayoutPanel_Summary.ResumeLayout(false);
            TableLayoutPanel_Summary.PerformLayout();
            TableLayoutPanel_TaskList.ResumeLayout(false);
            TableLayoutPanel_TaskList.PerformLayout();
            TableLayoutPanel_TagCount.ResumeLayout(false);
            TableLayoutPanel_TagCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_TagCount).EndInit();
            TableLayoutPanel_References.ResumeLayout(false);
            TableLayoutPanel_References.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_References).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_Body;
        private LinkLabel LinkLabel_Organization;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Label_Seperator1;
        private LinkLabel LinkLabel_Project;
        private Label Label_Seperator2;
        private TableLayoutPanel TableLayoutPanel_Content;
        private Label Label_Summary;
        private Label Label_TaskList;
        private Button Button_HideSummary;
        private Button Button_HideReferences;
        private TableLayoutPanel TableLayoutPanel_UserStory;
        private FlowLayoutPanel FlowLayoutPanel_Controls;
        private TableLayoutPanel TableLayoutPanel_TagCount;
        private Label Label_TaskCount;
        private DataGridView DataGridView_TagCount;
        private TableLayoutPanel TableLayoutPanel_Summary;
        private TableLayoutPanel TableLayoutPanel_TaskList;
        private TableLayoutPanel TableLayoutPanel_References;
        private DataGridView DataGridView_References;
        private Label Label_References;
        private FlowLayoutPanel FlowLayoutPanel_Navigation;
        private Button Button_Summary;
        private Button Button_References;
        private RichTextBox RichTextBox_Summary;
        private RichTextBox RichTextBox_TaskList;
        private Label Label_TagCount;
        private Label Label_UserStory;
    }
}