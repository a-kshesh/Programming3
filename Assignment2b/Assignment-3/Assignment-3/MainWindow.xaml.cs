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

namespace Assignment_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double savingAmount=0;
        double chequingAmount=0;
        
        public void balanceExceed()
        {
            MessageBox.Show("Not Enough Balance");
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Do you want to Continue with transaction ?","" , MessageBoxButton.OKCancel,MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.OK)
                {
                    if (saving.IsChecked == true && withdraw.IsChecked == true && savingAmount>= Convert.ToDouble(amountInput.Text))
                    {

                        savingAmount = savingAmount - Convert.ToDouble(amountInput.Text);
                        MessageBox.Show($"Your Amount {amountInput.Text} has been withdrawn succesfully");
                        balance.Content = "Saving Balance "+savingAmount.ToString();
                    }

                    else if (saving.IsChecked == true && Deposit.IsChecked == true )
                    {
                        savingAmount = savingAmount + Convert.ToDouble(amountInput.Text);
                        MessageBox.Show($"Your Amount {amountInput.Text} has been Deposited succesfully");
                        balance.Content = "Saving Balance " + savingAmount.ToString();
                    }

                    else if (chequing.IsChecked == true && withdraw.IsChecked == true && chequingAmount >= Convert.ToDouble(amountInput.Text))
                    {
                        chequingAmount = chequingAmount - Convert.ToDouble(amountInput.Text);
                        MessageBox.Show($"Your Amount {amountInput.Text} has been withdrawn succesfully");
                        balance.Content = "Chequing Balance " + chequingAmount.ToString();
                    }

                    else if (chequing.IsChecked == true && Deposit.IsChecked == true)
                    {
                        chequingAmount = chequingAmount + Convert.ToDouble(amountInput.Text);
                        MessageBox.Show($"Your Amount {amountInput.Text} has been Deposited succesfully");
                        balance.Content = "Chequing Balance " + chequingAmount.ToString();
                    }

                    else
                    {
                        MessageBox.Show("this operation cannot be done"," ", MessageBoxButton.OK,MessageBoxImage.Error);
                        balance.Content = "Chequing Balance " + chequingAmount.ToString()+'\n'+ "Saving Balance " + savingAmount.ToString();
                    }
                }
                else if(messageBoxResult==MessageBoxResult.Cancel)
                {
                    MessageBox.Show("this operation has been canceled succesfully");
                    balance.Content = chequingAmount.ToString();
                }
            }
            catch
            {
                MessageBox.Show("please Enter valid value", " ", MessageBoxButton.OK, MessageBoxImage.Error);
                balance.Content = chequingAmount.ToString();
            }
        }
    }
}
