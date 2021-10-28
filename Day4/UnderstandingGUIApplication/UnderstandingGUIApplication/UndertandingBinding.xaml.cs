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
using CompanyLibrary;

namespace UnderstandingGUIApplication
{
    /// <summary>
    /// Interaction logic for UndertandingBinding.xaml
    /// </summary>
    public partial class UndertandingBinding : Window
    {
        Employee employee = new Employee() {
            Id=101,
            Name="Tim",
            Age=21
        };
        public UndertandingBinding()
        {
            InitializeComponent();
            this.DataContext = employee;
            comboBox.Items.Add("Hello");
            comboBox.Items.Add("Hi");
            comboBox.Items.Add("Welcome");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = employee;
        }
    }
}
