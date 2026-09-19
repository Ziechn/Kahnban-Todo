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
            label_name = new Label();
            TextBox_Name = new TextBox();
            label1 = new Label();
            RichTextBox_Description = new RichTextBox();
            Button_Cancel = new Button();
            Button_Submit = new Button();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(10, 9);
            label_name.Name = "label_name";
            label_name.Size = new Size(42, 15);
            label_name.TabIndex = 0;
            label_name.Text = "Name:";
            label_name.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TextBox_Name
            // 
            TextBox_Name.Location = new Point(10, 27);
            TextBox_Name.Name = "TextBox_Name";
            TextBox_Name.Size = new Size(362, 23);
            TextBox_Name.TabIndex = 0;
            TextBox_Name.KeyUp += TextBox_Name_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Description:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // RichTextBox_Description
            // 
            RichTextBox_Description.Location = new Point(10, 71);
            RichTextBox_Description.Name = "RichTextBox_Description";
            RichTextBox_Description.Size = new Size(362, 249);
            RichTextBox_Description.TabIndex = 1;
            RichTextBox_Description.Text = "";
            RichTextBox_Description.KeyUp += RichTextBox_Description_KeyUp;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(10, 326);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(100, 23);
            Button_Cancel.TabIndex = 3;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Submit
            // 
            Button_Submit.Location = new Point(272, 326);
            Button_Submit.Name = "Button_Submit";
            Button_Submit.Size = new Size(100, 23);
            Button_Submit.TabIndex = 2;
            Button_Submit.Text = "Submit";
            Button_Submit.UseVisualStyleBackColor = true;
            Button_Submit.Click += Button_Submit_Click;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(Button_Submit);
            Controls.Add(Button_Cancel);
            Controls.Add(RichTextBox_Description);
            Controls.Add(label1);
            Controls.Add(TextBox_Name);
            Controls.Add(label_name);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProjectForm";
            Text = "ProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_name;
        private TextBox TextBox_Name;
        private Label label1;
        private RichTextBox RichTextBox_Description;
        private Button Button_Cancel;
        private Button Button_Submit;
    }
}