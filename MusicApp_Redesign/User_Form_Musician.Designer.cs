namespace MusicApp_Redesign
{
    partial class User_Form_Musician
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage_AddAlbum = new System.Windows.Forms.TabPage();
            this.tabControl_Musician = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage_AddTrack = new System.Windows.Forms.TabPage();
            this.groupBox_Music_Info = new Guna.UI2.WinForms.Guna2GroupBox();
            this.button_AddTrack = new Guna.UI2.WinForms.Guna2Button();
            this.label_Track_Album = new System.Windows.Forms.Label();
            this.label_Track_Duration = new System.Windows.Forms.Label();
            this.label_Track_Genre = new System.Windows.Forms.Label();
            this.label_Track_Name = new System.Windows.Forms.Label();
            this.comboBox_Filter_Music = new System.Windows.Forms.ComboBox();
            this.label_Filter_Music = new System.Windows.Forms.Label();
            this.textBox_Filter_Music = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Music = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_Track_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_Track_Genre = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_Track_Album = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_Track_Duration = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Warning = new System.Windows.Forms.Label();
            this.groupBox_Album_Info = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBox_Album_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_AddAlbum = new Guna.UI2.WinForms.Guna2Button();
            this.label_Album_Name = new System.Windows.Forms.Label();
            this.label_Filter_Album = new System.Windows.Forms.Label();
            this.textBox_Filter_Album = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Album = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage_AddAlbum.SuspendLayout();
            this.tabControl_Musician.SuspendLayout();
            this.tabPage_AddTrack.SuspendLayout();
            this.groupBox_Music_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Music)).BeginInit();
            this.groupBox_Album_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Album)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_AddAlbum
            // 
            this.tabPage_AddAlbum.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_AddAlbum.Controls.Add(this.groupBox_Album_Info);
            this.tabPage_AddAlbum.Controls.Add(this.label_Filter_Album);
            this.tabPage_AddAlbum.Controls.Add(this.textBox_Filter_Album);
            this.tabPage_AddAlbum.Controls.Add(this.dgv_Album);
            this.tabPage_AddAlbum.Location = new System.Drawing.Point(4, 44);
            this.tabPage_AddAlbum.Name = "tabPage_AddAlbum";
            this.tabPage_AddAlbum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AddAlbum.Size = new System.Drawing.Size(1120, 711);
            this.tabPage_AddAlbum.TabIndex = 1;
            this.tabPage_AddAlbum.Text = "Альбомы";
            // 
            // tabControl_Musician
            // 
            this.tabControl_Musician.Controls.Add(this.tabPage_AddTrack);
            this.tabControl_Musician.Controls.Add(this.tabPage_AddAlbum);
            this.tabControl_Musician.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Musician.ItemSize = new System.Drawing.Size(220, 40);
            this.tabControl_Musician.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Musician.Name = "tabControl_Musician";
            this.tabControl_Musician.SelectedIndex = 0;
            this.tabControl_Musician.Size = new System.Drawing.Size(1128, 759);
            this.tabControl_Musician.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_Musician.TabButtonHoverState.FillColor = System.Drawing.Color.Gray;
            this.tabControl_Musician.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_Musician.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl_Musician.TabButtonHoverState.InnerColor = System.Drawing.Color.DimGray;
            this.tabControl_Musician.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_Musician.TabButtonIdleState.FillColor = System.Drawing.Color.DimGray;
            this.tabControl_Musician.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_Musician.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tabControl_Musician.TabButtonIdleState.InnerColor = System.Drawing.Color.DimGray;
            this.tabControl_Musician.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_Musician.TabButtonSelectedState.FillColor = System.Drawing.Color.DimGray;
            this.tabControl_Musician.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl_Musician.TabButtonSelectedState.ForeColor = System.Drawing.Color.Lime;
            this.tabControl_Musician.TabButtonSelectedState.InnerColor = System.Drawing.Color.Lime;
            this.tabControl_Musician.TabButtonSize = new System.Drawing.Size(220, 40);
            this.tabControl_Musician.TabIndex = 2;
            this.tabControl_Musician.TabMenuBackColor = System.Drawing.Color.DimGray;
            this.tabControl_Musician.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage_AddTrack
            // 
            this.tabPage_AddTrack.BackColor = System.Drawing.Color.DimGray;
            this.tabPage_AddTrack.Controls.Add(this.groupBox_Music_Info);
            this.tabPage_AddTrack.Controls.Add(this.comboBox_Filter_Music);
            this.tabPage_AddTrack.Controls.Add(this.label_Filter_Music);
            this.tabPage_AddTrack.Controls.Add(this.textBox_Filter_Music);
            this.tabPage_AddTrack.Controls.Add(this.dgv_Music);
            this.tabPage_AddTrack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage_AddTrack.ForeColor = System.Drawing.Color.DimGray;
            this.tabPage_AddTrack.Location = new System.Drawing.Point(4, 44);
            this.tabPage_AddTrack.Name = "tabPage_AddTrack";
            this.tabPage_AddTrack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AddTrack.Size = new System.Drawing.Size(1120, 711);
            this.tabPage_AddTrack.TabIndex = 0;
            this.tabPage_AddTrack.Text = "Музыка";
            // 
            // groupBox_Music_Info
            // 
            this.groupBox_Music_Info.BorderColor = System.Drawing.Color.Gray;
            this.groupBox_Music_Info.BorderRadius = 10;
            this.groupBox_Music_Info.BorderThickness = 3;
            this.groupBox_Music_Info.Controls.Add(this.label_Warning);
            this.groupBox_Music_Info.Controls.Add(this.textBox_Track_Duration);
            this.groupBox_Music_Info.Controls.Add(this.textBox_Track_Album);
            this.groupBox_Music_Info.Controls.Add(this.textBox_Track_Genre);
            this.groupBox_Music_Info.Controls.Add(this.textBox_Track_Name);
            this.groupBox_Music_Info.Controls.Add(this.button_AddTrack);
            this.groupBox_Music_Info.Controls.Add(this.label_Track_Album);
            this.groupBox_Music_Info.Controls.Add(this.label_Track_Duration);
            this.groupBox_Music_Info.Controls.Add(this.label_Track_Genre);
            this.groupBox_Music_Info.Controls.Add(this.label_Track_Name);
            this.groupBox_Music_Info.CustomBorderColor = System.Drawing.Color.Gray;
            this.groupBox_Music_Info.FillColor = System.Drawing.Color.DimGray;
            this.groupBox_Music_Info.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Music_Info.ForeColor = System.Drawing.Color.Lime;
            this.groupBox_Music_Info.Location = new System.Drawing.Point(10, 151);
            this.groupBox_Music_Info.Name = "groupBox_Music_Info";
            this.groupBox_Music_Info.Size = new System.Drawing.Size(478, 537);
            this.groupBox_Music_Info.TabIndex = 13;
            this.groupBox_Music_Info.Text = "Добавить трек";
            this.groupBox_Music_Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_AddTrack
            // 
            this.button_AddTrack.BorderRadius = 10;
            this.button_AddTrack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_AddTrack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_AddTrack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_AddTrack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_AddTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_AddTrack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddTrack.ForeColor = System.Drawing.Color.Lime;
            this.button_AddTrack.Location = new System.Drawing.Point(17, 483);
            this.button_AddTrack.Name = "button_AddTrack";
            this.button_AddTrack.Size = new System.Drawing.Size(447, 45);
            this.button_AddTrack.TabIndex = 23;
            this.button_AddTrack.Text = "Добавить";
            this.button_AddTrack.Click += new System.EventHandler(this.button_AddTrack_Click);
            // 
            // label_Track_Album
            // 
            this.label_Track_Album.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Track_Album.ForeColor = System.Drawing.Color.Lime;
            this.label_Track_Album.Location = new System.Drawing.Point(12, 224);
            this.label_Track_Album.Name = "label_Track_Album";
            this.label_Track_Album.Size = new System.Drawing.Size(94, 36);
            this.label_Track_Album.TabIndex = 13;
            this.label_Track_Album.Text = "Альбом: ";
            // 
            // label_Track_Duration
            // 
            this.label_Track_Duration.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Track_Duration.ForeColor = System.Drawing.Color.Lime;
            this.label_Track_Duration.Location = new System.Drawing.Point(12, 169);
            this.label_Track_Duration.Name = "label_Track_Duration";
            this.label_Track_Duration.Size = new System.Drawing.Size(159, 36);
            this.label_Track_Duration.TabIndex = 11;
            this.label_Track_Duration.Text = "Длительность: ";
            // 
            // label_Track_Genre
            // 
            this.label_Track_Genre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Track_Genre.ForeColor = System.Drawing.Color.Lime;
            this.label_Track_Genre.Location = new System.Drawing.Point(12, 111);
            this.label_Track_Genre.Name = "label_Track_Genre";
            this.label_Track_Genre.Size = new System.Drawing.Size(74, 36);
            this.label_Track_Genre.TabIndex = 8;
            this.label_Track_Genre.Text = "Жанр: ";
            // 
            // label_Track_Name
            // 
            this.label_Track_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Track_Name.ForeColor = System.Drawing.Color.Lime;
            this.label_Track_Name.Location = new System.Drawing.Point(12, 59);
            this.label_Track_Name.Name = "label_Track_Name";
            this.label_Track_Name.Size = new System.Drawing.Size(110, 36);
            this.label_Track_Name.TabIndex = 7;
            this.label_Track_Name.Text = "Название: ";
            // 
            // comboBox_Filter_Music
            // 
            this.comboBox_Filter_Music.BackColor = System.Drawing.Color.Gray;
            this.comboBox_Filter_Music.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Filter_Music.ForeColor = System.Drawing.Color.Cyan;
            this.comboBox_Filter_Music.FormattingEnabled = true;
            this.comboBox_Filter_Music.Items.AddRange(new object[] {
            "Названию",
            "Жанру"});
            this.comboBox_Filter_Music.Location = new System.Drawing.Point(176, 31);
            this.comboBox_Filter_Music.Name = "comboBox_Filter_Music";
            this.comboBox_Filter_Music.Size = new System.Drawing.Size(187, 36);
            this.comboBox_Filter_Music.TabIndex = 12;
            // 
            // label_Filter_Music
            // 
            this.label_Filter_Music.AutoSize = true;
            this.label_Filter_Music.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Filter_Music.ForeColor = System.Drawing.Color.Lime;
            this.label_Filter_Music.Location = new System.Drawing.Point(5, 31);
            this.label_Filter_Music.Name = "label_Filter_Music";
            this.label_Filter_Music.Size = new System.Drawing.Size(165, 28);
            this.label_Filter_Music.TabIndex = 11;
            this.label_Filter_Music.Text = "Фильтровать по";
            // 
            // textBox_Filter_Music
            // 
            this.textBox_Filter_Music.BorderRadius = 10;
            this.textBox_Filter_Music.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Filter_Music.DefaultText = "";
            this.textBox_Filter_Music.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Filter_Music.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Filter_Music.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Filter_Music.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Filter_Music.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Filter_Music.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Filter_Music.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Filter_Music.Location = new System.Drawing.Point(6, 76);
            this.textBox_Filter_Music.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Filter_Music.Name = "textBox_Filter_Music";
            this.textBox_Filter_Music.PasswordChar = '\0';
            this.textBox_Filter_Music.PlaceholderText = "";
            this.textBox_Filter_Music.SelectedText = "";
            this.textBox_Filter_Music.Size = new System.Drawing.Size(357, 43);
            this.textBox_Filter_Music.TabIndex = 10;
            this.textBox_Filter_Music.TextChanged += new System.EventHandler(this.textBox_Filter_Music_TextChanged);
            // 
            // dgv_Music
            // 
            this.dgv_Music.AllowUserToAddRows = false;
            this.dgv_Music.AllowUserToDeleteRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            this.dgv_Music.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dgv_Music.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Music.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Music.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgv_Music.ColumnHeadersHeight = 50;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Music.DefaultCellStyle = dataGridViewCellStyle39;
            this.dgv_Music.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Music.Location = new System.Drawing.Point(519, 22);
            this.dgv_Music.Name = "dgv_Music";
            this.dgv_Music.ReadOnly = true;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Music.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgv_Music.RowHeadersVisible = false;
            this.dgv_Music.RowHeadersWidth = 51;
            this.dgv_Music.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_Music.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_Music.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Music.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgv_Music.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dgv_Music.RowTemplate.Height = 30;
            this.dgv_Music.Size = new System.Drawing.Size(596, 666);
            this.dgv_Music.TabIndex = 9;
            this.dgv_Music.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Music.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Music.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Music.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Music.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Music.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_Music.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Music.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_Music.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Music.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_Music.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Lime;
            this.dgv_Music.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Music.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_Music.ThemeStyle.ReadOnly = true;
            this.dgv_Music.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Music.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Music.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_Music.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Music.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_Music.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Music.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // textBox_Track_Name
            // 
            this.textBox_Track_Name.BorderRadius = 10;
            this.textBox_Track_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Track_Name.DefaultText = "";
            this.textBox_Track_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Track_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Track_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Track_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Track_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Track_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Track_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Track_Name.Location = new System.Drawing.Point(117, 52);
            this.textBox_Track_Name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Track_Name.Name = "textBox_Track_Name";
            this.textBox_Track_Name.PasswordChar = '\0';
            this.textBox_Track_Name.PlaceholderText = "";
            this.textBox_Track_Name.SelectedText = "";
            this.textBox_Track_Name.Size = new System.Drawing.Size(347, 43);
            this.textBox_Track_Name.TabIndex = 24;
            // 
            // textBox_Track_Genre
            // 
            this.textBox_Track_Genre.BorderRadius = 10;
            this.textBox_Track_Genre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Track_Genre.DefaultText = "";
            this.textBox_Track_Genre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Track_Genre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Track_Genre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Track_Genre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Track_Genre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Track_Genre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Track_Genre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Track_Genre.Location = new System.Drawing.Point(80, 107);
            this.textBox_Track_Genre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Track_Genre.Name = "textBox_Track_Genre";
            this.textBox_Track_Genre.PasswordChar = '\0';
            this.textBox_Track_Genre.PlaceholderText = "";
            this.textBox_Track_Genre.SelectedText = "";
            this.textBox_Track_Genre.Size = new System.Drawing.Size(384, 43);
            this.textBox_Track_Genre.TabIndex = 25;
            // 
            // textBox_Track_Album
            // 
            this.textBox_Track_Album.BorderRadius = 10;
            this.textBox_Track_Album.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Track_Album.DefaultText = "";
            this.textBox_Track_Album.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Track_Album.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Track_Album.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Track_Album.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Track_Album.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Track_Album.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Track_Album.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Track_Album.Location = new System.Drawing.Point(104, 217);
            this.textBox_Track_Album.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Track_Album.Name = "textBox_Track_Album";
            this.textBox_Track_Album.PasswordChar = '\0';
            this.textBox_Track_Album.PlaceholderText = "";
            this.textBox_Track_Album.SelectedText = "";
            this.textBox_Track_Album.Size = new System.Drawing.Size(360, 43);
            this.textBox_Track_Album.TabIndex = 26;
            // 
            // textBox_Track_Duration
            // 
            this.textBox_Track_Duration.BorderRadius = 10;
            this.textBox_Track_Duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Track_Duration.DefaultText = "";
            this.textBox_Track_Duration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Track_Duration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Track_Duration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Track_Duration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Track_Duration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Track_Duration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Track_Duration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Track_Duration.Location = new System.Drawing.Point(166, 162);
            this.textBox_Track_Duration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Track_Duration.Name = "textBox_Track_Duration";
            this.textBox_Track_Duration.PasswordChar = '\0';
            this.textBox_Track_Duration.PlaceholderText = "";
            this.textBox_Track_Duration.SelectedText = "";
            this.textBox_Track_Duration.Size = new System.Drawing.Size(298, 43);
            this.textBox_Track_Duration.TabIndex = 27;
            // 
            // label_Warning
            // 
            this.label_Warning.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Warning.ForeColor = System.Drawing.Color.Lime;
            this.label_Warning.Location = new System.Drawing.Point(12, 273);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(452, 62);
            this.label_Warning.TabIndex = 28;
            this.label_Warning.Text = "Если трек не входит в какой-либо альбом, то оставьте соответствующее поле пустым";
            // 
            // groupBox_Album_Info
            // 
            this.groupBox_Album_Info.BorderColor = System.Drawing.Color.Gray;
            this.groupBox_Album_Info.BorderRadius = 10;
            this.groupBox_Album_Info.BorderThickness = 3;
            this.groupBox_Album_Info.Controls.Add(this.textBox_Album_Name);
            this.groupBox_Album_Info.Controls.Add(this.button_AddAlbum);
            this.groupBox_Album_Info.Controls.Add(this.label_Album_Name);
            this.groupBox_Album_Info.CustomBorderColor = System.Drawing.Color.Gray;
            this.groupBox_Album_Info.FillColor = System.Drawing.Color.DimGray;
            this.groupBox_Album_Info.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Album_Info.ForeColor = System.Drawing.Color.Lime;
            this.groupBox_Album_Info.Location = new System.Drawing.Point(10, 151);
            this.groupBox_Album_Info.Name = "groupBox_Album_Info";
            this.groupBox_Album_Info.Size = new System.Drawing.Size(478, 537);
            this.groupBox_Album_Info.TabIndex = 18;
            this.groupBox_Album_Info.Text = "Добавить альбом";
            this.groupBox_Album_Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Album_Name
            // 
            this.textBox_Album_Name.BorderRadius = 10;
            this.textBox_Album_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Album_Name.DefaultText = "";
            this.textBox_Album_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Album_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Album_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Album_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Album_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Album_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Album_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Album_Name.Location = new System.Drawing.Point(117, 52);
            this.textBox_Album_Name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Album_Name.Name = "textBox_Album_Name";
            this.textBox_Album_Name.PasswordChar = '\0';
            this.textBox_Album_Name.PlaceholderText = "";
            this.textBox_Album_Name.SelectedText = "";
            this.textBox_Album_Name.Size = new System.Drawing.Size(347, 43);
            this.textBox_Album_Name.TabIndex = 24;
            // 
            // button_AddAlbum
            // 
            this.button_AddAlbum.BorderRadius = 10;
            this.button_AddAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_AddAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_AddAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_AddAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_AddAlbum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_AddAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddAlbum.ForeColor = System.Drawing.Color.Lime;
            this.button_AddAlbum.Location = new System.Drawing.Point(17, 483);
            this.button_AddAlbum.Name = "button_AddAlbum";
            this.button_AddAlbum.Size = new System.Drawing.Size(447, 45);
            this.button_AddAlbum.TabIndex = 23;
            this.button_AddAlbum.Text = "Добавить";
            this.button_AddAlbum.Click += new System.EventHandler(this.button_AddAlbum_Click);
            // 
            // label_Album_Name
            // 
            this.label_Album_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Album_Name.ForeColor = System.Drawing.Color.Lime;
            this.label_Album_Name.Location = new System.Drawing.Point(12, 59);
            this.label_Album_Name.Name = "label_Album_Name";
            this.label_Album_Name.Size = new System.Drawing.Size(110, 36);
            this.label_Album_Name.TabIndex = 7;
            this.label_Album_Name.Text = "Название: ";
            // 
            // label_Filter_Album
            // 
            this.label_Filter_Album.AutoSize = true;
            this.label_Filter_Album.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Filter_Album.ForeColor = System.Drawing.Color.Lime;
            this.label_Filter_Album.Location = new System.Drawing.Point(5, 31);
            this.label_Filter_Album.Name = "label_Filter_Album";
            this.label_Filter_Album.Size = new System.Drawing.Size(264, 28);
            this.label_Filter_Album.TabIndex = 16;
            this.label_Filter_Album.Text = "Фильтровать по названию";
            // 
            // textBox_Filter_Album
            // 
            this.textBox_Filter_Album.BorderRadius = 10;
            this.textBox_Filter_Album.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Filter_Album.DefaultText = "";
            this.textBox_Filter_Album.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Filter_Album.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Filter_Album.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Filter_Album.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Filter_Album.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Filter_Album.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Filter_Album.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Filter_Album.Location = new System.Drawing.Point(6, 76);
            this.textBox_Filter_Album.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Filter_Album.Name = "textBox_Filter_Album";
            this.textBox_Filter_Album.PasswordChar = '\0';
            this.textBox_Filter_Album.PlaceholderText = "";
            this.textBox_Filter_Album.SelectedText = "";
            this.textBox_Filter_Album.Size = new System.Drawing.Size(357, 43);
            this.textBox_Filter_Album.TabIndex = 15;
            this.textBox_Filter_Album.TextChanged += new System.EventHandler(this.textBox_Filter_Album_TextChanged);
            // 
            // dgv_Album
            // 
            this.dgv_Album.AllowUserToAddRows = false;
            this.dgv_Album.AllowUserToDeleteRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            this.dgv_Album.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgv_Album.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Album.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Album.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgv_Album.ColumnHeadersHeight = 50;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Album.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgv_Album.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Album.Location = new System.Drawing.Point(519, 22);
            this.dgv_Album.Name = "dgv_Album";
            this.dgv_Album.ReadOnly = true;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Album.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgv_Album.RowHeadersVisible = false;
            this.dgv_Album.RowHeadersWidth = 51;
            this.dgv_Album.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_Album.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_Album.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Album.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgv_Album.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dgv_Album.RowTemplate.Height = 30;
            this.dgv_Album.Size = new System.Drawing.Size(596, 666);
            this.dgv_Album.TabIndex = 14;
            this.dgv_Album.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Album.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Album.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Album.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Album.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Album.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_Album.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Album.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_Album.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Album.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_Album.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Lime;
            this.dgv_Album.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Album.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_Album.ThemeStyle.ReadOnly = true;
            this.dgv_Album.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Album.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Album.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_Album.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Album.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_Album.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Album.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // User_Form_Musician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1128, 759);
            this.Controls.Add(this.tabControl_Musician);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Form_Musician";
            this.Text = "User_Form_Musician";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Form_Musician_FormClosing);
            this.Load += new System.EventHandler(this.User_Form_Musician_Load);
            this.tabPage_AddAlbum.ResumeLayout(false);
            this.tabPage_AddAlbum.PerformLayout();
            this.tabControl_Musician.ResumeLayout(false);
            this.tabPage_AddTrack.ResumeLayout(false);
            this.tabPage_AddTrack.PerformLayout();
            this.groupBox_Music_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Music)).EndInit();
            this.groupBox_Album_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Album)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_AddAlbum;
        private Guna.UI2.WinForms.Guna2TabControl tabControl_Musician;
        private System.Windows.Forms.TabPage tabPage_AddTrack;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_Music_Info;
        private Guna.UI2.WinForms.Guna2Button button_AddTrack;
        private System.Windows.Forms.Label label_Track_Album;
        private System.Windows.Forms.Label label_Track_Duration;
        private System.Windows.Forms.Label label_Track_Genre;
        private System.Windows.Forms.Label label_Track_Name;
        private System.Windows.Forms.ComboBox comboBox_Filter_Music;
        private System.Windows.Forms.Label label_Filter_Music;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Filter_Music;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Music;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Track_Name;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Track_Duration;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Track_Album;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Track_Genre;
        private System.Windows.Forms.Label label_Warning;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox_Album_Info;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Album_Name;
        private Guna.UI2.WinForms.Guna2Button button_AddAlbum;
        private System.Windows.Forms.Label label_Album_Name;
        private System.Windows.Forms.Label label_Filter_Album;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Filter_Album;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Album;
    }
}