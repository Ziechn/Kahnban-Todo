namespace Kahnban_ToDo
{
    partial class OrganizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableLayoutPanel_Body = new TableLayoutPanel();
            FlowLayoutPanel_Navigation = new FlowLayoutPanel();
            Label_Organization = new Label();
            TableLayoutPanel_Content = new TableLayoutPanel();
            TableLayoutPanel_TagCount = new TableLayoutPanel();
            Label_TagCount = new Label();
            DataGridView_Tags = new DataGridView();
            TableLayoutPanel_Organization = new TableLayoutPanel();
            Label_Projects = new Label();
            DataGridView_Projects = new DataGridView();
            flowLayoutPanel_controls = new FlowLayoutPanel();
            Button_Back = new Button();
            LinkLabel_Start = new LinkLabel();
            label_navigation_separator = new Label();
            TableLayoutPanel_Body.SuspendLayout();
            FlowLayoutPanel_Navigation.SuspendLayout();
            TableLayoutPanel_Content.SuspendLayout();
            TableLayoutPanel_TagCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Tags).BeginInit();
            TableLayoutPanel_Organization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Projects).BeginInit();
            flowLayoutPanel_controls.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel_Body
            // 
            TableLayoutPanel_Body.ColumnCount = 1;
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.Controls.Add(FlowLayoutPanel_Navigation, 0, 0);
            TableLayoutPanel_Body.Controls.Add(TableLayoutPanel_Content, 0, 2);
            TableLayoutPanel_Body.Controls.Add(flowLayoutPanel_controls, 0, 1);
            TableLayoutPanel_Body.Dock = DockStyle.Fill;
            TableLayoutPanel_Body.Location = new Point(0, 0);
            TableLayoutPanel_Body.Name = "TableLayoutPanel_Body";
            TableLayoutPanel_Body.RowCount = 4;
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Body.Size = new Size(1041, 623);
            TableLayoutPanel_Body.TabIndex = 0;
            // 
            // FlowLayoutPanel_Navigation
            // 
            FlowLayoutPanel_Navigation.Controls.Add(LinkLabel_Start);
            FlowLayoutPanel_Navigation.Controls.Add(label_navigation_separator);
            FlowLayoutPanel_Navigation.Controls.Add(Label_Organization);
            FlowLayoutPanel_Navigation.Dock = DockStyle.Fill;
            FlowLayoutPanel_Navigation.Location = new Point(0, 0);
            FlowLayoutPanel_Navigation.Margin = new Padding(0);
            FlowLayoutPanel_Navigation.Name = "FlowLayoutPanel_Navigation";
            FlowLayoutPanel_Navigation.Size = new Size(1041, 30);
            FlowLayoutPanel_Navigation.TabIndex = 0;
            // 
            // Label_Organization
            // 
            Label_Organization.AutoSize = true;
            Label_Organization.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Organization.Location = new Point(91, 0);
            Label_Organization.Name = "Label_Organization";
            Label_Organization.Size = new Size(126, 25);
            Label_Organization.TabIndex = 0;
            Label_Organization.Text = "organization";
            // 
            // TableLayoutPanel_Content
            // 
            TableLayoutPanel_Content.ColumnCount = 2;
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            TableLayoutPanel_Content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_TagCount, 0, 0);
            TableLayoutPanel_Content.Controls.Add(TableLayoutPanel_Organization, 1, 0);
            TableLayoutPanel_Content.Dock = DockStyle.Fill;
            TableLayoutPanel_Content.Location = new Point(3, 68);
            TableLayoutPanel_Content.Name = "TableLayoutPanel_Content";
            TableLayoutPanel_Content.RowCount = 1;
            TableLayoutPanel_Content.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Content.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Content.Size = new Size(1035, 532);
            TableLayoutPanel_Content.TabIndex = 1;
            // 
            // TableLayoutPanel_TagCount
            // 
            TableLayoutPanel_TagCount.ColumnCount = 1;
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.Controls.Add(Label_TagCount, 0, 0);
            TableLayoutPanel_TagCount.Controls.Add(DataGridView_Tags, 0, 1);
            TableLayoutPanel_TagCount.Dock = DockStyle.Fill;
            TableLayoutPanel_TagCount.Location = new Point(3, 3);
            TableLayoutPanel_TagCount.Name = "TableLayoutPanel_TagCount";
            TableLayoutPanel_TagCount.RowCount = 2;
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_TagCount.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_TagCount.Size = new Size(244, 526);
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
            // DataGridView_Tags
            // 
            DataGridView_Tags.AllowUserToAddRows = false;
            DataGridView_Tags.AllowUserToDeleteRows = false;
            DataGridView_Tags.AllowUserToResizeColumns = false;
            DataGridView_Tags.AllowUserToResizeRows = false;
            DataGridView_Tags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Tags.BorderStyle = BorderStyle.None;
            DataGridView_Tags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Tags.Dock = DockStyle.Fill;
            DataGridView_Tags.Location = new Point(3, 23);
            DataGridView_Tags.Name = "DataGridView_Tags";
            DataGridView_Tags.ReadOnly = true;
            DataGridView_Tags.ShowCellToolTips = false;
            DataGridView_Tags.Size = new Size(238, 500);
            DataGridView_Tags.TabIndex = 1;
            // 
            // TableLayoutPanel_Organization
            // 
            TableLayoutPanel_Organization.ColumnCount = 1;
            TableLayoutPanel_Organization.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Organization.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Organization.Controls.Add(Label_Projects, 0, 0);
            TableLayoutPanel_Organization.Controls.Add(DataGridView_Projects, 0, 1);
            TableLayoutPanel_Organization.Dock = DockStyle.Fill;
            TableLayoutPanel_Organization.Location = new Point(253, 3);
            TableLayoutPanel_Organization.Name = "TableLayoutPanel_Organization";
            TableLayoutPanel_Organization.RowCount = 2;
            TableLayoutPanel_Organization.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Organization.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Organization.Size = new Size(779, 526);
            TableLayoutPanel_Organization.TabIndex = 1;
            // 
            // Label_Projects
            // 
            Label_Projects.AutoSize = true;
            Label_Projects.Location = new Point(3, 0);
            Label_Projects.Name = "Label_Projects";
            Label_Projects.Size = new Size(49, 15);
            Label_Projects.TabIndex = 0;
            Label_Projects.Text = "Projects";
            // 
            // DataGridView_Projects
            // 
            DataGridView_Projects.AllowUserToDeleteRows = false;
            DataGridView_Projects.AllowUserToResizeRows = false;
            DataGridView_Projects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Projects.BorderStyle = BorderStyle.None;
            DataGridView_Projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Projects.Dock = DockStyle.Fill;
            DataGridView_Projects.Location = new Point(3, 23);
            DataGridView_Projects.Name = "DataGridView_Projects";
            DataGridView_Projects.ShowCellToolTips = false;
            DataGridView_Projects.Size = new Size(773, 500);
            DataGridView_Projects.TabIndex = 1;
            DataGridView_Projects.CellDoubleClick += DataGridView_Projects_CellDoubleClick;
            DataGridView_Projects.CellEndEdit += DataGridView_Projects_CellEndEdit;
            DataGridView_Projects.UserDeletingRow += DataGridView_Projects_UserDeletingRow;
            // 
            // flowLayoutPanel_controls
            // 
            flowLayoutPanel_controls.Controls.Add(Button_Back);
            flowLayoutPanel_controls.Dock = DockStyle.Fill;
            flowLayoutPanel_controls.Location = new Point(3, 33);
            flowLayoutPanel_controls.Name = "flowLayoutPanel_controls";
            flowLayoutPanel_controls.Size = new Size(1035, 29);
            flowLayoutPanel_controls.TabIndex = 1;
            // 
            // Button_Back
            // 
            Button_Back.Location = new Point(3, 3);
            Button_Back.Name = "Button_Back";
            Button_Back.Size = new Size(75, 23);
            Button_Back.TabIndex = 0;
            Button_Back.Text = "Back";
            Button_Back.UseVisualStyleBackColor = true;
            Button_Back.Click += Button_Back_Click;
            // 
            // LinkLabel_Start
            // 
            LinkLabel_Start.AutoSize = true;
            LinkLabel_Start.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel_Start.LinkColor = Color.DodgerBlue;
            LinkLabel_Start.Location = new Point(3, 0);
            LinkLabel_Start.Name = "LinkLabel_Start";
            LinkLabel_Start.Size = new Size(56, 25);
            LinkLabel_Start.TabIndex = 1;
            LinkLabel_Start.TabStop = true;
            LinkLabel_Start.Text = "Start";
            // 
            // label_navigation_separator
            // 
            label_navigation_separator.AutoSize = true;
            label_navigation_separator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_navigation_separator.Location = new Point(65, 0);
            label_navigation_separator.Name = "label_navigation_separator";
            label_navigation_separator.Size = new Size(20, 25);
            label_navigation_separator.TabIndex = 2;
            label_navigation_separator.Text = "/";
            // 
            // OrganizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 623);
            Controls.Add(TableLayoutPanel_Body);
            Name = "OrganizationForm";
            Text = "Organization";
            TableLayoutPanel_Body.ResumeLayout(false);
            FlowLayoutPanel_Navigation.ResumeLayout(false);
            FlowLayoutPanel_Navigation.PerformLayout();
            TableLayoutPanel_Content.ResumeLayout(false);
            TableLayoutPanel_TagCount.ResumeLayout(false);
            TableLayoutPanel_TagCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Tags).EndInit();
            TableLayoutPanel_Organization.ResumeLayout(false);
            TableLayoutPanel_Organization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Projects).EndInit();
            flowLayoutPanel_controls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_Body;
        private FlowLayoutPanel FlowLayoutPanel_Navigation;
        private TableLayoutPanel TableLayoutPanel_Content;
        private TableLayoutPanel TableLayoutPanel_TagCount;
        private Label Label_TagCount;
        private DataGridView DataGridView_Tags;
        private TableLayoutPanel TableLayoutPanel_Organization;
        private Label Label_Projects;
        private DataGridView DataGridView_Projects;
        private Label Label_Organization;
        private FlowLayoutPanel flowLayoutPanel_controls;
        private Button Button_Back;
        private LinkLabel LinkLabel_Start;
        private Label label_navigation_separator;
    }
}
