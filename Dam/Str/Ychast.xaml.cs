using Dam.Database;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dam.Str
{
    /// <summary>
    /// Логика взаимодействия для Ychast.xaml
    /// </summary>
    public partial class Ychast : Page
    {
        private void UpdateData()
        {
            dgvYchast.ItemsSource = EfModel.Init().Ychastnikis.ToList();
        }
        public Ychast()
        {
            InitializeComponent();
            UpdateData();
        }
    }
}
