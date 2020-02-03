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
            //Name.Text = String.Empty;
            

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String firstName, lastName, address, zipCode;

            listForm.Items.clear();
            //Name = txtName.Text
            firstName = tbxFirstName.Text;
            lastName = tbxLastName.Text;
            address = tbxAddress.Text;
            zipCode = tbxZipCode.Text;
            int zippy; //equivalent to doing Console.ReadLine();

            if(string.IsNullOrWhiteSpace(address) == true)
            {
                MessageBox.Show("you must enter an address");
            }

            bool isInt = Int32.TryParse(zipCode, out zippy);

            if(isInt == false)
            {
                MessageBox.Show("Must enter an integer value for zipCode");
            }

            /*
            EntryForm ef = new EntryForm();
            ef.Address = address;
            ef.
            String name = firstName + " " + lastName;
            EntryForm myEntryForm = new EntryForm();
            */

            //EntryForm ef = new EntryForm(name, address, zipCode);

            ListBox listform = new ListBox();
            listForm.Items.Add(ef);
           

            //String message = $"{firstName} + {lastName} + {address} + {zipCode}";
            //MessageBox.Show(message);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    
}
