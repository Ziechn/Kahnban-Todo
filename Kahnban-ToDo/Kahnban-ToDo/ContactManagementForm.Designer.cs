namespace Kahnban_ToDo
{
    partial class ContactManagementForm
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
            DataGridView_Contacts = new DataGridView();
            flowLayoutPanel_controls_top = new FlowLayoutPanel();
            Button_Contact_Delete = new Button();
            flowLayoutPanel_controls_bottom = new FlowLayoutPanel();
            Button_Submit = new Button();
            Button_Cancel = new Button();
            tableLayoutPanel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Contacts).BeginInit();
            flowLayoutPanel_controls_top.SuspendLayout();
            flowLayoutPanel_controls_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_body
            // 
            tableLayoutPanel_body.ColumnCount = 1;
            tableLayoutPanel_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_body.Controls.Add(DataGridView_Contacts, 0, 1);
            tableLayoutPanel_body.Controls.Add(flowLayoutPanel_controls_top, 0, 0);
            tableLayoutPanel_body.Controls.Add(flowLayoutPanel_controls_bottom, 0, 2);
            tableLayoutPanel_body.Dock = DockStyle.Fill;
            tableLayoutPanel_body.Location = new Point(0, 0);
            tableLayoutPanel_body.Name = "tableLayoutPanel_body";
            tableLayoutPanel_body.RowCount = 3;
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel_body.Size = new Size(584, 361);
            tableLayoutPanel_body.TabIndex = 0;
            // 
            // DataGridView_Contacts
            // 
            DataGridView_Contacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Contacts.BackgroundColor = SystemColors.ControlDarkDark;
            DataGridView_Contacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Contacts.Dock = DockStyle.Fill;
            DataGridView_Contacts.Location = new Point(3, 38);
            DataGridView_Contacts.Name = "DataGridView_Contacts";
            DataGridView_Contacts.RowHeadersVisible = false;
            DataGridView_Contacts.Size = new Size(578, 285);
            DataGridView_Contacts.TabIndex = 1;
            DataGridView_Contacts.CellClick += DataGridView_Contacts_CellClick;
            DataGridView_Contacts.CellEndEdit += DataGridView_Contacts_CellEndEdit;
            // 
            // flowLayoutPanel_controls_top
            // 
            flowLayoutPanel_controls_top.Controls.Add(Button_Contact_Delete);
            flowLayoutPanel_controls_top.Dock = DockStyle.Fill;
            flowLayoutPanel_controls_top.Location = new Point(3, 3);
            flowLayoutPanel_controls_top.Name = "flowLayoutPanel_controls_top";
            flowLayoutPanel_controls_top.Size = new Size(578, 29);
            flowLayoutPanel_controls_top.TabIndex = 2;
            // 
            // Button_Contact_Delete
            // 
            Button_Contact_Delete.Enabled = false;
            Button_Contact_Delete.Location = new Point(3, 3);
            Button_Contact_Delete.Name = "Button_Contact_Delete";
            Button_Contact_Delete.Size = new Size(125, 23);
            Button_Contact_Delete.TabIndex = 0;
            Button_Contact_Delete.Text = "Delete Contact";
            Button_Contact_Delete.UseVisualStyleBackColor = true;
            Button_Contact_Delete.Click += Button_Contact_Delete_Click;
            // 
            // flowLayoutPanel_controls_bottom
            // 
            flowLayoutPanel_controls_bottom.Controls.Add(Button_Submit);
            flowLayoutPanel_controls_bottom.Controls.Add(Button_Cancel);
            flowLayoutPanel_controls_bottom.Dock = DockStyle.Fill;
            flowLayoutPanel_controls_bottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_controls_bottom.Location = new Point(3, 329);
            flowLayoutPanel_controls_bottom.Name = "flowLayoutPanel_controls_bottom";
            flowLayoutPanel_controls_bottom.Size = new Size(578, 29);
            flowLayoutPanel_controls_bottom.TabIndex = 3;
            // 
            // Button_Submit
            // 
            Button_Submit.Enabled = false;
            Button_Submit.Location = new Point(475, 3);
            Button_Submit.Name = "Button_Submit";
            Button_Submit.Size = new Size(100, 23);
            Button_Submit.TabIndex = 0;
            Button_Submit.Text = "Submit";
            Button_Submit.UseVisualStyleBackColor = true;
            Button_Submit.Click += Button_Submit_Click;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Enabled = false;
            Button_Cancel.Location = new Point(369, 3);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(100, 23);
            Button_Cancel.TabIndex = 1;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // ContactManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(tableLayoutPanel_body);
            Name = "ContactManagementForm";
            Text = "Contact Management";
            tableLayoutPanel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_Contacts).EndInit();
            flowLayoutPanel_controls_top.ResumeLayout(false);
            flowLayoutPanel_controls_bottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_body;
        private DataGridView DataGridView_Contacts;
        private FlowLayoutPanel flowLayoutPanel_controls_top;
        private Button Button_Contact_Delete;
        private FlowLayoutPanel flowLayoutPanel_controls_bottom;
        private Button Button_Submit;
        private Button Button_Cancel;
    }
}