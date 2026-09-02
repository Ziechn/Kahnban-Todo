namespace Kahnban_ToDo
{
    partial class FileReferenceForm
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
            label_title = new Label();
            TextBox_Title = new TextBox();
            groupBox_fileLocation = new GroupBox();
            Button_Browse = new Button();
            TextBox_Location = new TextBox();
            Button_Save = new Button();
            Button_Cancel = new Button();
            groupBox_fileLocation.SuspendLayout();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Location = new Point(12, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(33, 15);
            label_title.TabIndex = 0;
            label_title.Text = "Title:";
            // 
            // TextBox_Title
            // 
            TextBox_Title.Location = new Point(12, 27);
            TextBox_Title.Name = "TextBox_Title";
            TextBox_Title.Size = new Size(250, 23);
            TextBox_Title.TabIndex = 1;
            TextBox_Title.KeyUp += TextBox_Title_KeyUp;
            // 
            // groupBox_fileLocation
            // 
            groupBox_fileLocation.Controls.Add(Button_Browse);
            groupBox_fileLocation.Controls.Add(TextBox_Location);
            groupBox_fileLocation.Location = new Point(12, 56);
            groupBox_fileLocation.Name = "groupBox_fileLocation";
            groupBox_fileLocation.Size = new Size(440, 59);
            groupBox_fileLocation.TabIndex = 2;
            groupBox_fileLocation.TabStop = false;
            groupBox_fileLocation.Text = "File Location";
            // 
            // Button_Browse
            // 
            Button_Browse.Location = new Point(6, 22);
            Button_Browse.Name = "Button_Browse";
            Button_Browse.Size = new Size(100, 23);
            Button_Browse.TabIndex = 1;
            Button_Browse.Text = "Browse";
            Button_Browse.UseVisualStyleBackColor = true;
            Button_Browse.Click += Button_Browse_Click;
            // 
            // TextBox_Location
            // 
            TextBox_Location.Location = new Point(112, 22);
            TextBox_Location.Name = "TextBox_Location";
            TextBox_Location.Size = new Size(322, 23);
            TextBox_Location.TabIndex = 0;
            TextBox_Location.KeyUp += TextBox_Location_KeyUp;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(352, 146);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(100, 23);
            Button_Save.TabIndex = 3;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(12, 146);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(100, 23);
            Button_Cancel.TabIndex = 4;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // FileReferenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 181);
            Controls.Add(Button_Cancel);
            Controls.Add(Button_Save);
            Controls.Add(groupBox_fileLocation);
            Controls.Add(TextBox_Title);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FileReferenceForm";
            Text = "FileReferenceForm";
            groupBox_fileLocation.ResumeLayout(false);
            groupBox_fileLocation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private TextBox TextBox_Title;
        private GroupBox groupBox_fileLocation;
        private Button Button_Browse;
        private TextBox TextBox_Location;
        private Button Button_Save;
        private Button Button_Cancel;
        private Label label1;
    }
}