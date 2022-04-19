﻿using System;
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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
            AdminUserDataGrid.ItemsSource = DBEntities.GetContext().Users.ToList();//ПОЛУЧЕНИЕ СПИСКА КЛИЕНТОВ ИЗ БАЗЫ ДАННЫХ
        }

        private void BtnAdminEdit_Click(object sender, RoutedEventArgs e)
        {
            Windows.AdminEditWindow adminEditWindow = new Windows.AdminEditWindow();
            adminEditWindow.ShowDialog();
        }

        private void AdminExit_Click(object sender, RoutedEventArgs e)
        {
            WinAuth winAuth = new WinAuth();
            this.Close();
            winAuth.ShowDialog();
        }
    }
}
