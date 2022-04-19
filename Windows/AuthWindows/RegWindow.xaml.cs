using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Library.Resources.DataFolder;

namespace Library.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void RegWindowExit_Click(object sender, RoutedEventArgs e)
        {
            WinAuth winAuth = new WinAuth();
            this.Close();
            winAuth.ShowDialog();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            DBEntities.GetContext().Users.Add(new Users()
            {
                UserName = LoginUser.Text,
                Password = PasswordUser.Password,
                IdRole = 1,
            });
            DBEntities.GetContext().SaveChanges();
            Classes.ClassMB.InformationMB("Вы успешно зарегестрированы!");
            WinAuth winAuth = new WinAuth();
            this.Close();
            winAuth.ShowDialog();
        }
    }
}
