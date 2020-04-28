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

    public partial class TreeViewForm : Window
    {
        bool isRed = false;
        TreeViewItem treeViewItem = new TreeViewItem();

        public TreeViewForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isRed)
            {
                btnClick.Background = Brushes.Red;
                isRed = false;
                int textEven = Int32.Parse(txtEven.Text);
                textEven += 1;
                txtEven.Text = textEven.ToString();

            }
            else
            {
                btnClick.Background = Brushes.Blue;
                isRed = true;
                int textOdd = Int32.Parse(txtOdd.Text);
                textOdd += 1;
                txtOdd.Text = textOdd.ToString();
            }

            

        }
    }
}
