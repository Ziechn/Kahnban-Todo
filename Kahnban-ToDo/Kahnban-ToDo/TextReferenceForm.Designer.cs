namespace Kahnban_ToDo
{
    partial class TextReferenceForm
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
            groupBox_title = new GroupBox();
            TextBox_Title = new TextBox();
            groupBox_text = new GroupBox();
            RichTextBox_Content = new RichTextBox();
            Button_Cancel = new Button();
            Button_Save = new Button();
            tableLayoutPanel_body = new TableLayoutPanel();
            flowLayoutPanel_controls_botton = new FlowLayoutPanel();
            flowLayoutPanel_controls_top = new FlowLayoutPanel();
            Button_Print = new Button();
            groupBox_title.SuspendLayout();
            groupBox_text.SuspendLayout();
            tableLayoutPanel_body.SuspendLayout();
            flowLayoutPanel_controls_botton.SuspendLayout();
            flowLayoutPanel_controls_top.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_title
            // 
            groupBox_title.Controls.Add(TextBox_Title);
            groupBox_title.Dock = DockStyle.Fill;
            groupBox_title.Location = new Point(3, 38);
            groupBox_title.Name = "groupBox_title";
            groupBox_title.Padding = new Padding(6);
            groupBox_title.Size = new Size(578, 54);
            groupBox_title.TabIndex = 0;
            groupBox_title.TabStop = false;
            groupBox_title.Text = "Title";
            // 
            // TextBox_Title
            // 
            TextBox_Title.Dock = DockStyle.Fill;
            TextBox_Title.Location = new Point(6, 22);
            TextBox_Title.Name = "TextBox_Title";
            TextBox_Title.Size = new Size(566, 23);
            TextBox_Title.TabIndex = 0;
            TextBox_Title.KeyUp += TextBox_Title_KeyUp;
            // 
            // groupBox_text
            // 
            groupBox_text.Controls.Add(RichTextBox_Content);
            groupBox_text.Dock = DockStyle.Fill;
            groupBox_text.Location = new Point(3, 98);
            groupBox_text.Name = "groupBox_text";
            groupBox_text.Padding = new Padding(6);
            groupBox_text.Size = new Size(578, 625);
            groupBox_text.TabIndex = 1;
            groupBox_text.TabStop = false;
            groupBox_text.Text = "Text";
            // 
            // RichTextBox_Content
            // 
            RichTextBox_Content.BorderStyle = BorderStyle.None;
            RichTextBox_Content.Dock = DockStyle.Fill;
            RichTextBox_Content.Location = new Point(6, 22);
            RichTextBox_Content.Name = "RichTextBox_Content";
            RichTextBox_Content.Size = new Size(566, 597);
            RichTextBox_Content.TabIndex = 1;
            RichTextBox_Content.Text = "";
            RichTextBox_Content.KeyUp += RichTextBox_Content_KeyUp;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(369, 3);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(100, 23);
            Button_Cancel.TabIndex = 0;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(475, 3);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(100, 23);
            Button_Save.TabIndex = 2;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // tableLayoutPanel_body
            // 
            tableLayoutPanel_body.ColumnCount = 1;
            tableLayoutPanel_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_body.Controls.Add(groupBox_text, 0, 2);
            tableLayoutPanel_body.Controls.Add(groupBox_title, 0, 1);
            tableLayoutPanel_body.Controls.Add(flowLayoutPanel_controls_botton, 0, 3);
            tableLayoutPanel_body.Controls.Add(flowLayoutPanel_controls_top, 0, 0);
            tableLayoutPanel_body.Dock = DockStyle.Fill;
            tableLayoutPanel_body.Location = new Point(0, 0);
            tableLayoutPanel_body.Name = "tableLayoutPanel_body";
            tableLayoutPanel_body.RowCount = 4;
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_body.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel_body.Size = new Size(584, 761);
            tableLayoutPanel_body.TabIndex = 3;
            // 
            // flowLayoutPanel_controls_botton
            // 
            flowLayoutPanel_controls_botton.Controls.Add(Button_Save);
            flowLayoutPanel_controls_botton.Controls.Add(Button_Cancel);
            flowLayoutPanel_controls_botton.Dock = DockStyle.Fill;
            flowLayoutPanel_controls_botton.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_controls_botton.Location = new Point(3, 729);
            flowLayoutPanel_controls_botton.Name = "flowLayoutPanel_controls_botton";
            flowLayoutPanel_controls_botton.Size = new Size(578, 29);
            flowLayoutPanel_controls_botton.TabIndex = 2;
            // 
            // flowLayoutPanel_controls_top
            // 
            flowLayoutPanel_controls_top.Controls.Add(Button_Print);
            flowLayoutPanel_controls_top.Dock = DockStyle.Fill;
            flowLayoutPanel_controls_top.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel_controls_top.Location = new Point(3, 3);
            flowLayoutPanel_controls_top.Name = "flowLayoutPanel_controls_top";
            flowLayoutPanel_controls_top.Size = new Size(578, 29);
            flowLayoutPanel_controls_top.TabIndex = 3;
            // 
            // Button_Print
            // 
            Button_Print.Enabled = false;
            Button_Print.Location = new Point(450, 3);
            Button_Print.Name = "Button_Print";
            Button_Print.Size = new Size(125, 23);
            Button_Print.TabIndex = 0;
            Button_Print.Text = "Print Preview";
            Button_Print.UseVisualStyleBackColor = true;
            Button_Print.Click += Button_Print_Click;
            // 
            // TextReferenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 761);
            Controls.Add(tableLayoutPanel_body);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TextReferenceForm";
            Text = "Add Text Reference";
            Shown += TextReferenceForm_Shown;
            groupBox_title.ResumeLayout(false);
            groupBox_title.PerformLayout();
            groupBox_text.ResumeLayout(false);
            tableLayoutPanel_body.ResumeLayout(false);
            flowLayoutPanel_controls_botton.ResumeLayout(false);
            flowLayoutPanel_controls_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_title;
        private TextBox TextBox_Title;
        private GroupBox groupBox_text;
        private RichTextBox RichTextBox_Content;
        private Button Button_Cancel;
        private Button Button_Save;
        private TableLayoutPanel tableLayoutPanel_body;
        private FlowLayoutPanel flowLayoutPanel_controls_botton;
        private FlowLayoutPanel flowLayoutPanel_controls_top;
        private Button Button_Print;
    }
}