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
using System.Windows.Shapes;

namespace Dam.Okno
{
    /// <summary>
    /// Логика взаимодействия для Avtor.xaml
    /// </summary>
    public partial class Avtor : Window
    {
        public Avtor()
        {
            InitializeComponent();
        }

        private void BtEnterClick(object sender, RoutedEventArgs e)
        {
            if(EfModel.Init().Users.Any(p=>p.Login==TbLOgin.Text && p.Password==TbPassword.Text))
            {
                Hide();
                new MainWindow().Show();
            }
            
        }
    }
}
