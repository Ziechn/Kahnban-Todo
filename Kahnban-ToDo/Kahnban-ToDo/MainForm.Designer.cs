namespace Kahnban_ToDo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem_SelectFolder = new ToolStripMenuItem();
            ToolStripMenuItem_Exit = new ToolStripMenuItem();
            Panel_Main = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1094, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_SelectFolder, ToolStripMenuItem_Exit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // ToolStripMenuItem_SelectFolder
            // 
            ToolStripMenuItem_SelectFolder.Name = "ToolStripMenuItem_SelectFolder";
            ToolStripMenuItem_SelectFolder.Size = new Size(180, 22);
            ToolStripMenuItem_SelectFolder.Text = "Select Folder";
            ToolStripMenuItem_SelectFolder.Click += ToolStripMenuItem_SelectFolder_Click;
            // 
            // ToolStripMenuItem_Exit
            // 
            ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            ToolStripMenuItem_Exit.Size = new Size(180, 22);
            ToolStripMenuItem_Exit.Text = "Exit";
            ToolStripMenuItem_Exit.Click += ToolStripMenuItem_Exit_Click;
            // 
            // Panel_Main
            // 
            Panel_Main.Dock = DockStyle.Fill;
            Panel_Main.Location = new Point(0, 24);
            Panel_Main.Name = "Panel_Main";
            Panel_Main.Size = new Size(1094, 595);
            Panel_Main.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 619);
            Controls.Add(Panel_Main);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(960, 600);
            Name = "MainForm";
            Text = "Projectz - 0.7.1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem_Exit;
        private Panel Panel_Main;
        private ToolStripMenuItem ToolStripMenuItem_SelectFolder;
    }
}