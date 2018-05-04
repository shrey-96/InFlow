﻿namespace InFlow
{
    partial class InFlow
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
            this.components = new System.ComponentModel.Container();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.box_password = new System.Windows.Forms.TextBox();
            this.box_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.Panel_Signup = new System.Windows.Forms.Panel();
            this.box_selectusername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.box_selectpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_emailid = new System.Windows.Forms.TextBox();
            this.box_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_RegisterUser = new System.Windows.Forms.Button();
            this.box_lastname = new System.Windows.Forms.TextBox();
            this.box_firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel_OTP = new System.Windows.Forms.Panel();
            this.Btn_ConfirmOTP = new System.Windows.Forms.Button();
            this.Box_OTP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Label_ResendOTP = new System.Windows.Forms.Label();
            this.box_hiddenEmail = new System.Windows.Forms.TextBox();
            this.Panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.Panel_Signup.SuspendLayout();
            this.Panel_OTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Login
            // 
            this.Panel_Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel_Login.Controls.Add(this.btn_signup);
            this.Panel_Login.Controls.Add(this.btn_login);
            this.Panel_Login.Controls.Add(this.box_password);
            this.Panel_Login.Controls.Add(this.box_username);
            this.Panel_Login.Controls.Add(this.label2);
            this.Panel_Login.Controls.Add(this.label1);
            this.Panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Login.Location = new System.Drawing.Point(0, 0);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(669, 700);
            this.Panel_Login.TabIndex = 0;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_signup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(144, 424);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(384, 55);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(144, 323);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(384, 55);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // box_password
            // 
            this.box_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_password.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_password.Location = new System.Drawing.Point(297, 238);
            this.box_password.Name = "box_password";
            this.box_password.PasswordChar = '*';
            this.box_password.Size = new System.Drawing.Size(231, 30);
            this.box_password.TabIndex = 4;
            // 
            // box_username
            // 
            this.box_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_username.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_username.Location = new System.Drawing.Point(297, 174);
            this.box_username.Name = "box_username";
            this.box_username.Size = new System.Drawing.Size(231, 29);
            this.box_username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME :";
            // 
            // ep
            // 
            this.ep.BlinkRate = 0;
            this.ep.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep.ContainerControl = this;
            // 
            // Panel_Signup
            // 
            this.Panel_Signup.Controls.Add(this.box_selectusername);
            this.Panel_Signup.Controls.Add(this.label8);
            this.Panel_Signup.Controls.Add(this.box_selectpassword);
            this.Panel_Signup.Controls.Add(this.label7);
            this.Panel_Signup.Controls.Add(this.box_emailid);
            this.Panel_Signup.Controls.Add(this.box_phone);
            this.Panel_Signup.Controls.Add(this.label5);
            this.Panel_Signup.Controls.Add(this.label6);
            this.Panel_Signup.Controls.Add(this.Btn_RegisterUser);
            this.Panel_Signup.Controls.Add(this.box_lastname);
            this.Panel_Signup.Controls.Add(this.box_firstname);
            this.Panel_Signup.Controls.Add(this.label3);
            this.Panel_Signup.Controls.Add(this.label4);
            this.Panel_Signup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Signup.Location = new System.Drawing.Point(0, 0);
            this.Panel_Signup.Name = "Panel_Signup";
            this.Panel_Signup.Size = new System.Drawing.Size(669, 700);
            this.Panel_Signup.TabIndex = 7;
            // 
            // box_selectusername
            // 
            this.box_selectusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_selectusername.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_selectusername.Location = new System.Drawing.Point(281, 329);
            this.box_selectusername.Name = "box_selectusername";
            this.box_selectusername.Size = new System.Drawing.Size(256, 30);
            this.box_selectusername.TabIndex = 20;
            this.box_selectusername.TextChanged += new System.EventHandler(this.username_availability);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "USERNAME :";
            // 
            // box_selectpassword
            // 
            this.box_selectpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_selectpassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_selectpassword.Location = new System.Drawing.Point(281, 388);
            this.box_selectpassword.Name = "box_selectpassword";
            this.box_selectpassword.PasswordChar = '*';
            this.box_selectpassword.Size = new System.Drawing.Size(256, 30);
            this.box_selectpassword.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "PASSWORD :";
            // 
            // box_emailid
            // 
            this.box_emailid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_emailid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_emailid.Location = new System.Drawing.Point(281, 270);
            this.box_emailid.Name = "box_emailid";
            this.box_emailid.Size = new System.Drawing.Size(256, 30);
            this.box_emailid.TabIndex = 16;
            // 
            // box_phone
            // 
            this.box_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_phone.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_phone.Location = new System.Drawing.Point(281, 212);
            this.box_phone.Name = "box_phone";
            this.box_phone.Size = new System.Drawing.Size(256, 29);
            this.box_phone.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "EMAIL :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "PHONE :";
            // 
            // Btn_RegisterUser
            // 
            this.Btn_RegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_RegisterUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegisterUser.Location = new System.Drawing.Point(144, 498);
            this.Btn_RegisterUser.Name = "Btn_RegisterUser";
            this.Btn_RegisterUser.Size = new System.Drawing.Size(384, 55);
            this.Btn_RegisterUser.TabIndex = 12;
            this.Btn_RegisterUser.Text = "SIGN UP";
            this.Btn_RegisterUser.UseVisualStyleBackColor = false;
            this.Btn_RegisterUser.Click += new System.EventHandler(this.Btn_RegisterUser_Click);
            // 
            // box_lastname
            // 
            this.box_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_lastname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_lastname.Location = new System.Drawing.Point(281, 153);
            this.box_lastname.Name = "box_lastname";
            this.box_lastname.Size = new System.Drawing.Size(256, 30);
            this.box_lastname.TabIndex = 10;
            // 
            // box_firstname
            // 
            this.box_firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_firstname.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_firstname.Location = new System.Drawing.Point(281, 95);
            this.box_firstname.Name = "box_firstname";
            this.box_firstname.Size = new System.Drawing.Size(256, 29);
            this.box_firstname.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "LAST NAME :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "FIRST NAME :";
            // 
            // Panel_OTP
            // 
            this.Panel_OTP.Controls.Add(this.box_hiddenEmail);
            this.Panel_OTP.Controls.Add(this.Label_ResendOTP);
            this.Panel_OTP.Controls.Add(this.Btn_ConfirmOTP);
            this.Panel_OTP.Controls.Add(this.Box_OTP);
            this.Panel_OTP.Controls.Add(this.label14);
            this.Panel_OTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_OTP.Location = new System.Drawing.Point(0, 0);
            this.Panel_OTP.Name = "Panel_OTP";
            this.Panel_OTP.Size = new System.Drawing.Size(669, 700);
            this.Panel_OTP.TabIndex = 21;
            // 
            // Btn_ConfirmOTP
            // 
            this.Btn_ConfirmOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_ConfirmOTP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConfirmOTP.Location = new System.Drawing.Point(187, 362);
            this.Btn_ConfirmOTP.Name = "Btn_ConfirmOTP";
            this.Btn_ConfirmOTP.Size = new System.Drawing.Size(283, 49);
            this.Btn_ConfirmOTP.TabIndex = 25;
            this.Btn_ConfirmOTP.Text = "Confirm";
            this.Btn_ConfirmOTP.UseVisualStyleBackColor = false;
            // 
            // Box_OTP
            // 
            this.Box_OTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_OTP.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_OTP.Location = new System.Drawing.Point(211, 247);
            this.Box_OTP.Name = "Box_OTP";
            this.Box_OTP.PasswordChar = '*';
            this.Box_OTP.Size = new System.Drawing.Size(231, 35);
            this.Box_OTP.TabIndex = 23;
            this.Box_OTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(249, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "ENTER YOUR OTP";
            // 
            // Label_ResendOTP
            // 
            this.Label_ResendOTP.AutoSize = true;
            this.Label_ResendOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_ResendOTP.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ResendOTP.ForeColor = System.Drawing.Color.Blue;
            this.Label_ResendOTP.Location = new System.Drawing.Point(183, 300);
            this.Label_ResendOTP.Name = "Label_ResendOTP";
            this.Label_ResendOTP.Size = new System.Drawing.Size(291, 20);
            this.Label_ResendOTP.TabIndex = 26;
            this.Label_ResendOTP.Text = "Didn\'t receive OTP? Click here to resend";
            this.Label_ResendOTP.Click += new System.EventHandler(this.Label_ResendOTP_Click);
            // 
            // box_hiddenEmail
            // 
            this.box_hiddenEmail.Location = new System.Drawing.Point(484, 41);
            this.box_hiddenEmail.Name = "box_hiddenEmail";
            this.box_hiddenEmail.ReadOnly = true;
            this.box_hiddenEmail.Size = new System.Drawing.Size(100, 22);
            this.box_hiddenEmail.TabIndex = 27;
            this.box_hiddenEmail.Visible = false;
            // 
            // InFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 700);
            this.Controls.Add(this.Panel_OTP);
            this.Controls.Add(this.Panel_Signup);
            this.Controls.Add(this.Panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InFlow";
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.Panel_Signup.ResumeLayout(false);
            this.Panel_Signup.PerformLayout();
            this.Panel_OTP.ResumeLayout(false);
            this.Panel_OTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.TextBox box_username;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel Panel_Signup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_RegisterUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panel_OTP;
        private System.Windows.Forms.Button Btn_ConfirmOTP;
        private System.Windows.Forms.TextBox Box_OTP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Label_ResendOTP;
        public System.Windows.Forms.TextBox box_selectusername;
        public System.Windows.Forms.TextBox box_selectpassword;
        public System.Windows.Forms.TextBox box_emailid;
        public System.Windows.Forms.TextBox box_phone;
        public System.Windows.Forms.TextBox box_lastname;
        public System.Windows.Forms.TextBox box_firstname;
        public System.Windows.Forms.ErrorProvider ep;
        public System.Windows.Forms.TextBox box_hiddenEmail;
    }
}
