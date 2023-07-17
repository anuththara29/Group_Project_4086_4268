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
using System;
using System.Windows;

namespace Registration
{
    /// <summary>
    /// Interaction logic for AddPatientWindow.xaml
    /// </summary>
    public partial class AddPatientWindow : Window
    {
       
       

        
        public Patient Patient { get; private set; }

        public AddPatientWindow() : this(null) { }

        public AddPatientWindow(Patient patient)
        {
            InitializeComponent();
            if (patient != null)
            {
                Patient = patient;
                 UserIdBox.Text = patient.Id.ToString();
                UserAddressTextBox.Text = patient.Address;
                UserNameTextBox.Text = patient.Name;
                UserAgeTextBox.Text = patient.Age.ToString();
                UserRegistered_DateTextBox.Text = patient.Registered_Date;
                UserContactNoTextBox.Text= patient.ContactNo.ToString();
                UserDiseaseTextBox.Text= patient.Disease;
            }
            else
            {
                Patient = new Patient();
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            Patient.Name = UserNameTextBox.Text;
            Patient.Address = UserAddressTextBox.Text;
            Patient.Registered_Date = DateTime.Now.ToString("yyyy-MM-dd");
            //Patient.ContactNo = 012345;
            Patient.Disease = UserDiseaseTextBox.Text;

            if (int.TryParse(UserIdBox.Text, out int id) && int.TryParse(UserAgeTextBox.Text, out int age)&&int.TryParse(UserContactNoTextBox.Text,out int contactno))
            {
                Patient.Id = id;
                Patient.Age = age;
                Patient.ContactNo = contactno;
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
