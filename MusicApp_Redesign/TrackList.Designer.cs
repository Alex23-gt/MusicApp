namespace MusicApp_Redesign
{
    partial class TrackList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dgv_TrackList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.iconButton_Close = new FontAwesome.Sharp.IconButton();
            this.button_Listen = new Guna.UI2.WinForms.Guna2Button();
            this.button_RatingPrediction = new Guna.UI2.WinForms.Guna2Button();
            this.button_MakeRating = new Guna.UI2.WinForms.Guna2Button();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrackList)).BeginInit();
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
            // dgv_TrackList
            // 
            this.dgv_TrackList.AllowUserToAddRows = false;
            this.dgv_TrackList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgv_TrackList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_TrackList.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_TrackList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TrackList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_TrackList.ColumnHeadersHeight = 50;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TrackList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_TrackList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TrackList.Location = new System.Drawing.Point(12, 57);
            this.dgv_TrackList.Name = "dgv_TrackList";
            this.dgv_TrackList.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TrackList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_TrackList.RowHeadersVisible = false;
            this.dgv_TrackList.RowHeadersWidth = 51;
            this.dgv_TrackList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_TrackList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_TrackList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_TrackList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgv_TrackList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dgv_TrackList.RowTemplate.Height = 30;
            this.dgv_TrackList.Size = new System.Drawing.Size(1170, 431);
            this.dgv_TrackList.TabIndex = 3;
            this.dgv_TrackList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TrackList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TrackList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TrackList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TrackList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TrackList.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_TrackList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TrackList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.dgv_TrackList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_TrackList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_TrackList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Lime;
            this.dgv_TrackList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TrackList.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_TrackList.ThemeStyle.ReadOnly = true;
            this.dgv_TrackList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TrackList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_TrackList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_TrackList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TrackList.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_TrackList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TrackList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TrackList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TrackList_CellClick);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Menu.Controls.Add(this.label_Welcome);
            this.panel_Menu.Controls.Add(this.iconButton_Close);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1194, 51);
            this.panel_Menu.TabIndex = 4;
            this.panel_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseDown);
            this.panel_Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseMove);
            this.panel_Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseUp);
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Welcome.ForeColor = System.Drawing.Color.Lime;
            this.label_Welcome.Location = new System.Drawing.Point(12, 9);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(0, 28);
            this.label_Welcome.TabIndex = 6;
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
            this.iconButton_Close.Location = new System.Drawing.Point(1143, 8);
            this.iconButton_Close.Name = "iconButton_Close";
            this.iconButton_Close.Size = new System.Drawing.Size(39, 38);
            this.iconButton_Close.TabIndex = 4;
            this.iconButton_Close.TabStop = false;
            this.iconButton_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton_Close.UseVisualStyleBackColor = false;
            this.iconButton_Close.Click += new System.EventHandler(this.iconButton_Close_Click);
            // 
            // button_Listen
            // 
            this.button_Listen.BorderRadius = 10;
            this.button_Listen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Listen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Listen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Listen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Listen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Listen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Listen.ForeColor = System.Drawing.Color.Lime;
            this.button_Listen.Location = new System.Drawing.Point(12, 507);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(585, 45);
            this.button_Listen.TabIndex = 28;
            this.button_Listen.Text = "Слушать";
            this.button_Listen.Visible = false;
            this.button_Listen.Click += new System.EventHandler(this.button_Listen_Click);
            // 
            // button_RatingPrediction
            // 
            this.button_RatingPrediction.BorderRadius = 10;
            this.button_RatingPrediction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_RatingPrediction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_RatingPrediction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_RatingPrediction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_RatingPrediction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_RatingPrediction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RatingPrediction.ForeColor = System.Drawing.Color.Lime;
            this.button_RatingPrediction.Location = new System.Drawing.Point(603, 558);
            this.button_RatingPrediction.Name = "button_RatingPrediction";
            this.button_RatingPrediction.Size = new System.Drawing.Size(579, 45);
            this.button_RatingPrediction.TabIndex = 27;
            this.button_RatingPrediction.Text = "Понравиться ли Вам";
            this.button_RatingPrediction.Visible = false;
            // 
            // button_MakeRating
            // 
            this.button_MakeRating.BorderRadius = 10;
            this.button_MakeRating.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_MakeRating.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_MakeRating.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_MakeRating.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_MakeRating.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_MakeRating.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MakeRating.ForeColor = System.Drawing.Color.Lime;
            this.button_MakeRating.Location = new System.Drawing.Point(603, 507);
            this.button_MakeRating.Name = "button_MakeRating";
            this.button_MakeRating.Size = new System.Drawing.Size(579, 45);
            this.button_MakeRating.TabIndex = 26;
            this.button_MakeRating.Text = "Поставить оценку";
            this.button_MakeRating.Visible = false;
            // 
            // button_Add
            // 
            this.button_Add.BorderRadius = 10;
            this.button_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.ForeColor = System.Drawing.Color.Lime;
            this.button_Add.Location = new System.Drawing.Point(12, 558);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(585, 45);
            this.button_Add.TabIndex = 25;
            this.button_Add.Text = "Добавить к себе";
            this.button_Add.Visible = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // TrackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1194, 627);
            this.Controls.Add(this.button_Listen);
            this.Controls.Add(this.button_RatingPrediction);
            this.Controls.Add(this.button_MakeRating);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.dgv_TrackList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrackList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrackList_FormClosing);
            this.Load += new System.EventHandler(this.TrackList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrackList)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_TrackList;
        private System.Windows.Forms.Panel panel_Menu;
        private FontAwesome.Sharp.IconButton iconButton_Close;
        private System.Windows.Forms.Label label_Welcome;
        private Guna.UI2.WinForms.Guna2Button button_Listen;
        private Guna.UI2.WinForms.Guna2Button button_RatingPrediction;
        private Guna.UI2.WinForms.Guna2Button button_MakeRating;
        private Guna.UI2.WinForms.Guna2Button button_Add;
    }
}