using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for StudentList.xaml
    /// </summary>
    /// 
   

    public partial class StudentList : Window
    {

        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        private ObservableCollection<String> students_to_show = new ObservableCollection<String>();



        public StudentList()
        {
            InitializeComponent();


            students.Add(new Student() { Name = "Nick Ilkic", Id = 1 });
            students.Add(new Student() { Name = "John Dow1", Id = 2 });
            students.Add(new Student() { Name = "John Dow2", Id = 3 });
            students.Add(new Student() { Name = "John Dow3", Id = 4 });
            students.Add(new Student() { Name = "John Dow4", Id = 5 });

            lstStd.ItemsSource = students_to_show;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            foreach(Student s in students)
            {
                if (s.Id == Int32.Parse(txtStdId.Text))
                {
                    students_to_show.Add(s.Name);
                }
                else 
                {
                    MessageBox.Show("User not in list");
                }

            }
        }
    }



}
