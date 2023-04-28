using System.Windows;
using CAN.Task4SQLite.View;
using CAN.Task4SQLite.Model;
using System;
using System.Linq;
using System.Windows.Controls;

namespace CAN.Task4SQLite.View.UserControls
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userName = TbLogin.Text;
                var uID = PbUid.Password;

                using (UserDataContext db = new UserDataContext())
                {
                    bool userFound = db.Users.Any(u => u.Login == userName && u.UID == uID);

                    if (userFound)
                    {
                        MessageBox.Show("Успешная авторизация",
                                        "Системное сообщение",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка данных",
                                        "Системное сообщение",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }
    }
    
}