using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Library.Classes
{
	class ClassDG
	{
        SqlDataAdapter sqlDataAdapter;
        DataGrid dataGrid;
        DataTable dataTable;
        public ClassDG(DataGrid dataGrid)
        {
            this.dataGrid = dataGrid;
        }
        public string SelectId()
        {
            object[] mass = null;
            string id = "";
            try
            {
                if (dataGrid != null)
                {
                    DataRowView dataRowView = dataGrid.SelectedItem as DataRowView;
                    if (dataRowView != null)
                    {
                        DataRow dataRow = (DataRow)dataRowView.Row;
                        mass = dataRow.ItemArray;
                    }
                }
                id = mass[0].ToString();
            }
            catch
            {
                MessageBox.Show("Вы не выбрали строку.", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return id;
        }

        public void LoadDB(string sqlCommand)
        {
            try
            {

            }
            catch (Exception ex)
            {
                ClassMB.ErrorMB(ex);
            }
            finally
            {
            }
        }
    }
}
