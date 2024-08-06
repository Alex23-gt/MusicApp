using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp_Redesign
{
    public partial class User_Form_Settings : Form
    {
        public User_Form_Settings()
        {
            InitializeComponent();
        }

        private void button_ChangeBackcolor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = this.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                panel_MenuTest.BackColor = cd.Color;
                panel_LogoTest.BackColor = cd.Color;
                foreach(IconButton l in panel_MenuTest.Controls.OfType<IconButton>())
                {
                    l.BackColor = cd.Color;
                }
            }
        }

        private void button_ChangeForecolor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = this.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                label_LogoTest.ForeColor = cd.Color;
                label_WelcomeTest.ForeColor = cd.Color;
            }
        }

        private void button_SaveColors_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Backcolor = panel_MenuTest.BackColor;
            Properties.Settings.Default.Forecolor = label_LogoTest.ForeColor;
            Properties.Settings.Default.Save();

            MessageBox.Show("Настройки сохранены. Перезайдите в приложения для их активации", "Уведомление");
        }

        private void button_RefreshColors_Click(object sender, EventArgs e)
        {
            panel_MenuTest.BackColor = Properties.Settings.Default.Backcolor;
            panel_LogoTest.BackColor = Properties.Settings.Default.Backcolor;
            foreach (IconButton l in panel_MenuTest.Controls.OfType<IconButton>())
            {
                l.BackColor = Properties.Settings.Default.Backcolor;
            }
            label_LogoTest.ForeColor = Properties.Settings.Default.Forecolor;
            label_WelcomeTest.ForeColor = Properties.Settings.Default.Forecolor;
        }
    }
}
