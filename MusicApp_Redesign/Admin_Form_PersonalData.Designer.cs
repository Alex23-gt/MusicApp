namespace MusicApp_Redesign
{
    partial class Admin_Form_PersonalData
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
            this.groupBox_User_LoginChange = new Guna.UI2.WinForms.Guna2GroupBox();
            this.button_User_LoginChange = new Guna.UI2.WinForms.Guna2Button();
            this.label_User_Login = new System.Windows.Forms.Label();
            this.textBox_User_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox_User_ChangePassword = new Guna.UI2.WinForms.Guna2GroupBox();
            this.button_ChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.checkBox_NewPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox_OldPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label_User_NewPasswodRep = new System.Windows.Forms.Label();
            this.textBox_User_NewPasswordRep = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_User_NewPassword = new System.Windows.Forms.Label();
            this.textBox_User_NewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_User_OldPassword = new System.Windows.Forms.Label();
            this.textBox_User_OldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox_UserPlaylist_Info = new Guna.UI2.WinForms.Guna2GroupBox();
            this.button_ChangeUserDate = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_User_DateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label_User_Sex = new System.Windows.Forms.Label();
            this.textBox_User_Sex = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_User_Country = new System.Windows.Forms.Label();
            this.textBox_User_Country = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_User_DateOfBirth = new System.Windows.Forms.Label();
            this.label_User_Email = new System.Windows.Forms.Label();
            this.textBox_User_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox_User_LoginChange.SuspendLayout();
            this.groupBox_User_ChangePassword.SuspendLayout();
            this.groupBox_UserPlaylist_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_User_LoginChange
            // 
            this.groupBox_User_LoginChange.BorderColor = System.Drawing.Color.Gray;
            this.groupBox_User_LoginChange.BorderRadius = 10;
            this.groupBox_User_LoginChange.BorderThickness = 3;
            this.groupBox_User_LoginChange.Controls.Add(this.button_User_LoginChange);
            this.groupBox_User_LoginChange.Controls.Add(this.label_User_Login);
            this.groupBox_User_LoginChange.Controls.Add(this.textBox_User_Login);
            this.groupBox_User_LoginChange.CustomBorderColor = System.Drawing.Color.Gray;
            this.groupBox_User_LoginChange.FillColor = System.Drawing.Color.DimGray;
            this.groupBox_User_LoginChange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_User_LoginChange.ForeColor = System.Drawing.Color.Lime;
            this.groupBox_User_LoginChange.Location = new System.Drawing.Point(569, 358);
            this.groupBox_User_LoginChange.Name = "groupBox_User_LoginChange";
            this.groupBox_User_LoginChange.Size = new System.Drawing.Size(547, 182);
            this.groupBox_User_LoginChange.TabIndex = 26;
            this.groupBox_User_LoginChange.Text = "Смена логина";
            this.groupBox_User_LoginChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_User_LoginChange
            // 
            this.button_User_LoginChange.BorderRadius = 10;
            this.button_User_LoginChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_User_LoginChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_User_LoginChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_User_LoginChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_User_LoginChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_User_LoginChange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_User_LoginChange.ForeColor = System.Drawing.Color.Lime;
            this.button_User_LoginChange.Location = new System.Drawing.Point(17, 116);
            this.button_User_LoginChange.Name = "button_User_LoginChange";
            this.button_User_LoginChange.Size = new System.Drawing.Size(509, 45);
            this.button_User_LoginChange.TabIndex = 30;
            this.button_User_LoginChange.Text = "Сменить логин";
            this.button_User_LoginChange.Click += new System.EventHandler(this.button_User_LoginChange_Click);
            // 
            // label_User_Login
            // 
            this.label_User_Login.AutoSize = true;
            this.label_User_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_Login.ForeColor = System.Drawing.Color.Lime;
            this.label_User_Login.Location = new System.Drawing.Point(12, 63);
            this.label_User_Login.Name = "label_User_Login";
            this.label_User_Login.Size = new System.Drawing.Size(75, 28);
            this.label_User_Login.TabIndex = 20;
            this.label_User_Login.Text = "Логин:";
            // 
            // textBox_User_Login
            // 
            this.textBox_User_Login.BorderRadius = 10;
            this.textBox_User_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_User_Login.DefaultText = "";
            this.textBox_User_Login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_User_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_User_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_Login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_Login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User_Login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_Login.Location = new System.Drawing.Point(94, 63);
            this.textBox_User_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_User_Login.Name = "textBox_User_Login";
            this.textBox_User_Login.PasswordChar = '\0';
            this.textBox_User_Login.PlaceholderText = "";
            this.textBox_User_Login.SelectedText = "";
            this.textBox_User_Login.Size = new System.Drawing.Size(432, 35);
            this.textBox_User_Login.TabIndex = 19;
            // 
            // groupBox_User_ChangePassword
            // 
            this.groupBox_User_ChangePassword.BorderColor = System.Drawing.Color.Gray;
            this.groupBox_User_ChangePassword.BorderRadius = 10;
            this.groupBox_User_ChangePassword.BorderThickness = 3;
            this.groupBox_User_ChangePassword.Controls.Add(this.button_ChangePassword);
            this.groupBox_User_ChangePassword.Controls.Add(this.checkBox_NewPassword);
            this.groupBox_User_ChangePassword.Controls.Add(this.checkBox_OldPassword);
            this.groupBox_User_ChangePassword.Controls.Add(this.label_User_NewPasswodRep);
            this.groupBox_User_ChangePassword.Controls.Add(this.textBox_User_NewPasswordRep);
            this.groupBox_User_ChangePassword.Controls.Add(this.label_User_NewPassword);
            this.groupBox_User_ChangePassword.Controls.Add(this.textBox_User_NewPassword);
            this.groupBox_User_ChangePassword.Controls.Add(this.label_User_OldPassword);
            this.groupBox_User_ChangePassword.Controls.Add(this.textBox_User_OldPassword);
            this.groupBox_User_ChangePassword.CustomBorderColor = System.Drawing.Color.Gray;
            this.groupBox_User_ChangePassword.FillColor = System.Drawing.Color.DimGray;
            this.groupBox_User_ChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_User_ChangePassword.ForeColor = System.Drawing.Color.Lime;
            this.groupBox_User_ChangePassword.Location = new System.Drawing.Point(565, 12);
            this.groupBox_User_ChangePassword.Name = "groupBox_User_ChangePassword";
            this.groupBox_User_ChangePassword.Size = new System.Drawing.Size(547, 340);
            this.groupBox_User_ChangePassword.TabIndex = 25;
            this.groupBox_User_ChangePassword.Text = "Смена пароля";
            this.groupBox_User_ChangePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ChangePassword
            // 
            this.button_ChangePassword.BorderRadius = 10;
            this.button_ChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_ChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_ChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_ChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_ChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChangePassword.ForeColor = System.Drawing.Color.Lime;
            this.button_ChangePassword.Location = new System.Drawing.Point(21, 282);
            this.button_ChangePassword.Name = "button_ChangePassword";
            this.button_ChangePassword.Size = new System.Drawing.Size(509, 45);
            this.button_ChangePassword.TabIndex = 29;
            this.button_ChangePassword.Text = "Сменить пароль";
            this.button_ChangePassword.Click += new System.EventHandler(this.button_ChangePassword_Click);
            // 
            // checkBox_NewPassword
            // 
            this.checkBox_NewPassword.AutoSize = true;
            this.checkBox_NewPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_NewPassword.CheckedState.BorderRadius = 0;
            this.checkBox_NewPassword.CheckedState.BorderThickness = 0;
            this.checkBox_NewPassword.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.checkBox_NewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_NewPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_NewPassword.ForeColor = System.Drawing.Color.White;
            this.checkBox_NewPassword.Location = new System.Drawing.Point(21, 245);
            this.checkBox_NewPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBox_NewPassword.Name = "checkBox_NewPassword";
            this.checkBox_NewPassword.Size = new System.Drawing.Size(175, 21);
            this.checkBox_NewPassword.TabIndex = 28;
            this.checkBox_NewPassword.Text = "Показать новый пароль";
            this.checkBox_NewPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_NewPassword.UncheckedState.BorderRadius = 0;
            this.checkBox_NewPassword.UncheckedState.BorderThickness = 0;
            this.checkBox_NewPassword.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.checkBox_NewPassword.CheckedChanged += new System.EventHandler(this.checkBox_NewPassword_CheckedChanged);
            // 
            // checkBox_OldPassword
            // 
            this.checkBox_OldPassword.AutoSize = true;
            this.checkBox_OldPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_OldPassword.CheckedState.BorderRadius = 0;
            this.checkBox_OldPassword.CheckedState.BorderThickness = 0;
            this.checkBox_OldPassword.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.checkBox_OldPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_OldPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_OldPassword.ForeColor = System.Drawing.Color.White;
            this.checkBox_OldPassword.Location = new System.Drawing.Point(21, 220);
            this.checkBox_OldPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBox_OldPassword.Name = "checkBox_OldPassword";
            this.checkBox_OldPassword.Size = new System.Drawing.Size(179, 21);
            this.checkBox_OldPassword.TabIndex = 27;
            this.checkBox_OldPassword.Text = "Показать старый пароль";
            this.checkBox_OldPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_OldPassword.UncheckedState.BorderRadius = 0;
            this.checkBox_OldPassword.UncheckedState.BorderThickness = 0;
            this.checkBox_OldPassword.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.checkBox_OldPassword.CheckedChanged += new System.EventHandler(this.checkBox_OldPassword_CheckedChanged);
            // 
            // label_User_NewPasswodRep
            // 
            this.label_User_NewPasswodRep.AutoSize = true;
            this.label_User_NewPasswodRep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_NewPasswodRep.ForeColor = System.Drawing.Color.Lime;
            this.label_User_NewPasswodRep.Location = new System.Drawing.Point(16, 179);
            this.label_User_NewPasswodRep.Name = "label_User_NewPasswodRep";
            this.label_User_NewPasswodRep.Size = new System.Drawing.Size(262, 28);
            this.label_User_NewPasswodRep.TabIndex = 26;
            this.label_User_NewPasswodRep.Text = "Повторите новый пароль:";
            // 
            // textBox_User_NewPasswordRep
            // 
            this.textBox_User_NewPasswordRep.BorderRadius = 10;
            this.textBox_User_NewPasswordRep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_User_NewPasswordRep.DefaultText = "";
            this.textBox_User_NewPasswordRep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_User_NewPasswordRep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_User_NewPasswordRep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_NewPasswordRep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_NewPasswordRep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_NewPasswordRep.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User_NewPasswordRep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_NewPasswordRep.Location = new System.Drawing.Point(280, 179);
            this.textBox_User_NewPasswordRep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_User_NewPasswordRep.MaxLength = 10;
            this.textBox_User_NewPasswordRep.Name = "textBox_User_NewPasswordRep";
            this.textBox_User_NewPasswordRep.PasswordChar = '*';
            this.textBox_User_NewPasswordRep.PlaceholderText = "";
            this.textBox_User_NewPasswordRep.SelectedText = "";
            this.textBox_User_NewPasswordRep.Size = new System.Drawing.Size(250, 35);
            this.textBox_User_NewPasswordRep.TabIndex = 25;
            // 
            // label_User_NewPassword
            // 
            this.label_User_NewPassword.AutoSize = true;
            this.label_User_NewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_NewPassword.ForeColor = System.Drawing.Color.Lime;
            this.label_User_NewPassword.Location = new System.Drawing.Point(16, 124);
            this.label_User_NewPassword.Name = "label_User_NewPassword";
            this.label_User_NewPassword.Size = new System.Drawing.Size(156, 28);
            this.label_User_NewPassword.TabIndex = 20;
            this.label_User_NewPassword.Text = "Новый пароль:";
            // 
            // textBox_User_NewPassword
            // 
            this.textBox_User_NewPassword.BorderRadius = 10;
            this.textBox_User_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_User_NewPassword.DefaultText = "";
            this.textBox_User_NewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_User_NewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_User_NewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_NewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_NewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_NewPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User_NewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_NewPassword.Location = new System.Drawing.Point(179, 122);
            this.textBox_User_NewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_User_NewPassword.MaxLength = 10;
            this.textBox_User_NewPassword.Name = "textBox_User_NewPassword";
            this.textBox_User_NewPassword.PasswordChar = '*';
            this.textBox_User_NewPassword.PlaceholderText = "";
            this.textBox_User_NewPassword.SelectedText = "";
            this.textBox_User_NewPassword.Size = new System.Drawing.Size(351, 37);
            this.textBox_User_NewPassword.TabIndex = 19;
            // 
            // label_User_OldPassword
            // 
            this.label_User_OldPassword.AutoSize = true;
            this.label_User_OldPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_OldPassword.ForeColor = System.Drawing.Color.Lime;
            this.label_User_OldPassword.Location = new System.Drawing.Point(16, 70);
            this.label_User_OldPassword.Name = "label_User_OldPassword";
            this.label_User_OldPassword.Size = new System.Drawing.Size(161, 28);
            this.label_User_OldPassword.TabIndex = 18;
            this.label_User_OldPassword.Text = "Старый пароль:";
            // 
            // textBox_User_OldPassword
            // 
            this.textBox_User_OldPassword.BorderRadius = 10;
            this.textBox_User_OldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_User_OldPassword.DefaultText = "";
            this.textBox_User_OldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_User_OldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_User_OldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_OldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_OldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_OldPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User_OldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_OldPassword.Location = new System.Drawing.Point(184, 70);
            this.textBox_User_OldPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_User_OldPassword.MaxLength = 10;
            this.textBox_User_OldPassword.Name = "textBox_User_OldPassword";
            this.textBox_User_OldPassword.PasswordChar = '*';
            this.textBox_User_OldPassword.PlaceholderText = "";
            this.textBox_User_OldPassword.SelectedText = "";
            this.textBox_User_OldPassword.Size = new System.Drawing.Size(346, 35);
            this.textBox_User_OldPassword.TabIndex = 17;
            // 
            // groupBox_UserPlaylist_Info
            // 
            this.groupBox_UserPlaylist_Info.BorderColor = System.Drawing.Color.Gray;
            this.groupBox_UserPlaylist_Info.BorderRadius = 10;
            this.groupBox_UserPlaylist_Info.BorderThickness = 3;
            this.groupBox_UserPlaylist_Info.Controls.Add(this.button_ChangeUserDate);
            this.groupBox_UserPlaylist_Info.Controls.Add(this.textBox_User_DateOfBirth);
            this.groupBox_UserPlaylist_Info.Controls.Add(this.label_User_Sex);
            this.groupBox_UserPlaylist_Info.Controls.Add(this.textBox_User_Sex);
            this.groupBox_UserPlaylist_Info.Controls.Add(this.label_User_Country);
            this.groupBox_UserPlaylist_Info.Controls.Add(this.textBox_User_Country);
            this.groupBox_UserPlaylist_Info.Controls.Add(this.label_User_DateOfBirth);
            this.groupBox_UserPlaylist_Info.Controls.Add(this.label_User_Email);
            this.groupBox_UserPlaylist_Info.Controls.Add(this.textBox_User_Email);
            this.groupBox_UserPlaylist_Info.CustomBorderColor = System.Drawing.Color.Gray;
            this.groupBox_UserPlaylist_Info.FillColor = System.Drawing.Color.DimGray;
            this.groupBox_UserPlaylist_Info.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_UserPlaylist_Info.ForeColor = System.Drawing.Color.Lime;
            this.groupBox_UserPlaylist_Info.Location = new System.Drawing.Point(12, 12);
            this.groupBox_UserPlaylist_Info.Name = "groupBox_UserPlaylist_Info";
            this.groupBox_UserPlaylist_Info.Size = new System.Drawing.Size(547, 340);
            this.groupBox_UserPlaylist_Info.TabIndex = 24;
            this.groupBox_UserPlaylist_Info.Text = "Дополнительная информация";
            this.groupBox_UserPlaylist_Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ChangeUserDate
            // 
            this.button_ChangeUserDate.BorderRadius = 10;
            this.button_ChangeUserDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_ChangeUserDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_ChangeUserDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_ChangeUserDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_ChangeUserDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ChangeUserDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChangeUserDate.ForeColor = System.Drawing.Color.Lime;
            this.button_ChangeUserDate.Location = new System.Drawing.Point(14, 282);
            this.button_ChangeUserDate.Name = "button_ChangeUserDate";
            this.button_ChangeUserDate.Size = new System.Drawing.Size(516, 45);
            this.button_ChangeUserDate.TabIndex = 30;
            this.button_ChangeUserDate.Text = "Изменить данные";
            this.button_ChangeUserDate.Click += new System.EventHandler(this.button_ChangeUserDate_Click);
            // 
            // textBox_User_DateOfBirth
            // 
            this.textBox_User_DateOfBirth.Checked = true;
            this.textBox_User_DateOfBirth.FillColor = System.Drawing.Color.White;
            this.textBox_User_DateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User_DateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBox_User_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textBox_User_DateOfBirth.Location = new System.Drawing.Point(187, 125);
            this.textBox_User_DateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.textBox_User_DateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.textBox_User_DateOfBirth.Name = "textBox_User_DateOfBirth";
            this.textBox_User_DateOfBirth.Size = new System.Drawing.Size(151, 36);
            this.textBox_User_DateOfBirth.TabIndex = 27;
            this.textBox_User_DateOfBirth.Value = new System.DateTime(2024, 6, 9, 16, 31, 1, 678);
            // 
            // label_User_Sex
            // 
            this.label_User_Sex.AutoSize = true;
            this.label_User_Sex.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_Sex.ForeColor = System.Drawing.Color.Lime;
            this.label_User_Sex.Location = new System.Drawing.Point(25, 236);
            this.label_User_Sex.Name = "label_User_Sex";
            this.label_User_Sex.Size = new System.Drawing.Size(55, 28);
            this.label_User_Sex.TabIndex = 26;
            this.label_User_Sex.Text = "Пол:";
            // 
            // textBox_User_Sex
            // 
            this.textBox_User_Sex.BorderRadius = 10;
            this.textBox_User_Sex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_User_Sex.DefaultText = "";
            this.textBox_User_Sex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_User_Sex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_User_Sex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_Sex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_Sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_Sex.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User_Sex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_Sex.Location = new System.Drawing.Point(80, 236);
            this.textBox_User_Sex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_User_Sex.Name = "textBox_User_Sex";
            this.textBox_User_Sex.PasswordChar = '\0';
            this.textBox_User_Sex.PlaceholderText = "";
            this.textBox_User_Sex.SelectedText = "";
            this.textBox_User_Sex.Size = new System.Drawing.Size(450, 35);
            this.textBox_User_Sex.TabIndex = 25;
            // 
            // label_User_Country
            // 
            this.label_User_Country.AutoSize = true;
            this.label_User_Country.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_Country.ForeColor = System.Drawing.Color.Lime;
            this.label_User_Country.Location = new System.Drawing.Point(16, 186);
            this.label_User_Country.Name = "label_User_Country";
            this.label_User_Country.Size = new System.Drawing.Size(82, 28);
            this.label_User_Country.TabIndex = 24;
            this.label_User_Country.Text = "Страна:";
            // 
            // textBox_User_Country
            // 
            this.textBox_User_Country.BorderRadius = 10;
            this.textBox_User_Country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_User_Country.DefaultText = "";
            this.textBox_User_Country.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_User_Country.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_User_Country.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_Country.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_Country.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_Country.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User_Country.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_Country.Location = new System.Drawing.Point(105, 181);
            this.textBox_User_Country.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_User_Country.Name = "textBox_User_Country";
            this.textBox_User_Country.PasswordChar = '\0';
            this.textBox_User_Country.PlaceholderText = "";
            this.textBox_User_Country.SelectedText = "";
            this.textBox_User_Country.Size = new System.Drawing.Size(425, 35);
            this.textBox_User_Country.TabIndex = 23;
            // 
            // label_User_DateOfBirth
            // 
            this.label_User_DateOfBirth.AutoSize = true;
            this.label_User_DateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_DateOfBirth.ForeColor = System.Drawing.Color.Lime;
            this.label_User_DateOfBirth.Location = new System.Drawing.Point(16, 125);
            this.label_User_DateOfBirth.Name = "label_User_DateOfBirth";
            this.label_User_DateOfBirth.Size = new System.Drawing.Size(165, 28);
            this.label_User_DateOfBirth.TabIndex = 22;
            this.label_User_DateOfBirth.Text = "Дата рождения:";
            // 
            // label_User_Email
            // 
            this.label_User_Email.AutoSize = true;
            this.label_User_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User_Email.ForeColor = System.Drawing.Color.Lime;
            this.label_User_Email.Location = new System.Drawing.Point(16, 70);
            this.label_User_Email.Name = "label_User_Email";
            this.label_User_Email.Size = new System.Drawing.Size(201, 28);
            this.label_User_Email.TabIndex = 20;
            this.label_User_Email.Text = "Электронная почта:";
            // 
            // textBox_User_Email
            // 
            this.textBox_User_Email.BorderRadius = 10;
            this.textBox_User_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_User_Email.DefaultText = "";
            this.textBox_User_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_User_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_User_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_User_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_Email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_User_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_User_Email.Location = new System.Drawing.Point(224, 70);
            this.textBox_User_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_User_Email.Name = "textBox_User_Email";
            this.textBox_User_Email.PasswordChar = '\0';
            this.textBox_User_Email.PlaceholderText = "";
            this.textBox_User_Email.SelectedText = "";
            this.textBox_User_Email.Size = new System.Drawing.Size(306, 35);
            this.textBox_User_Email.TabIndex = 19;
            // 
            // Admin_Form_PersonalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1128, 759);
            this.Controls.Add(this.groupBox_User_LoginChange);
            this.Controls.Add(this.groupBox_User_ChangePassword);
            this.Controls.Add(this.groupBox_UserPlaylist_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Form_PersonalData";
            this.Text = "Admin_Form_PersonalData";
            this.Load += new System.EventHandler(this.Admin_Form_PersonalData_Load);
            this.groupBox_User_LoginChange.ResumeLayout(false);
            this.groupBox_User_LoginChange.PerformLayout();
            this.groupBox_User_ChangePassword.ResumeLayout(false);
            this.groupBox_User_ChangePassword.PerformLayout();
            this.groupBox_UserPlaylist_Info.ResumeLayout(false);
            this.groupBox_UserPlaylist_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox_User_LoginChange;
        private Guna.UI2.WinForms.Guna2Button button_User_LoginChange;
        private System.Windows.Forms.Label label_User_Login;
        private Guna.UI2.WinForms.Guna2TextBox textBox_User_Login;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_User_ChangePassword;
        private Guna.UI2.WinForms.Guna2Button button_ChangePassword;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_NewPassword;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_OldPassword;
        private System.Windows.Forms.Label label_User_NewPasswodRep;
        private Guna.UI2.WinForms.Guna2TextBox textBox_User_NewPasswordRep;
        private System.Windows.Forms.Label label_User_NewPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBox_User_NewPassword;
        private System.Windows.Forms.Label label_User_OldPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBox_User_OldPassword;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_UserPlaylist_Info;
        private Guna.UI2.WinForms.Guna2Button button_ChangeUserDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker textBox_User_DateOfBirth;
        private System.Windows.Forms.Label label_User_Sex;
        private Guna.UI2.WinForms.Guna2TextBox textBox_User_Sex;
        private System.Windows.Forms.Label label_User_Country;
        private Guna.UI2.WinForms.Guna2TextBox textBox_User_Country;
        private System.Windows.Forms.Label label_User_DateOfBirth;
        private System.Windows.Forms.Label label_User_Email;
        private Guna.UI2.WinForms.Guna2TextBox textBox_User_Email;
    }
}