namespace First_project_sad_shit
{
    partial class DashboardForm
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            viewAccountToolStripMenuItem = new ToolStripMenuItem();
            updateProfileToolStripMenuItem = new ToolStripMenuItem();
            privacySettingsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, accountToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // exToolStripMenuItem
            // 
            exToolStripMenuItem.Name = "exToolStripMenuItem";
            exToolStripMenuItem.Size = new Size(92, 22);
            exToolStripMenuItem.Text = "Exit";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAccountToolStripMenuItem, updateProfileToolStripMenuItem, privacySettingsToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(64, 20);
            accountToolStripMenuItem.Text = "Account";
            // 
            // viewAccountToolStripMenuItem
            // 
            viewAccountToolStripMenuItem.Name = "viewAccountToolStripMenuItem";
            viewAccountToolStripMenuItem.Size = new Size(180, 22);
            viewAccountToolStripMenuItem.Text = "View Account";
            // 
            // updateProfileToolStripMenuItem
            // 
            updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            updateProfileToolStripMenuItem.Size = new Size(180, 22);
            updateProfileToolStripMenuItem.Text = "Update Profile";
            // 
            // privacySettingsToolStripMenuItem
            // 
            privacySettingsToolStripMenuItem.Name = "privacySettingsToolStripMenuItem";
            privacySettingsToolStripMenuItem.Size = new Size(180, 22);
            privacySettingsToolStripMenuItem.Text = "Privacy Settings";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(284, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 164);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(321, 231);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 8;
            label3.Text = "Dashboard";
            // 
            // button1
            // 
            button1.Location = new Point(50, 290);
            button1.Name = "button1";
            button1.Size = new Size(151, 73);
            button1.TabIndex = 9;
            button1.Text = "Task Assignment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 290);
            button2.Name = "button2";
            button2.Size = new Size(151, 73);
            button2.TabIndex = 10;
            button2.Text = "Request Donation";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(408, 290);
            button3.Name = "button3";
            button3.Size = new Size(151, 73);
            button3.TabIndex = 11;
            button3.Text = "Request Volunteers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(599, 290);
            button4.Name = "button4";
            button4.Size = new Size(151, 73);
            button4.TabIndex = 12;
            button4.Text = "Create Project";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DashboardForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem viewAccountToolStripMenuItem;
        private ToolStripMenuItem updateProfileToolStripMenuItem;
        private ToolStripMenuItem privacySettingsToolStripMenuItem;
        private ToolStripMenuItem exToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}