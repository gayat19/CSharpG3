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
using CompanyLibrary;

namespace UnderstandingGUIApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lstEID.ItemsSource = employees.Keys.ToList();
        }

        Dictionary<int, Employee> employees = new Dictionary<int, Employee>() {
            {101,new Employee(){ Id=101,Name="Jim",Age=22} },
            {102,new Employee(){ Id=102,Name="Lim",Age=23} }
        };

        private void BtnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (txtEID.Text == "")
            {
                MessageBox.Show("Employee Id cannot be empty");
                return;
            }
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(txtEID.Text);
            employee.Name = txtEName.Text;
            employee.Age = Convert.ToInt32(txtEAge.Text);
            //MessageBox.Show(employee.ToString());
            employees.Add(employee.Id,employee);
            MessageBox.Show("employee added");
            lstEID.ItemsSource = employees.Keys.ToList();
        }

        private void LstEID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int id = Convert.ToInt32(lstEID.SelectedItem);
            lblEmployeeDisplay.Content = employees[id];
        }

        private void BtnAnother_Click(object sender, RoutedEventArgs e)
        {
            Second frmSecon = new Second();
            frmSecon.Show();
            this.Hide();
        }
    }
}
