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
    /// Логика взаимодействия для ZakazWindow.xaml
    /// </summary>
    public partial class ZakazWindow : Window
    {
        public ZakazWindow()
        {
            InitializeComponent();
        }

        private void ZakazWindowExit_Click(object sender, RoutedEventArgs e)//КНОПКА ЗАКРЫТИЯ ОКНАОФОРМЛЕНИЯ ЗАКАЗА
        {
            this.Close();
        }

        private void ZakazWindowOformlenie_Click(object sender, RoutedEventArgs e)
        {
            {
                DBEntities.GetContext().Clients.Add(new Clients());
                    DBEntities.GetContext().SaveChanges();
                Classes.ClassMB.InformationMB("Заказ оформлен!");
            }
        }
    }
}
