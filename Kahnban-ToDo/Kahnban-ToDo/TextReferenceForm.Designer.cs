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
            groupBox_title.SuspendLayout();
            groupBox_text.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_title
            // 
            groupBox_title.Controls.Add(TextBox_Title);
            groupBox_title.Location = new Point(12, 12);
            groupBox_title.Name = "groupBox_title";
            groupBox_title.Size = new Size(440, 56);
            groupBox_title.TabIndex = 0;
            groupBox_title.TabStop = false;
            groupBox_title.Text = "Title";
            // 
            // TextBox_Title
            // 
            TextBox_Title.Location = new Point(6, 22);
            TextBox_Title.Name = "TextBox_Title";
            TextBox_Title.Size = new Size(428, 23);
            TextBox_Title.TabIndex = 0;
            TextBox_Title.KeyUp += TextBox_Title_KeyUp;
            // 
            // groupBox_text
            // 
            groupBox_text.Controls.Add(RichTextBox_Content);
            groupBox_text.Location = new Point(12, 74);
            groupBox_text.Name = "groupBox_text";
            groupBox_text.Size = new Size(440, 446);
            groupBox_text.TabIndex = 1;
            groupBox_text.TabStop = false;
            groupBox_text.Text = "Text";
            // 
            // RichTextBox_Content
            // 
            RichTextBox_Content.Dock = DockStyle.Fill;
            RichTextBox_Content.Location = new Point(3, 19);
            RichTextBox_Content.Name = "RichTextBox_Content";
            RichTextBox_Content.Size = new Size(434, 424);
            RichTextBox_Content.TabIndex = 1;
            RichTextBox_Content.Text = "";
            RichTextBox_Content.KeyUp += RichTextBox_Content_KeyUp;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(12, 526);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(100, 23);
            Button_Cancel.TabIndex = 0;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(352, 526);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(100, 23);
            Button_Save.TabIndex = 2;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // TextReferenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 561);
            Controls.Add(Button_Save);
            Controls.Add(Button_Cancel);
            Controls.Add(groupBox_text);
            Controls.Add(groupBox_title);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TextReferenceForm";
            Text = "Add Text Reference";
            Shown += TextReferenceForm_Shown;
            groupBox_title.ResumeLayout(false);
            groupBox_title.PerformLayout();
            groupBox_text.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_title;
        private TextBox TextBox_Title;
        private GroupBox groupBox_text;
        private RichTextBox RichTextBox_Content;
        private Button Button_Cancel;
        private Button Button_Save;
    }
}