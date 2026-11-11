namespace First_project_sad_shit
{
    partial class RegisterForm
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 425);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 633);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirm Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 521);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 578);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Password :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(593, 622);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 33);
            textBox1.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(593, 414);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 33);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(593, 510);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 33);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(593, 567);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 33);
            txtPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(690, 695);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(116, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register Button";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(564, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 191);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(632, 744);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Log in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(425, 297);
            label5.Name = "label5";
            label5.Size = new Size(492, 37);
            label5.TabIndex = 11;
            label5.Text = "Sign Up for Bahrain Trust Foundation";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Employee", "Donor", "Volunteer" });
            comboBox1.Location = new Point(593, 360);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 33);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.Location = new Point(475, 372);
            label6.Name = "label6";
            label6.Size = new Size(62, 13);
            label6.TabIndex = 13;
            label6.Text = "User Type :";
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(593, 460);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 33);
            textBox2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(458, 471);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 15;
            label7.Text = "Phone Number :";
            // 
            // button1
            // 
            button1.Location = new Point(547, 695);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 16;
            button1.Text = "Cancle";
            button1.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 861);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "Form1";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Button button1;
    }
}