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
            FlowLayoutPanel_Controls = new FlowLayoutPanel();
            Button_SideBar = new Button();
            Button_Summary = new Button();
            label_pipe = new Label();
            TextBox_Category = new TextBox();
            ComboBox_Status = new ComboBox();
            label_pipe2 = new Label();
            label_start = new Label();
            DateTimePicker_Start = new DateTimePicker();
            label_due = new Label();
            DateTimePicker_Due = new DateTimePicker();
            label_end = new Label();
            DateTimePicker_End = new DateTimePicker();
            TableLayoutPanel_Content = new TableLayoutPanel();
            TableLayoutPanel_SideBar = new TableLayoutPanel();
            DataGridView_References = new DataGridView();
            Label_Status = new Label();
            Label_References = new Label();
            DataGridView_Status = new DataGridView();
            panel_referenceControls = new Panel();
            Button_AddMedia = new Button();
            Button_AddText = new Button();
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
            ((System.ComponentModel.ISupportInitialize)DataGridView_Status).BeginInit();
            panel_referenceControls.SuspendLayout();
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
            TableLayoutPanel_Body.Size = new Size(1100, 803);
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
            FlowLayoutPanel_Navigation.Size = new Size(1100, 30);
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
            // FlowLayoutPanel_Controls
            // 
            FlowLayoutPanel_Controls.Controls.Add(Button_SideBar);
            FlowLayoutPanel_Controls.Controls.Add(Button_Summary);
            FlowLayoutPanel_Controls.Controls.Add(label_pipe);
            FlowLayoutPanel_Controls.Controls.Add(TextBox_Category);
            FlowLayoutPanel_Controls.Controls.Add(ComboBox_Status);
            FlowLayoutPanel_Controls.Controls.Add(label_pipe2);
            FlowLayoutPanel_Controls.Controls.Add(label_start);
            FlowLayoutPanel_Controls.Controls.Add(DateTimePicker_Start);
            FlowLayoutPanel_Controls.Controls.Add(label_due);
            FlowLayoutPanel_Controls.Controls.Add(DateTimePicker_Due);
            FlowLayoutPanel_Controls.Controls.Add(label_end);
            FlowLayoutPanel_Controls.Controls.Add(DateTimePicker_End);
            FlowLayoutPanel_Controls.Dock = DockStyle.Fill;
            FlowLayoutPanel_Controls.Location = new Point(3, 33);
            FlowLayoutPanel_Controls.Name = "FlowLayoutPanel_Controls";
            FlowLayoutPanel_Controls.Size = new Size(1094, 29);
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
            // label_pipe
            // 
            label_pipe.Location = new Point(215, 0);
            label_pipe.Name = "label_pipe";
            label_pipe.Size = new Size(10, 23);
            label_pipe.TabIndex = 7;
            label_pipe.Text = "|";
            label_pipe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBox_Category
            // 
            TextBox_Category.Location = new Point(231, 3);
            TextBox_Category.Name = "TextBox_Category";
            TextBox_Category.Size = new Size(150, 23);
            TextBox_Category.TabIndex = 13;
            TextBox_Category.Enter += TextBox_Category_Enter;
            TextBox_Category.KeyUp += TextBox_Category_KeyUp;
            TextBox_Category.Leave += TextBox_Category_Leave;
            // 
            // ComboBox_Status
            // 
            ComboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Status.FormattingEnabled = true;
            ComboBox_Status.Location = new Point(387, 3);
            ComboBox_Status.Name = "ComboBox_Status";
            ComboBox_Status.Size = new Size(150, 23);
            ComboBox_Status.TabIndex = 15;
            ComboBox_Status.SelectedIndexChanged += ComboBox_Status_SelectedIndexChanged;
            // 
            // label_pipe2
            // 
            label_pipe2.Location = new Point(543, 0);
            label_pipe2.Name = "label_pipe2";
            label_pipe2.Size = new Size(10, 23);
            label_pipe2.TabIndex = 14;
            label_pipe2.Text = "|";
            label_pipe2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_start
            // 
            label_start.Location = new Point(559, 0);
            label_start.Name = "label_start";
            label_start.Size = new Size(35, 23);
            label_start.TabIndex = 8;
            label_start.Text = "Start:";
            label_start.TextAlign = ContentAlignment.BottomRight;
            // 
            // DateTimePicker_Start
            // 
            DateTimePicker_Start.Format = DateTimePickerFormat.Short;
            DateTimePicker_Start.Location = new Point(600, 3);
            DateTimePicker_Start.Name = "DateTimePicker_Start";
            DateTimePicker_Start.Size = new Size(100, 23);
            DateTimePicker_Start.TabIndex = 6;
            DateTimePicker_Start.ValueChanged += DateTimePicker_Start_ValueChanged;
            // 
            // label_due
            // 
            label_due.Location = new Point(706, 0);
            label_due.Name = "label_due";
            label_due.Size = new Size(31, 23);
            label_due.TabIndex = 9;
            label_due.Text = "Due:";
            label_due.TextAlign = ContentAlignment.BottomRight;
            // 
            // DateTimePicker_Due
            // 
            DateTimePicker_Due.Format = DateTimePickerFormat.Short;
            DateTimePicker_Due.Location = new Point(743, 3);
            DateTimePicker_Due.Name = "DateTimePicker_Due";
            DateTimePicker_Due.Size = new Size(100, 23);
            DateTimePicker_Due.TabIndex = 10;
            DateTimePicker_Due.ValueChanged += DateTimePicker_Due_ValueChanged;
            // 
            // label_end
            // 
            label_end.Location = new Point(849, 0);
            label_end.Name = "label_end";
            label_end.Size = new Size(31, 23);
            label_end.TabIndex = 11;
            label_end.Text = "End:";
            label_end.TextAlign = ContentAlignment.BottomRight;
            // 
            // DateTimePicker_End
            // 
            DateTimePicker_End.Format = DateTimePickerFormat.Short;
            DateTimePicker_End.Location = new Point(886, 3);
            DateTimePicker_End.Name = "DateTimePicker_End";
            DateTimePicker_End.Size = new Size(100, 23);
            DateTimePicker_End.TabIndex = 12;
            DateTimePicker_End.ValueChanged += DateTimePicker_End_ValueChanged;
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
            TableLayoutPanel_Content.Size = new Size(1100, 718);
            TableLayoutPanel_Content.TabIndex = 2;
            // 
            // TableLayoutPanel_SideBar
            // 
            TableLayoutPanel_SideBar.ColumnCount = 1;
            TableLayoutPanel_SideBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel_SideBar.Controls.Add(DataGridView_References, 0, 3);
            TableLayoutPanel_SideBar.Controls.Add(Label_Status, 0, 0);
            TableLayoutPanel_SideBar.Controls.Add(Label_References, 0, 2);
            TableLayoutPanel_SideBar.Controls.Add(DataGridView_Status, 0, 1);
            TableLayoutPanel_SideBar.Controls.Add(panel_referenceControls, 0, 4);
            TableLayoutPanel_SideBar.Dock = DockStyle.Fill;
            TableLayoutPanel_SideBar.Location = new Point(3, 3);
            TableLayoutPanel_SideBar.Name = "TableLayoutPanel_SideBar";
            TableLayoutPanel_SideBar.RowCount = 5;
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel_SideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            TableLayoutPanel_SideBar.Size = new Size(244, 712);
            TableLayoutPanel_SideBar.TabIndex = 3;
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
            DataGridView_References.Location = new Point(3, 364);
            DataGridView_References.Name = "DataGridView_References";
            DataGridView_References.Size = new Size(238, 315);
            DataGridView_References.TabIndex = 0;
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
            // Label_References
            // 
            Label_References.Dock = DockStyle.Fill;
            Label_References.Location = new Point(3, 341);
            Label_References.Name = "Label_References";
            Label_References.Size = new Size(238, 20);
            Label_References.TabIndex = 1;
            Label_References.Text = "References";
            Label_References.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataGridView_Status
            // 
            DataGridView_Status.AllowUserToAddRows = false;
            DataGridView_Status.AllowUserToDeleteRows = false;
            DataGridView_Status.AllowUserToResizeRows = false;
            DataGridView_Status.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Status.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Status.Dock = DockStyle.Fill;
            DataGridView_Status.Location = new Point(3, 23);
            DataGridView_Status.Name = "DataGridView_Status";
            DataGridView_Status.Size = new Size(238, 315);
            DataGridView_Status.TabIndex = 1;
            // 
            // panel_referenceControls
            // 
            panel_referenceControls.Controls.Add(Button_AddMedia);
            panel_referenceControls.Controls.Add(Button_AddText);
            panel_referenceControls.Dock = DockStyle.Fill;
            panel_referenceControls.Location = new Point(0, 682);
            panel_referenceControls.Margin = new Padding(0);
            panel_referenceControls.Name = "panel_referenceControls";
            panel_referenceControls.Size = new Size(244, 30);
            panel_referenceControls.TabIndex = 2;
            // 
            // Button_AddMedia
            // 
            Button_AddMedia.Location = new Point(3, 3);
            Button_AddMedia.Name = "Button_AddMedia";
            Button_AddMedia.Size = new Size(115, 23);
            Button_AddMedia.TabIndex = 0;
            Button_AddMedia.Text = "Add Media";
            Button_AddMedia.UseVisualStyleBackColor = true;
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
            TableLayoutPanel_UserStory.Size = new Size(844, 712);
            TableLayoutPanel_UserStory.TabIndex = 2;
            // 
            // RichTextBox_Summary
            // 
            RichTextBox_Summary.Dock = DockStyle.Fill;
            RichTextBox_Summary.Location = new Point(3, 23);
            RichTextBox_Summary.Name = "RichTextBox_Summary";
            RichTextBox_Summary.Size = new Size(838, 114);
            RichTextBox_Summary.TabIndex = 3;
            RichTextBox_Summary.Text = "";
            RichTextBox_Summary.KeyUp += RichTextBox_Summary_KeyUp;
            // 
            // RichTextBox_TaskList
            // 
            RichTextBox_TaskList.Dock = DockStyle.Fill;
            RichTextBox_TaskList.Location = new Point(3, 163);
            RichTextBox_TaskList.Name = "RichTextBox_TaskList";
            RichTextBox_TaskList.Size = new Size(838, 546);
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
            Label_Summary.Size = new Size(838, 14);
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
            Label_TaskList.Size = new Size(838, 14);
            Label_TaskList.TabIndex = 3;
            Label_TaskList.Text = "Tasks";
            Label_TaskList.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserStoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 803);
            Controls.Add(TableLayoutPanel_Body);
            Name = "UserStoryForm";
            Text = "userStoryForm";
            TableLayoutPanel_Body.ResumeLayout(false);
            FlowLayoutPanel_Navigation.ResumeLayout(false);
            FlowLayoutPanel_Navigation.PerformLayout();
            FlowLayoutPanel_Controls.ResumeLayout(false);
            FlowLayoutPanel_Controls.PerformLayout();
            TableLayoutPanel_Content.ResumeLayout(false);
            TableLayoutPanel_SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_References).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Status).EndInit();
            panel_referenceControls.ResumeLayout(false);
            TableLayoutPanel_UserStory.ResumeLayout(false);
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
        private DataGridView DataGridView_Status;
        private TableLayoutPanel TableLayoutPanel_SideBar;
        private DataGridView DataGridView_References;
        private Label Label_References;
        private FlowLayoutPanel FlowLayoutPanel_Navigation;
        private Button Button_Summary;
        private Button Button_SideBar;
        private RichTextBox RichTextBox_Summary;
        private RichTextBox RichTextBox_TaskList;
        private Label Label_Status;
        private Label Label_UserStory;
        private Label label_pipe;
        private Label label_start;
        private DateTimePicker DateTimePicker_Start;
        private Label label_due;
        private DateTimePicker DateTimePicker_Due;
        private Button Button_AddMedia;
        private Button Button_AddText;
        private Panel panel_referenceControls;
        private Label label_end;
        private DateTimePicker DateTimePicker_End;
        private TextBox TextBox_Category;
        private Label label_pipe2;
        private ComboBox ComboBox_Status;
    }
}