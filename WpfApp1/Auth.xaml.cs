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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            User aut = null;
            string login1 = Login.Text;
            string pass1 = Pass.Password;


            using(AppContxtOrRepository us = new AppContxtOrRepository())
            {
                 aut= us.Users.Where(b => b.login == login1).FirstOrDefault();
            }
            if(aut != null)
            {
                MessageBox.Show("Ok");
            }
            else
            {
                MessageBox.Show("Not Ok");
            }
        }
    }
}
