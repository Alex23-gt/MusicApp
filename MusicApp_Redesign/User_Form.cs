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
    public partial class User_Form : Form
    {
        //для смены цветов кнопок при перемещении по вкладкам
        Color activeBackcolor = Color.DimGray;//цвет фона активной кнопки
        Color activeForecolor = Color.Lime;//цвет текста активной кнопки
        Color defaultBackcolor = Properties.Settings.Default.Backcolor;//цвет фона не активной кнопки
        Color defaultForecolor = Color.White;//цвет текста не активной кнопки

        //для перемещаения формы
        bool dragging = false;//перетаскивается ли форма в данный момент
        Point dragCursorPoint;//текущая позиция курсора
        Point dragFormPoint;//текущая позиция формы

        Form activeForm = null;//форма, открываемая в основной панели

        public User_Form()
        {
            InitializeComponent();
        }

        //функция открытия формы в панели
        private void openForm(Form childForm)
        {
            if(activeForm != null) 
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(childForm);
            panel_Content.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //функция настройки цвета кнопки
        void setButtonsColors(IconButton iconButton, Color backcolor, Color forecolor)
        {
            iconButton.BackColor = backcolor;
            iconButton.ForeColor = forecolor;
            iconButton.IconColor = forecolor;
        }

        //функция закрытия приложения
        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            label_Welcome.Text = "Welcome, " + UserData.userName + "!";//текст приветствия вошедшего пользователя 
            label_Welcome.ForeColor = Properties.Settings.Default.Forecolor;
            label_Logo.ForeColor = Properties.Settings.Default.Forecolor;
            panel_Navigation.BackColor = Properties.Settings.Default.Backcolor;
            panel_Logo.BackColor = Properties.Settings.Default.Backcolor;
            panel_Menu.BackColor = Properties.Settings.Default.Backcolor;
            iconButton_Search.BackColor = Properties.Settings.Default.Backcolor;
            foreach (IconButton l in panel_Menu.Controls.OfType<IconButton>())
            {
                l.BackColor = Properties.Settings.Default.Backcolor;
            }
        }

        private void iconButton_Search_Click(object sender, EventArgs e)
        {
            //устанавливаем цвет активной кнопке и включаем боковую панель
            IconButton activeButton = (IconButton)sender;
            setButtonsColors(activeButton, activeBackcolor, activeForecolor);
            panel_Navigation_Search_Left.Visible = true;

            //устанавливаем фоновые цвета оставшимся кнопкам
            setButtonsColors(iconButton_Settings, defaultBackcolor, defaultForecolor);
            panel_Navigation_Settings_Left.Visible = false;
            setButtonsColors(iconButton_UserData, defaultBackcolor, defaultForecolor);
            panel_Navigation_User_Left.Visible = false;
            setButtonsColors(iconButton_Musician, defaultBackcolor, defaultForecolor);
            panel_Navigation_Musician_Left.Visible = false;

            //открытие формы
            openForm(new User_Form_Search());
        }

        private void iconButton_UserData_Click(object sender, EventArgs e)
        {
            //устанавливаем цвет активной кнопке и включаем боковую панель
            IconButton activeButton = (IconButton)sender;
            setButtonsColors(activeButton, activeBackcolor, activeForecolor);
            panel_Navigation_User_Left.Visible = true;

            //устанавливаем фоновые цвета оставшимся кнопкам
            setButtonsColors(iconButton_Search, defaultBackcolor, defaultForecolor);
            panel_Navigation_Search_Left.Visible = false;
            setButtonsColors(iconButton_Settings, defaultBackcolor, defaultForecolor);
            panel_Navigation_Settings_Left.Visible = false;
            setButtonsColors(iconButton_Musician, defaultBackcolor, defaultForecolor);
            panel_Navigation_Musician_Left.Visible = false;

            //открытие формы
            openForm(new User_Form_PersonalData());
        }

        private void iconButton_Settings_Click(object sender, EventArgs e)
        {
            //устанавливаем цвет активной кнопке и включаем боковую панель
            IconButton activeButton = (IconButton)sender;
            setButtonsColors(activeButton, activeBackcolor, activeForecolor);
            panel_Navigation_Settings_Left.Visible = true;

            //устанавливаем фоновые цвета оставшимся кнопкам
            setButtonsColors(iconButton_UserData, defaultBackcolor, defaultForecolor);
            panel_Navigation_User_Left.Visible = false;
            setButtonsColors(iconButton_Search, defaultBackcolor, defaultForecolor);
            panel_Navigation_Search_Left.Visible = false;
            setButtonsColors(iconButton_Musician, defaultBackcolor, defaultForecolor);
            panel_Navigation_Musician_Left.Visible = false;

            //открытие формы
            openForm(new User_Form_Settings());
        }

        //функция выхода на окно регистрации
        private void iconButton_Exit_Click(object sender, EventArgs e)
        {
            Login_Form Obj = new Login_Form();
            Obj.Show();
            this.Hide();
        }

        //функция скрытия формы
        private void iconButton_Minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//сворачиваем форму
        }

        //функция раскрытия и возвращения формы в нормальное состояние
        private void iconButton_Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)//если форма раскрыта на весь экран
            {
                this.WindowState = FormWindowState.Normal;//возращаем в нормальное состояние
                this.StartPosition = FormStartPosition.CenterScreen;//размещаем по центру экрана
            }
            else//иначе
            {
                this.WindowState = FormWindowState.Maximized;//раскрываем форму на весь экран
            }
        }

        //начало перетачкивания формы
        private void panel_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;//форма перетаскивается
            dragCursorPoint = Cursor.Position;//позиция курсора
            dragFormPoint = this.Location;//позиция формы
        }

        //конец перетаскивания формы
        private void panel_Menu_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;//форма не перетаскивается
        }

        //перемещение курсора
        private void panel_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)//если форма перетаскивается
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));//разница между стартовой позицией курсора и текущей
                this.Location = Point.Add(dragFormPoint, new Size(dif));//перемещение формы на вычисленную разницу
            }
        }

        private void iconButton_Musician_Click(object sender, EventArgs e)
        {
            switch (UserData.isAdmin)
            {
                case ("Подписчик"):
                    { //устанавливаем цвет активной кнопке и включаем боковую панель
                        IconButton activeButton = (IconButton)sender;
                        setButtonsColors(activeButton, activeBackcolor, activeForecolor);
                        panel_Navigation_Musician_Left.Visible = true;

                        //устанавливаем фоновые цвета оставшимся кнопкам
                        setButtonsColors(iconButton_UserData, defaultBackcolor, defaultForecolor);
                        panel_Navigation_User_Left.Visible = false;
                        setButtonsColors(iconButton_Search, defaultBackcolor, defaultForecolor);
                        panel_Navigation_Search_Left.Visible = false;
                        setButtonsColors(iconButton_Settings, defaultBackcolor, defaultForecolor);
                        panel_Navigation_Settings_Left.Visible = false;

                        //открытие формы
                        openForm(new User_Form_Musician());
                        break;
                    }
                case ("Обычный"):
                    {
                        MessageBox.Show("У Вас отсутствует подписка. Приобретите ее в личном кабинете", "Уведомление");
                        break;
                    }
            }
        }
    }
}
