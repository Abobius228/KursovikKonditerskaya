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
    /// Логика взаимодействия для ManagerMenu.xaml
    /// </summary>
    public partial class ManagerMenu : Window
    {
        public ManagerMenu()
        {
            InitializeComponent();
            ManagerDataGrid.ItemsSource = DBEntities.GetContext().Clients.ToList();//ПОЛУЧЕНИЕ СПИСКА КЛИЕНТОВ ИЗ БАЗЫ ДАННЫХ
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
