﻿namespace Hospital1._0.Forms
{
    partial class LoginForm 
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

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LabelControl lblLogin;
        private DevExpress.XtraEditors.PictureEdit pictureEditUserIcon;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;

        private void InitializeComponent()
        {
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblLogin = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditUserIcon = new DevExpress.XtraEditors.PictureEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblConnection = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditUserIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(38, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 33);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Hospital Management System";
            // 
            // lblLogin
            // 
            this.lblLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Appearance.Options.UseFont = true;
            this.lblLogin.Location = new System.Drawing.Point(186, 114);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(63, 28);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // pictureEditUserIcon
            // 
            this.pictureEditUserIcon.EditValue = global::Hospital1._0.Properties.Resources.user;
            this.pictureEditUserIcon.Location = new System.Drawing.Point(47, 208);
            this.pictureEditUserIcon.Name = "pictureEditUserIcon";
            this.pictureEditUserIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditUserIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditUserIcon.Size = new System.Drawing.Size(74, 85);
            this.pictureEditUserIcon.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(147, 214);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.AllowFocused = false;
            this.txtUsername.Properties.NullText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(175, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 261);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.NullText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(167, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 29);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.Location = new System.Drawing.Point(2, 379);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(103, 16);
            this.lblConnection.TabIndex = 6;
            this.lblConnection.Text = "Connection Status";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 400);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.pictureEditUserIcon);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTitle);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditUserIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.LabelControl lblConnection;
    }

}