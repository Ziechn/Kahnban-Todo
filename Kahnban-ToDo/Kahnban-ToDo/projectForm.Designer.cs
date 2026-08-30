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
            TableLayoutPanel_Content = new TableLayoutPanel();
            TableLayoutPanel_TagCount = new TableLayoutPanel();
            Label_TagCount = new Label();
            DataGridView_TagCount = new DataGridView();
            TableLayoutPanel_UserStories = new TableLayoutPanel();
            Label_UserStories = new Label();
            DataGridView_UserStories = new DataGridView();
            TableLayoutPanel_Body.SuspendLayout();
            FlowLayoutPanel_Navigation.SuspendLayout();
            TableLayoutPanel_Content.SuspendLayout();
            TableLayoutPanel_TagCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_TagCount).BeginInit();
            TableLayoutPanel_UserStories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_UserStories).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel_Body
            // 
            TableLayoutPanel_Body.ColumnCount = 1;
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Body.Controls.Add(FlowLayoutPanel_Navigation, 0, 0);
            TableLayoutPanel_Body.Controls.Add(TableLayoutPanel_Content, 0, 1);
            TableLayoutPanel_Body.Dock = DockStyle.Fill;
            TableLayoutPanel_Body.Location = new Point(0, 0);
            TableLayoutPanel_Body.Name = "TableLayoutPanel_Body";
            TableLayoutPanel_Body.RowCount = 3;
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
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
            // TableLayoutPanel_Content
            // 
            TableLayoutPanel_Content.ColumnCount = 2;
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_TagCount, 0, 0);
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_UserStories, 1, 0);
            TableLayoutPanel_Content.Dock = DockStyle.Fill;
            TableLayoutPanel_Content.Location = new Point(3, 33);
            TableLayoutPanel_Content.Name = "TableLayoutPanel_Content";
            TableLayoutPanel_Content.RowCount = 1;
            TableLayoutPanel_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Content.Size = new Size(975, 663);
            TableLayoutPanel_Content.TabIndex = 1;
            // 
            // TableLayoutPanel_TagCount
            // 
            TableLayoutPanel_TagCount.ColumnCount = 1;
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.Controls.Add(Label_TagCount, 0, 0);
            TableLayoutPanel_TagCount.Controls.Add(DataGridView_TagCount, 0, 1);
            TableLayoutPanel_TagCount.Dock = DockStyle.Fill;
            TableLayoutPanel_TagCount.Location = new Point(3, 3);
            TableLayoutPanel_TagCount.Name = "TableLayoutPanel_TagCount";
            TableLayoutPanel_TagCount.RowCount = 2;
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.Size = new Size(244, 657);
            TableLayoutPanel_TagCount.TabIndex = 0;
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
            DataGridView_TagCount.AllowUserToResizeColumns = false;
            DataGridView_TagCount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_TagCount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_TagCount.Dock = DockStyle.Fill;
            DataGridView_TagCount.Location = new Point(3, 23);
            DataGridView_TagCount.Name = "DataGridView_TagCount";
            DataGridView_TagCount.Size = new Size(238, 631);
            DataGridView_TagCount.TabIndex = 1;
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
            TableLayoutPanel_UserStories.Size = new Size(719, 657);
            TableLayoutPanel_UserStories.TabIndex = 1;
            // 
            // Label_UserStories
            // 
            Label_UserStories.AutoSize = true;
            Label_UserStories.Location = new Point(3, 0);
            Label_UserStories.Name = "Label_UserStories";
            Label_UserStories.Size = new Size(68, 15);
            Label_UserStories.TabIndex = 0;
            Label_UserStories.Text = "User Stories";
            // 
            // DataGridView_UserStories
            // 
            DataGridView_UserStories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_UserStories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_UserStories.Dock = DockStyle.Fill;
            DataGridView_UserStories.Location = new Point(3, 23);
            DataGridView_UserStories.Name = "DataGridView_UserStories";
            DataGridView_UserStories.Size = new Size(713, 631);
            DataGridView_UserStories.TabIndex = 1;
            DataGridView_UserStories.CellDoubleClick += DataGridView_UserStories_CellDoubleClick;
            DataGridView_UserStories.CellEndEdit += DataGridView_UserStories_CellEndEdit;
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
            TableLayoutPanel_Content.ResumeLayout(false);
            TableLayoutPanel_TagCount.ResumeLayout(false);
            TableLayoutPanel_TagCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_TagCount).EndInit();
            TableLayoutPanel_UserStories.ResumeLayout(false);
            TableLayoutPanel_UserStories.PerformLayout();
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
        private Label Label_TagCount;
        private DataGridView DataGridView_TagCount;
        private TableLayoutPanel TableLayoutPanel_UserStories;
        private Label Label_UserStories;
        private DataGridView DataGridView_UserStories;
    }
}