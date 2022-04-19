using System.Linq;
using System.Windows;
using Library.Resources.DataFolder;


namespace Library.Windows
{
    /// <summary>
    /// Логика взаимодействия для WinAuth.xaml
    /// </summary>
    public partial class WinAuth : Window
    {
        public WinAuth()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e) //Кнопка выхода
        {
            MessageBoxResult Result = MessageBox.Show("Вы действительно хотите выйти?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)//Кнопка входа
        {
            {
                {
                    {
                        if (string.IsNullOrEmpty(TbLogin.Text))
                        {
                            Classes.ClassMB.ErrorMB("Вы не ввели логин!");
                            TbLogin.Focus();
                        }
                        else if (string.IsNullOrEmpty(PbPassword.Password))
                        {
                            Classes.ClassMB.ErrorMB("Вы не ввели пароль!");
                            PbPassword.Focus();
                        }
                        else
                        {
                            var user = DBEntities.GetContext().Users
                                                 .FirstOrDefault(u => u.UserName == TbLogin.Text);
                            if (user == null)
                            {
                                Classes.ClassMB.ErrorMB("Введен неправльный логин!");
                                TbLogin.Focus();
                            }
                            if (user.Password != PbPassword.Password)
                            {
                                Classes.ClassMB.ErrorMB("Введен неправльный пароль!");
                                PbPassword.Focus();
                            }
                            else
                            {
                                switch (user.IdRole)
                                {
                                    case 1:
                                        MessageBox.Show("Вы вошли как Пользователь");
                                        Windows.ClientMenu clientMenu = new Windows.ClientMenu();
                                        this.Close();
                                        clientMenu.ShowDialog();
                                        break;
                                    case 2:
                                        MessageBox.Show("Вы вошли как Администратор");
                                        Windows.AdminMenu adminMenu = new Windows.AdminMenu();
                                        this.Close();
                                        adminMenu.ShowDialog();
                                        break;
                                    case 3:
                                        MessageBox.Show("Вы вошли как Менеджер");
                                        Windows.ManagerMenu managerMenu = new Windows.ManagerMenu();
                                        this.Close();
                                        managerMenu.ShowDialog();
                                        break;
                                    case 4:
                                        MessageBox.Show("Вы вошли как Кладовщик");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

