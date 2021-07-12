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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Info> infos = new List<Info> { };
        public MainWindow()
        {
            InitializeComponent();
            infos.Add(new Info("Akshesh", "Toronto", "Reading"));
            infos.Add(new Info("Ashish", "Toronto", "Cricket"));
            infos.Add(new Info("Shruthi", "Toronto", "Pool"));
            dg1.ItemsSource = infos;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text.Length >= 1 && tbAddress.Text.Length >= 1 && tbHobby.Text.Length >= 1)
            {
                dg1.ItemsSource = null;
                infos.Add(new Info(tbName.Text, tbAddress.Text, tbHobby.Text));
                dg1.ItemsSource = infos;
            }
            else
            {
                MessageBox.Show("Please Enter Some Values");
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (dg1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select any row first");
            }
            else
            {

                infos.RemoveAt(dg1.SelectedIndex);
                dg1.ItemsSource = null;
                dg1.ItemsSource = infos;
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dg1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select any row first");
            }
            else
            {
                infos.ElementAt(dg1.SelectedIndex).Name = tbName.Text;
                infos.ElementAt(dg1.SelectedIndex).Address = tbAddress.Text;
                infos.ElementAt(dg1.SelectedIndex).Hobby = tbHobby.Text;
              
               // infos.Add(new Info(infos.ElementAt(dg1.SelectedIndex).Name, infos.ElementAt(dg1.SelectedIndex).Address, infos.ElementAt(dg1.SelectedIndex).Hobby));
                infos.RemoveAt(dg1.SelectedIndex);
                infos.Add(new Info(tbName.Text, tbAddress.Text, tbHobby.Text));
            }

           

        }

       
    }
}
