namespace PharmacyManagementSystem.AdministratorControlForms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datepickerProfDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtProfName = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboProfUserRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProfClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProfShowUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // datepickerProfDOB
            // 
            this.datepickerProfDOB.CheckedState.Parent = this.datepickerProfDOB;
            this.datepickerProfDOB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepickerProfDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepickerProfDOB.HoverState.Parent = this.datepickerProfDOB;
            this.datepickerProfDOB.Location = new System.Drawing.Point(327, 317);
            this.datepickerProfDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepickerProfDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepickerProfDOB.Name = "datepickerProfDOB";
            this.datepickerProfDOB.ShadowDecoration.Parent = this.datepickerProfDOB;
            this.datepickerProfDOB.Size = new System.Drawing.Size(298, 36);
            this.datepickerProfDOB.TabIndex = 17;
            this.datepickerProfDOB.Value = new System.DateTime(2021, 3, 30, 21, 15, 55, 919);
            // 
            // txtProfName
            // 
            this.txtProfName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProfName.DefaultText = "";
            this.txtProfName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProfName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProfName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProfName.DisabledState.Parent = this.txtProfName;
            this.txtProfName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProfName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProfName.FocusedState.Parent = this.txtProfName;
            this.txtProfName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProfName.HoverState.Parent = this.txtProfName;
            this.txtProfName.Location = new System.Drawing.Point(327, 146);
            this.txtProfName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProfName.Name = "txtProfName";
            this.txtProfName.PasswordChar = '\0';
            this.txtProfName.PlaceholderText = "";
            this.txtProfName.SelectedText = "";
            this.txtProfName.ShadowDecoration.Parent = this.txtProfName;
            this.txtProfName.Size = new System.Drawing.Size(298, 46);
            this.txtProfName.TabIndex = 16;
            // 
            // comboProfUserRole
            // 
            this.comboProfUserRole.BackColor = System.Drawing.Color.Transparent;
            this.comboProfUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboProfUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfUserRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboProfUserRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboProfUserRole.FocusedState.Parent = this.comboProfUserRole;
            this.comboProfUserRole.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboProfUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboProfUserRole.HoverState.Parent = this.comboProfUserRole;
            this.comboProfUserRole.ItemHeight = 30;
            this.comboProfUserRole.ItemsAppearance.Parent = this.comboProfUserRole;
            this.comboProfUserRole.Location = new System.Drawing.Point(327, 74);
            this.comboProfUserRole.Name = "comboProfUserRole";
            this.comboProfUserRole.ShadowDecoration.Parent = this.comboProfUserRole;
            this.comboProfUserRole.Size = new System.Drawing.Size(298, 36);
            this.comboProfUserRole.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "DOB(Date Of Birth)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Role";
            // 
            // txtProfEmail
            // 
            this.txtProfEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProfEmail.DefaultText = "";
            this.txtProfEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProfEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProfEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProfEmail.DisabledState.Parent = this.txtProfEmail;
            this.txtProfEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProfEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProfEmail.FocusedState.Parent = this.txtProfEmail;
            this.txtProfEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProfEmail.HoverState.Parent = this.txtProfEmail;
            this.txtProfEmail.Location = new System.Drawing.Point(327, 394);
            this.txtProfEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProfEmail.Name = "txtProfEmail";
            this.txtProfEmail.PasswordChar = '\0';
            this.txtProfEmail.PlaceholderText = "";
            this.txtProfEmail.SelectedText = "";
            this.txtProfEmail.ShadowDecoration.Parent = this.txtProfEmail;
            this.txtProfEmail.Size = new System.Drawing.Size(298, 46);
            this.txtProfEmail.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // txtProfPassword
            // 
            this.txtProfPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProfPassword.DefaultText = "";
            this.txtProfPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProfPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProfPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProfPassword.DisabledState.Parent = this.txtProfPassword;
            this.txtProfPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProfPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProfPassword.FocusedState.Parent = this.txtProfPassword;
            this.txtProfPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProfPassword.HoverState.Parent = this.txtProfPassword;
            this.txtProfPassword.Location = new System.Drawing.Point(327, 232);
            this.txtProfPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProfPassword.Name = "txtProfPassword";
            this.txtProfPassword.PasswordChar = '\0';
            this.txtProfPassword.PlaceholderText = "";
            this.txtProfPassword.SelectedText = "";
            this.txtProfPassword.ShadowDecoration.Parent = this.txtProfPassword;
            this.txtProfPassword.Size = new System.Drawing.Size(298, 46);
            this.txtProfPassword.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Password";
            // 
            // btnProfClear
            // 
            this.btnProfClear.BorderRadius = 15;
            this.btnProfClear.CheckedState.Parent = this.btnProfClear;
            this.btnProfClear.CustomImages.Parent = this.btnProfClear;
            this.btnProfClear.FillColor = System.Drawing.Color.SteelBlue;
            this.btnProfClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnProfClear.ForeColor = System.Drawing.Color.White;
            this.btnProfClear.HoverState.Parent = this.btnProfClear;
            this.btnProfClear.Image = ((System.Drawing.Image)(resources.GetObject("btnProfClear.Image")));
            this.btnProfClear.Location = new System.Drawing.Point(497, 499);
            this.btnProfClear.Name = "btnProfClear";
            this.btnProfClear.ShadowDecoration.Parent = this.btnProfClear;
            this.btnProfClear.Size = new System.Drawing.Size(128, 31);
            this.btnProfClear.TabIndex = 25;
            this.btnProfClear.Text = "Refresh";
            this.btnProfClear.Click += new System.EventHandler(this.btnProfClear_Click);
            // 
            // btnProfUpdate
            // 
            this.btnProfUpdate.BorderRadius = 15;
            this.btnProfUpdate.CheckedState.Parent = this.btnProfUpdate;
            this.btnProfUpdate.CustomImages.Parent = this.btnProfUpdate;
            this.btnProfUpdate.FillColor = System.Drawing.Color.SteelBlue;
            this.btnProfUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnProfUpdate.ForeColor = System.Drawing.Color.White;
            this.btnProfUpdate.HoverState.Parent = this.btnProfUpdate;
            this.btnProfUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnProfUpdate.Image")));
            this.btnProfUpdate.Location = new System.Drawing.Point(327, 499);
            this.btnProfUpdate.Name = "btnProfUpdate";
            this.btnProfUpdate.ShadowDecoration.Parent = this.btnProfUpdate;
            this.btnProfUpdate.Size = new System.Drawing.Size(128, 31);
            this.btnProfUpdate.TabIndex = 24;
            this.btnProfUpdate.Text = "Update";
            this.btnProfUpdate.Click += new System.EventHandler(this.btnProfSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(324, 468);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "*Check fields before update!";
            // 
            // labelProfShowUser
            // 
            this.labelProfShowUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfShowUser.ForeColor = System.Drawing.Color.IndianRed;
            this.labelProfShowUser.Location = new System.Drawing.Point(22, 383);
            this.labelProfShowUser.Name = "labelProfShowUser";
            this.labelProfShowUser.Size = new System.Drawing.Size(230, 25);
            this.labelProfShowUser.TabIndex = 27;
            this.labelProfShowUser.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(632, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "*Your current role is the first one you see \r\n  on this  field if you reload /ref" +
    "resh this page.";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(953, 600);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelProfShowUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnProfClear);
            this.Controls.Add(this.btnProfUpdate);
            this.Controls.Add(this.txtProfPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProfEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datepickerProfDOB);
            this.Controls.Add(this.txtProfName);
            this.Controls.Add(this.comboProfUserRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepickerProfDOB;
        private Guna.UI2.WinForms.Guna2TextBox txtProfName;
        private Guna.UI2.WinForms.Guna2ComboBox comboProfUserRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtProfEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtProfPassword;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnProfClear;
        private Guna.UI2.WinForms.Guna2Button btnProfUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProfShowUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}