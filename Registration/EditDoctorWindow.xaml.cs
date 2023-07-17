using Registration.Models;
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

namespace Registration
{
    /// <summary>
    /// Interaction logic for EditDoctorWindow.xaml
    /// </summary>
    public partial class EditDoctorWindow : Window
    {
        public Doctor Doctor { get; private set; }
        public EditDoctorWindow() : this(null) { }
        public EditDoctorWindow(Doctor doctor)
        {
            InitializeComponent();
            if (doctor != null)
            {
                Doctor = doctor;
                AdminIdBox.Text = doctor.Id.ToString();
                AdminNameTextBox.Text = doctor.Name;
                AdminContactNoTextBox.Text = doctor.ContactNo.ToString();
            }
            else
            {
                Doctor=new Doctor();
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            Doctor.Name = AdminNameTextBox.Text;
            //Doctor.ContactNo = 012345;




            if (int.TryParse(AdminIdBox.Text, out int id) && int.TryParse(AdminContactNoTextBox.Text, out int contactno))
            {
                Doctor.Id = id;
                Doctor.ContactNo = contactno;

            }
            else
            {
                MessageBox.Show("Invalid id or age. Please enter valid values.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DialogResult = true;
            Close();
        }
    }
}
