namespace MusicApp_Redesign
{
    partial class Admin_Form
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label_Logo = new System.Windows.Forms.Label();
            this.iconButton_Search = new FontAwesome.Sharp.IconButton();
            this.panel_Navigation_Search_Left = new System.Windows.Forms.Panel();
            this.panel_Navigation_Search = new System.Windows.Forms.Panel();
            this.iconButton_UserData = new FontAwesome.Sharp.IconButton();
            this.panel_Navigation_User_Left = new System.Windows.Forms.Panel();
            this.panel_Navigation_User = new System.Windows.Forms.Panel();
            this.iconButton_Settings = new FontAwesome.Sharp.IconButton();
            this.panel_Navigation_Settings_Left = new System.Windows.Forms.Panel();
            this.iconButton_Exit = new FontAwesome.Sharp.IconButton();
            this.panel_Navigation_Exit = new System.Windows.Forms.Panel();
            this.panel_Navigation = new System.Windows.Forms.Panel();
            this.panel_Navigation_Settings = new System.Windows.Forms.Panel();
            this.iconButton_Maximize = new FontAwesome.Sharp.IconButton();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.iconButton_Minimaze = new FontAwesome.Sharp.IconButton();
            this.iconButton_Close = new FontAwesome.Sharp.IconButton();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Logo.SuspendLayout();
            this.panel_Navigation_Search.SuspendLayout();
            this.panel_Navigation_User.SuspendLayout();
            this.panel_Navigation_Exit.SuspendLayout();
            this.panel_Navigation.SuspendLayout();
            this.panel_Navigation_Settings.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.DimGray;
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(226, 51);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1174, 759);
            this.panel_Content.TabIndex = 5;
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Logo.Controls.Add(this.label_Logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(226, 137);
            this.panel_Logo.TabIndex = 0;
            // 
            // label_Logo
            // 
            this.label_Logo.AutoSize = true;
            this.label_Logo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Logo.ForeColor = System.Drawing.Color.Lime;
            this.label_Logo.Location = new System.Drawing.Point(23, 46);
            this.label_Logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(184, 45);
            this.label_Logo.TabIndex = 1;
            this.label_Logo.Text = "Music App";
            // 
            // iconButton_Search
            // 
            this.iconButton_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton_Search.FlatAppearance.BorderSize = 0;
            this.iconButton_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_Search.ForeColor = System.Drawing.Color.White;
            this.iconButton_Search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton_Search.IconColor = System.Drawing.Color.White;
            this.iconButton_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Search.Location = new System.Drawing.Point(10, 0);
            this.iconButton_Search.Name = "iconButton_Search";
            this.iconButton_Search.Size = new System.Drawing.Size(216, 67);
            this.iconButton_Search.TabIndex = 1;
            this.iconButton_Search.Text = "Обзор";
            this.iconButton_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Search.UseVisualStyleBackColor = false;
            this.iconButton_Search.Click += new System.EventHandler(this.iconButton_Search_Click);
            // 
            // panel_Navigation_Search_Left
            // 
            this.panel_Navigation_Search_Left.BackColor = System.Drawing.Color.Lime;
            this.panel_Navigation_Search_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Navigation_Search_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Navigation_Search_Left.Name = "panel_Navigation_Search_Left";
            this.panel_Navigation_Search_Left.Size = new System.Drawing.Size(10, 67);
            this.panel_Navigation_Search_Left.TabIndex = 0;
            this.panel_Navigation_Search_Left.Visible = false;
            // 
            // panel_Navigation_Search
            // 
            this.panel_Navigation_Search.Controls.Add(this.iconButton_Search);
            this.panel_Navigation_Search.Controls.Add(this.panel_Navigation_Search_Left);
            this.panel_Navigation_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Navigation_Search.Location = new System.Drawing.Point(0, 137);
            this.panel_Navigation_Search.Name = "panel_Navigation_Search";
            this.panel_Navigation_Search.Size = new System.Drawing.Size(226, 67);
            this.panel_Navigation_Search.TabIndex = 0;
            // 
            // iconButton_UserData
            // 
            this.iconButton_UserData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_UserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton_UserData.FlatAppearance.BorderSize = 0;
            this.iconButton_UserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_UserData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_UserData.ForeColor = System.Drawing.Color.White;
            this.iconButton_UserData.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton_UserData.IconColor = System.Drawing.Color.White;
            this.iconButton_UserData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_UserData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_UserData.Location = new System.Drawing.Point(10, 0);
            this.iconButton_UserData.Name = "iconButton_UserData";
            this.iconButton_UserData.Size = new System.Drawing.Size(216, 67);
            this.iconButton_UserData.TabIndex = 1;
            this.iconButton_UserData.Text = "Личный кабинет";
            this.iconButton_UserData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_UserData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_UserData.UseVisualStyleBackColor = false;
            this.iconButton_UserData.Click += new System.EventHandler(this.iconButton_UserData_Click);
            // 
            // panel_Navigation_User_Left
            // 
            this.panel_Navigation_User_Left.BackColor = System.Drawing.Color.Lime;
            this.panel_Navigation_User_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Navigation_User_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Navigation_User_Left.Name = "panel_Navigation_User_Left";
            this.panel_Navigation_User_Left.Size = new System.Drawing.Size(10, 67);
            this.panel_Navigation_User_Left.TabIndex = 0;
            this.panel_Navigation_User_Left.Visible = false;
            // 
            // panel_Navigation_User
            // 
            this.panel_Navigation_User.Controls.Add(this.iconButton_UserData);
            this.panel_Navigation_User.Controls.Add(this.panel_Navigation_User_Left);
            this.panel_Navigation_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Navigation_User.Location = new System.Drawing.Point(0, 204);
            this.panel_Navigation_User.Name = "panel_Navigation_User";
            this.panel_Navigation_User.Size = new System.Drawing.Size(226, 67);
            this.panel_Navigation_User.TabIndex = 1;
            // 
            // iconButton_Settings
            // 
            this.iconButton_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton_Settings.FlatAppearance.BorderSize = 0;
            this.iconButton_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Settings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_Settings.ForeColor = System.Drawing.Color.White;
            this.iconButton_Settings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconButton_Settings.IconColor = System.Drawing.Color.White;
            this.iconButton_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Settings.Location = new System.Drawing.Point(10, 0);
            this.iconButton_Settings.Name = "iconButton_Settings";
            this.iconButton_Settings.Size = new System.Drawing.Size(216, 67);
            this.iconButton_Settings.TabIndex = 1;
            this.iconButton_Settings.Text = "Настройки";
            this.iconButton_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Settings.UseVisualStyleBackColor = false;
            this.iconButton_Settings.Click += new System.EventHandler(this.iconButton_Settings_Click);
            // 
            // panel_Navigation_Settings_Left
            // 
            this.panel_Navigation_Settings_Left.BackColor = System.Drawing.Color.Lime;
            this.panel_Navigation_Settings_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Navigation_Settings_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Navigation_Settings_Left.Name = "panel_Navigation_Settings_Left";
            this.panel_Navigation_Settings_Left.Size = new System.Drawing.Size(10, 67);
            this.panel_Navigation_Settings_Left.TabIndex = 0;
            this.panel_Navigation_Settings_Left.Visible = false;
            // 
            // iconButton_Exit
            // 
            this.iconButton_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton_Exit.FlatAppearance.BorderSize = 0;
            this.iconButton_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_Exit.ForeColor = System.Drawing.Color.White;
            this.iconButton_Exit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton_Exit.IconColor = System.Drawing.Color.White;
            this.iconButton_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Exit.Location = new System.Drawing.Point(0, 0);
            this.iconButton_Exit.Name = "iconButton_Exit";
            this.iconButton_Exit.Size = new System.Drawing.Size(226, 67);
            this.iconButton_Exit.TabIndex = 1;
            this.iconButton_Exit.Text = "Выход";
            this.iconButton_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Exit.UseVisualStyleBackColor = true;
            this.iconButton_Exit.Click += new System.EventHandler(this.iconButton_Exit_Click);
            // 
            // panel_Navigation_Exit
            // 
            this.panel_Navigation_Exit.Controls.Add(this.iconButton_Exit);
            this.panel_Navigation_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Navigation_Exit.Location = new System.Drawing.Point(0, 692);
            this.panel_Navigation_Exit.Name = "panel_Navigation_Exit";
            this.panel_Navigation_Exit.Size = new System.Drawing.Size(226, 67);
            this.panel_Navigation_Exit.TabIndex = 3;
            // 
            // panel_Navigation
            // 
            this.panel_Navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Navigation.Controls.Add(this.panel_Navigation_Exit);
            this.panel_Navigation.Controls.Add(this.panel_Navigation_Settings);
            this.panel_Navigation.Controls.Add(this.panel_Navigation_User);
            this.panel_Navigation.Controls.Add(this.panel_Navigation_Search);
            this.panel_Navigation.Controls.Add(this.panel_Logo);
            this.panel_Navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Navigation.Location = new System.Drawing.Point(0, 51);
            this.panel_Navigation.Name = "panel_Navigation";
            this.panel_Navigation.Size = new System.Drawing.Size(226, 759);
            this.panel_Navigation.TabIndex = 4;
            // 
            // panel_Navigation_Settings
            // 
            this.panel_Navigation_Settings.Controls.Add(this.iconButton_Settings);
            this.panel_Navigation_Settings.Controls.Add(this.panel_Navigation_Settings_Left);
            this.panel_Navigation_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Navigation_Settings.Location = new System.Drawing.Point(0, 271);
            this.panel_Navigation_Settings.Name = "panel_Navigation_Settings";
            this.panel_Navigation_Settings.Size = new System.Drawing.Size(226, 67);
            this.panel_Navigation_Settings.TabIndex = 2;
            // 
            // iconButton_Maximize
            // 
            this.iconButton_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_Maximize.FlatAppearance.BorderSize = 0;
            this.iconButton_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Maximize.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButton_Maximize.IconColor = System.Drawing.Color.White;
            this.iconButton_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Maximize.Location = new System.Drawing.Point(1304, 7);
            this.iconButton_Maximize.Name = "iconButton_Maximize";
            this.iconButton_Maximize.Size = new System.Drawing.Size(39, 38);
            this.iconButton_Maximize.TabIndex = 6;
            this.iconButton_Maximize.TabStop = false;
            this.iconButton_Maximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton_Maximize.UseVisualStyleBackColor = false;
            this.iconButton_Maximize.Click += new System.EventHandler(this.iconButton_Maximize_Click);
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Welcome.ForeColor = System.Drawing.Color.Lime;
            this.label_Welcome.Location = new System.Drawing.Point(12, 17);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(0, 28);
            this.label_Welcome.TabIndex = 5;
            // 
            // iconButton_Minimaze
            // 
            this.iconButton_Minimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_Minimaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_Minimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_Minimaze.FlatAppearance.BorderSize = 0;
            this.iconButton_Minimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_Minimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Minimaze.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton_Minimaze.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton_Minimaze.IconColor = System.Drawing.Color.White;
            this.iconButton_Minimaze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Minimaze.Location = new System.Drawing.Point(1259, 7);
            this.iconButton_Minimaze.Name = "iconButton_Minimaze";
            this.iconButton_Minimaze.Size = new System.Drawing.Size(39, 38);
            this.iconButton_Minimaze.TabIndex = 4;
            this.iconButton_Minimaze.TabStop = false;
            this.iconButton_Minimaze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton_Minimaze.UseVisualStyleBackColor = false;
            this.iconButton_Minimaze.Click += new System.EventHandler(this.iconButton_Minimaze_Click);
            // 
            // iconButton_Close
            // 
            this.iconButton_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_Close.FlatAppearance.BorderSize = 0;
            this.iconButton_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton_Close.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton_Close.IconColor = System.Drawing.Color.White;
            this.iconButton_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Close.Location = new System.Drawing.Point(1349, 7);
            this.iconButton_Close.Name = "iconButton_Close";
            this.iconButton_Close.Size = new System.Drawing.Size(39, 38);
            this.iconButton_Close.TabIndex = 3;
            this.iconButton_Close.TabStop = false;
            this.iconButton_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton_Close.UseVisualStyleBackColor = false;
            this.iconButton_Close.Click += new System.EventHandler(this.iconButton_Close_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Menu.Controls.Add(this.iconButton_Maximize);
            this.panel_Menu.Controls.Add(this.label_Welcome);
            this.panel_Menu.Controls.Add(this.iconButton_Minimaze);
            this.panel_Menu.Controls.Add(this.iconButton_Close);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1400, 51);
            this.panel_Menu.TabIndex = 3;
            this.panel_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseDown);
            this.panel_Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseMove);
            this.panel_Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseUp);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1400, 810);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Navigation);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.panel_Navigation_Search.ResumeLayout(false);
            this.panel_Navigation_User.ResumeLayout(false);
            this.panel_Navigation_Exit.ResumeLayout(false);
            this.panel_Navigation.ResumeLayout(false);
            this.panel_Navigation_Settings.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Panel panel_Navigation;
        private System.Windows.Forms.Panel panel_Navigation_Exit;
        private FontAwesome.Sharp.IconButton iconButton_Exit;
        private System.Windows.Forms.Panel panel_Navigation_Settings;
        private FontAwesome.Sharp.IconButton iconButton_Settings;
        private System.Windows.Forms.Panel panel_Navigation_Settings_Left;
        private System.Windows.Forms.Panel panel_Navigation_User;
        private FontAwesome.Sharp.IconButton iconButton_UserData;
        private System.Windows.Forms.Panel panel_Navigation_User_Left;
        private System.Windows.Forms.Panel panel_Navigation_Search;
        private FontAwesome.Sharp.IconButton iconButton_Search;
        private System.Windows.Forms.Panel panel_Navigation_Search_Left;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Label label_Logo;
        private System.Windows.Forms.Panel panel_Menu;
        private FontAwesome.Sharp.IconButton iconButton_Maximize;
        private System.Windows.Forms.Label label_Welcome;
        private FontAwesome.Sharp.IconButton iconButton_Minimaze;
        private FontAwesome.Sharp.IconButton iconButton_Close;
    }
}