namespace First_project_sad_shit
{
    partial class RequestVolunteersForm
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
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(495, 687);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Send Request for Volunteers";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(495, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 198);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 607);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 4;
            label1.Text = "Volunteers List";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(408, 290);
            label3.Name = "label3";
            label3.Size = new Size(408, 37);
            label3.TabIndex = 6;
            label3.Text = "Request Volunteers for Project";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 361);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 8;
            label4.Text = "Select Project";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(536, 361);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 431);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 18;
            label5.Text = "Availability Filter";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 466);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 19;
            label6.Text = "Skillset Filter";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 495);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 20;
            label7.Text = "Location";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(535, 463);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 21;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(535, 492);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 22;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(535, 431);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(535, 534);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 24;
            button1.Text = "Search Volunteers";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Volunteer 1", "Volunteer 2", "Volunteer 3", "Volunteer 4", "Volunteer 5 " });
            checkedListBox1.Location = new Point(536, 573);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 25;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(536, 727);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 26;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // RequestVolunteersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 787);
            Controls.Add(button2);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Name = "RequestVolunteersForm";
            Text = "UpdateProfileForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private Button button2;
    }
}