using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel.DataAnnotations;

namespace Library.Classes
{
    class ClassDG
    {
        public string NameCake { get; set; }

        public int IdCake { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }
    }
}

