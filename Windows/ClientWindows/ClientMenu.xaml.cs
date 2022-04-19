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
    /// Логика взаимодействия для ClientMM.xaml
    /// </summary>
    public partial class ClientMenu : Window
    {
        public ClientMenu()
        {
            InitializeComponent();
            ClientCatalogDataGrid.ItemsSource = DBEntities.GetContext().Cakes.ToList();//ПОЛУЧЕНИЕ СПИСКА ТОРТОВ ИЗ БАЗЫ ДАННЫХ
        }

        private void ClientCatalogDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ClientZakazEchpochmak_Click(object sender, RoutedEventArgs e)//КНОПКА ДОБАВЛЕНИЯ ЗАКАЗА
        {
            ZakazWindow zakazWindow = new ZakazWindow();
            zakazWindow.ShowDialog();
        }

        private void ClientExit_Click(object sender, RoutedEventArgs e)//КНОПКА ВЫХОДА ИЗ ОКНА ПОЛЬЗОВАТЕЛЯ
        {
            WinAuth winAuth = new WinAuth();
            this.Close();
            winAuth.ShowDialog();
        }
    }
}
