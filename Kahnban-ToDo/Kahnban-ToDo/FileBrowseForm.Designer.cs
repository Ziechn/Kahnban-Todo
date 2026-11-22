namespace Kahnban_ToDo
{
    partial class FileBrowseForm
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
            tableLayoutPanel_body = new TableLayoutPanel();
            flowLayoutPanel_controls = new FlowLayoutPanel();
            Button_Submit = new Button();
            Button_Cancel = new Button();
            groupBox_browse = new GroupBox();
            tableLayoutPanel_browse = new TableLayoutPanel();
            Button_Browse = new Button();
            TextBox_Location = new TextBox();
            tableLayoutPanel_body.SuspendLayout();
            flowLayoutPanel_controls.SuspendLayout();
            groupBox_browse.SuspendLayout();
            tableLayoutPanel_browse.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_body
            // 
            tableLayoutPanel_body.ColumnCount = 1;
            tableLayoutPanel_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_body.Controls.Add(flowLayoutPanel_controls, 0, 1);
            tableLayoutPanel_body.Controls.Add(groupBox_browse, 0, 0);
            tableLayoutPanel_body.Dock = DockStyle.Fill;
            tableLayoutPanel_body.Location = new Point(0, 0);
            tableLayoutPanel_body.Name = "tableLayoutPanel_body";
            tableLayoutPanel_body.RowCount = 2;
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel_body.Size = new Size(464, 94);
            tableLayoutPanel_body.TabIndex = 0;
            // 
            // flowLayoutPanel_controls
            // 
            flowLayoutPanel_controls.Controls.Add(Button_Submit);
            flowLayoutPanel_controls.Controls.Add(Button_Cancel);
            flowLayoutPanel_controls.Dock = DockStyle.Fill;
            flowLayoutPanel_controls.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_controls.Location = new Point(3, 62);
            flowLayoutPanel_controls.Name = "flowLayoutPanel_controls";
            flowLayoutPanel_controls.Size = new Size(458, 29);
            flowLayoutPanel_controls.TabIndex = 0;
            // 
            // Button_Submit
            // 
            Button_Submit.Location = new Point(380, 3);
            Button_Submit.Name = "Button_Submit";
            Button_Submit.Size = new Size(75, 23);
            Button_Submit.TabIndex = 0;
            Button_Submit.Text = "Submit";
            Button_Submit.UseVisualStyleBackColor = true;
            Button_Submit.Click += Button_Submit_Click;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(299, 3);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(75, 23);
            Button_Cancel.TabIndex = 1;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // groupBox_browse
            // 
            groupBox_browse.Controls.Add(tableLayoutPanel_browse);
            groupBox_browse.Dock = DockStyle.Fill;
            groupBox_browse.Location = new Point(3, 3);
            groupBox_browse.Name = "groupBox_browse";
            groupBox_browse.Size = new Size(458, 53);
            groupBox_browse.TabIndex = 1;
            groupBox_browse.TabStop = false;
            groupBox_browse.Text = "File Location";
            // 
            // tableLayoutPanel_browse
            // 
            tableLayoutPanel_browse.ColumnCount = 2;
            tableLayoutPanel_browse.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel_browse.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_browse.Controls.Add(Button_Browse, 0, 0);
            tableLayoutPanel_browse.Controls.Add(TextBox_Location, 1, 0);
            tableLayoutPanel_browse.Dock = DockStyle.Fill;
            tableLayoutPanel_browse.Location = new Point(3, 19);
            tableLayoutPanel_browse.Name = "tableLayoutPanel_browse";
            tableLayoutPanel_browse.RowCount = 1;
            tableLayoutPanel_browse.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_browse.Size = new Size(452, 31);
            tableLayoutPanel_browse.TabIndex = 0;
            // 
            // Button_Browse
            // 
            Button_Browse.Location = new Point(3, 3);
            Button_Browse.Name = "Button_Browse";
            Button_Browse.Size = new Size(100, 23);
            Button_Browse.TabIndex = 0;
            Button_Browse.Text = "Browse";
            Button_Browse.UseVisualStyleBackColor = true;
            Button_Browse.Click += Button_Browse_Click;
            // 
            // TextBox_Location
            // 
            TextBox_Location.Dock = DockStyle.Top;
            TextBox_Location.Location = new Point(109, 3);
            TextBox_Location.Name = "TextBox_Location";
            TextBox_Location.Size = new Size(340, 23);
            TextBox_Location.TabIndex = 1;
            TextBox_Location.TextChanged += TextBox_Location_TextChanged;
            // 
            // FileBrowseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 94);
            Controls.Add(tableLayoutPanel_body);
            Name = "FileBrowseForm";
            Text = "FileBrowseForm";
            tableLayoutPanel_body.ResumeLayout(false);
            flowLayoutPanel_controls.ResumeLayout(false);
            groupBox_browse.ResumeLayout(false);
            tableLayoutPanel_browse.ResumeLayout(false);
            tableLayoutPanel_browse.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_body;
        private FlowLayoutPanel flowLayoutPanel_controls;
        private GroupBox groupBox_browse;
        private Button Button_Browse;
        private Button Button_Cancel;
        private TableLayoutPanel tableLayoutPanel_browse;
        private Button Button_Submit;
        private TextBox TextBox_Location;
    }
}