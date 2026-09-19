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
            LinkLabel_Start = new LinkLabel();
            label_navigation_separator = new Label();
            Label_Organization = new Label();
            DataGridView_Projects = new DataGridView();
            Label_Projects = new Label();
            flowLayoutPanel_controls = new FlowLayoutPanel();
            Button_Project_Add = new Button();
            Button_Project_Edit = new Button();
            Button_Project_Delete = new Button();
            TableLayoutPanel_Body.SuspendLayout();
            FlowLayoutPanel_Navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Projects).BeginInit();
            flowLayoutPanel_controls.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel_Body
            // 
            TableLayoutPanel_Body.ColumnCount = 1;
            TableLayoutPanel_Body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.Controls.Add(FlowLayoutPanel_Navigation, 0, 0);
            TableLayoutPanel_Body.Controls.Add(DataGridView_Projects, 0, 3);
            TableLayoutPanel_Body.Controls.Add(Label_Projects, 0, 2);
            TableLayoutPanel_Body.Controls.Add(flowLayoutPanel_controls, 0, 1);
            TableLayoutPanel_Body.Dock = DockStyle.Fill;
            TableLayoutPanel_Body.Location = new Point(0, 0);
            TableLayoutPanel_Body.Name = "TableLayoutPanel_Body";
            TableLayoutPanel_Body.RowCount = 5;
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Body.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_Body.Size = new Size(984, 561);
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
            LinkLabel_Start.TabIndex = 1;
            LinkLabel_Start.TabStop = true;
            LinkLabel_Start.Text = "Start";
            LinkLabel_Start.LinkClicked += LinkLabel_Start_LinkClicked;
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
            // DataGridView_Projects
            // 
            DataGridView_Projects.AllowUserToAddRows = false;
            DataGridView_Projects.AllowUserToDeleteRows = false;
            DataGridView_Projects.AllowUserToResizeRows = false;
            DataGridView_Projects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Projects.BorderStyle = BorderStyle.None;
            DataGridView_Projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Projects.Dock = DockStyle.Fill;
            DataGridView_Projects.Location = new Point(3, 88);
            DataGridView_Projects.Name = "DataGridView_Projects";
            DataGridView_Projects.ReadOnly = true;
            DataGridView_Projects.ShowCellToolTips = false;
            DataGridView_Projects.Size = new Size(978, 450);
            DataGridView_Projects.TabIndex = 1;
            DataGridView_Projects.CellClick += DataGridView_Projects_CellClick;
            DataGridView_Projects.CellDoubleClick += DataGridView_Projects_CellDoubleClick;
            DataGridView_Projects.UserDeletingRow += DataGridView_Projects_UserDeletingRow;
            // 
            // Label_Projects
            // 
            Label_Projects.AutoSize = true;
            Label_Projects.Dock = DockStyle.Fill;
            Label_Projects.Location = new Point(3, 65);
            Label_Projects.Name = "Label_Projects";
            Label_Projects.Size = new Size(978, 20);
            Label_Projects.TabIndex = 0;
            Label_Projects.Text = "Projects";
            Label_Projects.TextAlign = ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel_controls
            // 
            flowLayoutPanel_controls.Controls.Add(Button_Project_Add);
            flowLayoutPanel_controls.Controls.Add(Button_Project_Edit);
            flowLayoutPanel_controls.Controls.Add(Button_Project_Delete);
            flowLayoutPanel_controls.Dock = DockStyle.Fill;
            flowLayoutPanel_controls.Location = new Point(3, 33);
            flowLayoutPanel_controls.Name = "flowLayoutPanel_controls";
            flowLayoutPanel_controls.Size = new Size(978, 29);
            flowLayoutPanel_controls.TabIndex = 2;
            // 
            // Button_Project_Add
            // 
            Button_Project_Add.Location = new Point(3, 3);
            Button_Project_Add.Name = "Button_Project_Add";
            Button_Project_Add.Size = new Size(125, 23);
            Button_Project_Add.TabIndex = 0;
            Button_Project_Add.Text = "Create Project";
            Button_Project_Add.UseVisualStyleBackColor = true;
            Button_Project_Add.Click += Button_Project_Add_Click;
            // 
            // Button_Project_Edit
            // 
            Button_Project_Edit.Enabled = false;
            Button_Project_Edit.Location = new Point(134, 3);
            Button_Project_Edit.Name = "Button_Project_Edit";
            Button_Project_Edit.Size = new Size(125, 23);
            Button_Project_Edit.TabIndex = 2;
            Button_Project_Edit.Text = "Edit Project";
            Button_Project_Edit.UseVisualStyleBackColor = true;
            // 
            // Button_Project_Delete
            // 
            Button_Project_Delete.Enabled = false;
            Button_Project_Delete.Location = new Point(265, 3);
            Button_Project_Delete.Name = "Button_Project_Delete";
            Button_Project_Delete.Size = new Size(125, 23);
            Button_Project_Delete.TabIndex = 1;
            Button_Project_Delete.Text = "Delete Project";
            Button_Project_Delete.UseVisualStyleBackColor = true;
            Button_Project_Delete.Click += Button_Project_Delete_Click;
            // 
            // OrganizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(TableLayoutPanel_Body);
            Name = "OrganizationForm";
            Text = "Organization";
            TableLayoutPanel_Body.ResumeLayout(false);
            TableLayoutPanel_Body.PerformLayout();
            FlowLayoutPanel_Navigation.ResumeLayout(false);
            FlowLayoutPanel_Navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Projects).EndInit();
            flowLayoutPanel_controls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_Body;
        private FlowLayoutPanel FlowLayoutPanel_Navigation;
        private Label Label_Projects;
        private DataGridView DataGridView_Projects;
        private Label Label_Organization;
        private LinkLabel LinkLabel_Start;
        private Label label_navigation_separator;
        private FlowLayoutPanel flowLayoutPanel_controls;
        private Button Button_Project_Add;
        private Button Button_Project_Delete;
        private Button Button_Project_Edit;
    }
}
