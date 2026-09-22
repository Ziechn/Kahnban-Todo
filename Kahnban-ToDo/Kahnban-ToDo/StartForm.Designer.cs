namespace Kahnban_ToDo
{
    partial class StartForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel_body = new TableLayoutPanel();
            label_title = new Label();
            DataGridView_Organizations = new DataGridView();
            flowLayoutPanel_controls = new FlowLayoutPanel();
            Button_Add = new Button();
            Button_Remove = new Button();
            label_organizations = new Label();
            tableLayoutPanel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Organizations).BeginInit();
            flowLayoutPanel_controls.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_body
            // 
            tableLayoutPanel_body.ColumnCount = 1;
            tableLayoutPanel_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_body.Controls.Add(label_title, 0, 0);
            tableLayoutPanel_body.Controls.Add(DataGridView_Organizations, 0, 3);
            tableLayoutPanel_body.Controls.Add(flowLayoutPanel_controls, 0, 1);
            tableLayoutPanel_body.Controls.Add(label_organizations, 0, 2);
            tableLayoutPanel_body.Dock = DockStyle.Fill;
            tableLayoutPanel_body.Location = new Point(0, 0);
            tableLayoutPanel_body.Name = "tableLayoutPanel_body";
            tableLayoutPanel_body.RowCount = 5;
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_body.Size = new Size(984, 561);
            tableLayoutPanel_body.TabIndex = 0;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(3, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(56, 25);
            label_title.TabIndex = 0;
            label_title.Text = "Start";
            // 
            // DataGridView_Organizations
            // 
            DataGridView_Organizations.AllowUserToAddRows = false;
            DataGridView_Organizations.AllowUserToDeleteRows = false;
            DataGridView_Organizations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Organizations.BackgroundColor = SystemColors.ControlDarkDark;
            DataGridView_Organizations.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridView_Organizations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_Organizations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Organizations.Dock = DockStyle.Fill;
            DataGridView_Organizations.Location = new Point(3, 88);
            DataGridView_Organizations.Name = "DataGridView_Organizations";
            DataGridView_Organizations.ReadOnly = true;
            DataGridView_Organizations.RowHeadersVisible = false;
            DataGridView_Organizations.Size = new Size(978, 450);
            DataGridView_Organizations.TabIndex = 1;
            DataGridView_Organizations.CellClick += DataGridView_Organizations_CellClick;
            DataGridView_Organizations.CellDoubleClick += DataGridView_Organizations_CellDoubleClick;
            // 
            // flowLayoutPanel_controls
            // 
            flowLayoutPanel_controls.Controls.Add(Button_Add);
            flowLayoutPanel_controls.Controls.Add(Button_Remove);
            flowLayoutPanel_controls.Dock = DockStyle.Fill;
            flowLayoutPanel_controls.Location = new Point(3, 33);
            flowLayoutPanel_controls.Name = "flowLayoutPanel_controls";
            flowLayoutPanel_controls.Size = new Size(978, 29);
            flowLayoutPanel_controls.TabIndex = 1;
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(3, 3);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(125, 23);
            Button_Add.TabIndex = 0;
            Button_Add.Text = "Add Organization";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // Button_Remove
            // 
            Button_Remove.Enabled = false;
            Button_Remove.Location = new Point(134, 3);
            Button_Remove.Name = "Button_Remove";
            Button_Remove.Size = new Size(150, 23);
            Button_Remove.TabIndex = 1;
            Button_Remove.Text = "Remove Organization";
            Button_Remove.UseVisualStyleBackColor = true;
            Button_Remove.Click += Button_Remove_Click;
            // 
            // label_organizations
            // 
            label_organizations.AutoSize = true;
            label_organizations.Dock = DockStyle.Fill;
            label_organizations.Location = new Point(3, 65);
            label_organizations.Name = "label_organizations";
            label_organizations.Size = new Size(978, 20);
            label_organizations.TabIndex = 2;
            label_organizations.Text = "Organizations";
            label_organizations.TextAlign = ContentAlignment.BottomLeft;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tableLayoutPanel_body);
            Name = "StartForm";
            Text = "StartForm";
            tableLayoutPanel_body.ResumeLayout(false);
            tableLayoutPanel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Organizations).EndInit();
            flowLayoutPanel_controls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_body;
        private Label label_title;
        private DataGridView DataGridView_Organizations;
        private FlowLayoutPanel flowLayoutPanel_controls;
        private Button Button_Add;
        private Button Button_Remove;
        private Label label_organizations;
    }
}