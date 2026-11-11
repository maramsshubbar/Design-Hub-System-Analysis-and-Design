namespace First_project_sad_shit
{
    partial class TaskAssignmentForm
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            VolunteerName = new DataGridViewTextBoxColumn();
            Skillset = new DataGridViewTextBoxColumn();
            Availability = new DataGridViewTextBoxColumn();
            PastPerformance = new DataGridViewTextBoxColumn();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 587);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Tasks to Assign";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 391);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Volunteer List";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(532, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 164);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(427, 270);
            label3.Name = "label3";
            label3.Size = new Size(420, 37);
            label3.TabIndex = 5;
            label3.Text = "Task Assignment for Volunteers";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(552, 329);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 337);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 7;
            label4.Text = "Select Project";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { VolunteerName, Skillset, Availability, PastPerformance });
            dataGridView1.Location = new Point(552, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 64);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // VolunteerName
            // 
            VolunteerName.HeaderText = "Volunteer Name";
            VolunteerName.Name = "VolunteerName";
            // 
            // Skillset
            // 
            Skillset.HeaderText = "Skillset";
            Skillset.Name = "Skillset";
            // 
            // Availability
            // 
            Availability.HeaderText = "Availability";
            Availability.Name = "Availability";
            // 
            // PastPerformance
            // 
            PastPerformance.HeaderText = "Past Performance";
            PastPerformance.Name = "PastPerformance";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Task 1 ", "Task 2 ", "Task 3 ", "Task 4", "Task 5 " });
            checkedListBox1.Location = new Point(553, 557);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(552, 670);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 11;
            button1.Text = "Assign Tasks";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(573, 724);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(552, 456);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(701, 456);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(552, 485);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(552, 514);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 459);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 17;
            label5.Text = "Availability Filter";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 488);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 18;
            label6.Text = "Skillset Filter";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 517);
            label7.Name = "label7";
            label7.Size = new Size(129, 15);
            label7.TabIndex = 19;
            label7.Text = "Past Performance Filter";
            // 
            // TaskAssignmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 807);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TaskAssignmentForm";
            Text = "TaskAssignmentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn VolunteerName;
        private DataGridViewTextBoxColumn Skillset;
        private DataGridViewTextBoxColumn Availability;
        private DataGridViewTextBoxColumn PastPerformance;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}