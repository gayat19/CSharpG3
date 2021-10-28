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

namespace UnderstandingGUIApplication
{
    /// <summary>
    /// Interaction logic for Second.xaml
    /// </summary>
    public partial class Second : Window
    {
        public Second()
        {
            InitializeComponent();
        }

        private void RdbMale_Checked(object sender, RoutedEventArgs e)
        {
            cmbData.Items.Add("Male clicked");
        }

        private void RdbFemale_Checked(object sender, RoutedEventArgs e)
        {
            cmbData.Items.Add("Female clicked");
        }
    }
}
