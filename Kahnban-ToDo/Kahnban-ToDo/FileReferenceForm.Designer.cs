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
            textBox1 = new TextBox();
            groupBox_fileLocation = new GroupBox();
            textBox2 = new TextBox();
            Button_Browse = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox_fileLocation
            // 
            groupBox_fileLocation.Controls.Add(Button_Browse);
            groupBox_fileLocation.Controls.Add(textBox2);
            groupBox_fileLocation.Location = new Point(12, 56);
            groupBox_fileLocation.Name = "groupBox_fileLocation";
            groupBox_fileLocation.Size = new Size(440, 59);
            groupBox_fileLocation.TabIndex = 2;
            groupBox_fileLocation.TabStop = false;
            groupBox_fileLocation.Text = "File Location";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 23);
            textBox2.TabIndex = 0;
            // 
            // Button_Browse
            // 
            Button_Browse.Location = new Point(6, 22);
            Button_Browse.Name = "Button_Browse";
            Button_Browse.Size = new Size(100, 23);
            Button_Browse.TabIndex = 1;
            Button_Browse.Text = "Browse";
            Button_Browse.UseVisualStyleBackColor = true;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(352, 146);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(100, 23);
            Button_Save.TabIndex = 3;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = true;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(12, 146);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(100, 23);
            Button_Cancel.TabIndex = 4;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // FileReferenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 181);
            Controls.Add(Button_Cancel);
            Controls.Add(Button_Save);
            Controls.Add(groupBox_fileLocation);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private GroupBox groupBox_fileLocation;
        private Button Button_Browse;
        private TextBox textBox2;
        private Button Button_Save;
        private Button Button_Cancel;
        private Label label1;
    }
}