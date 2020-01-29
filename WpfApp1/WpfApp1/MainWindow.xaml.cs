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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbxFirstName.Text = String.Empty;
            tbxLastName.Text = String.Empty;
            tbxAddress.Text = String.Empty;
            tbxZipCode.Text = String.Empty;

            

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String firstName, lastName, address, zipCode;

            

            firstName = tbxFirstName.Text;
            lastName = tbxLastName.Text;
            address = tbxAddress.Text;
            zipCode = tbxZipCode.Text;

            String name = firstName + " " + lastName;
            EntryForm myEntryForm = new EntryForm();

            ListBox listBox = new ListBox();

           //ListBox.


           

            //String message = $"{firstName} + {lastName} + {address} + {zipCode}";
            //MessageBox.Show(message);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    
}
