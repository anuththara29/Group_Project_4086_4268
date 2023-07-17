using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Registration.Models
{
    public class AdminMainWindowViewModel : ObservableObject
    {
        private ObservableCollection<Patient> _patients;
        private ObservableCollection<Doctor> _doctors;
        //public Patient selectedPatient = null;
        private Patient _selectedPatient;
        private Doctor _selectedDoctor;
        public Patient SelectedPatient
        {
            get => _selectedPatient;
            set => SetProperty(ref _selectedPatient, value);
        }
        public Doctor SelectedDoctor
        {
            get=> _selectedDoctor;
            set=> SetProperty(ref _selectedDoctor, value);
        }
        public ObservableCollection<Patient> Patients
        {
            get => _patients;
            set => SetProperty(ref _patients, value);
        }
        public ObservableCollection<Doctor> Doctors
        {
            get=> _doctors;
            set=> SetProperty(ref _doctors, value);
        }
        public ICommand LoadPatientsCommand { get; }
        public ICommand AddPatientCommand { get; }
        public ICommand LoadDoctorsCommand { get; }
        public ICommand AddDoctorCommand { get; }
        public ICommand DeletePatientCommand { get; }
        public ICommand DeleteDoctorCommand { get; }
        public ICommand EditPatientCommand { get; }
        public ICommand EditDoctorCommand { get; }

        public AdminMainWindowViewModel()
        {
            //Users = new ObservableCollection<User>();
            Patients = new ObservableCollection<Patient>();
            LoadPatientsCommand = new RelayCommand(LoadPatients);
            AddPatientCommand = new RelayCommand(AddPatient);
            DeletePatientCommand = new RelayCommand(DeletePatient);
            EditPatientCommand = new RelayCommand(EditPatient);

            Doctors=new ObservableCollection<Doctor>();
            LoadDoctorsCommand = new RelayCommand(LoadDoctors);
            AddDoctorCommand = new RelayCommand(AddDoctor);
            DeleteDoctorCommand = new RelayCommand(DeleteDoctor);
            EditDoctorCommand = new RelayCommand(EditDoctor);


            LoadPatients();
            LoadDoctors();
        }

        private void LoadPatients()
        {
            using (var context = new DataBaseContext())
            {
                Patients.Clear();
                foreach (var patient in context.Patients)
                {
                    Patients.Add(patient);
                }
            }
        }
        private void AddPatient()
        {
            var patientWindow = new AddPatientWindow();
            if (patientWindow.ShowDialog() == true)
            {
                var newPatient = patientWindow.Patient;
                using (var context = new DataBaseContext())
                {
                    context.Patients.Add(newPatient);
                    context.SaveChanges();
                }
                Patients.Add(newPatient);
            }
        }
        
        private void DeletePatient()
        {
            if (SelectedPatient != null)
            {
                using (var context = new DataBaseContext())
                {
                    context.Patients.Remove(SelectedPatient);
                    context.SaveChanges();
                }
                Patients.Remove(SelectedPatient); 
            }
        }
        private void EditPatient()
        {
            if (SelectedPatient != null)
            {
                using (var context = new DataBaseContext())
                {
                    var patient = context.Patients.Find(SelectedPatient.Id);
                    if (patient != null)
                    {
                        var patientWindow = new EditPatientWindow(patient);
                        if(patientWindow.ShowDialog() == true)
                        {
                            patient.Id = patientWindow.Patient.Id;
                            patient.Name=patientWindow.Patient.Name;
                            patient.Address=patientWindow.Patient.Address;
                            patient.Age=patientWindow.Patient.Age;
                            patient.Registered_Date = patientWindow.Patient.Registered_Date;
                            patient.ContactNo = patientWindow.Patient.ContactNo;
                            patient.Disease=patientWindow.Patient.Disease;
                            context.SaveChanges() ;
                            LoadPatients();
                        }
                    }
                }
                //Patients.Remove(SelectedPatient);
            }
           

        }
       
        private void LoadDoctors()
        {
            using (var context = new DataBaseContext())
            {
                Doctors.Clear();
                foreach (var doctor in context.Doctors)
                {
                    Doctors.Add(doctor);
                }
            }
        }
        private void AddDoctor()
        {
            var doctorWindow = new AddDoctorWindow();
            if (doctorWindow.ShowDialog() == true)
            {
                var newDoctor = doctorWindow.Doctor;
                using (var context = new DataBaseContext())
                {
                    context.Doctors.Add(newDoctor);
                    context.SaveChanges();
                }
                // Add the new admin to the Admins collection
                Doctors.Add(newDoctor);
            }
        }
        private void DeleteDoctor()
        {
            if (SelectedDoctor != null)
            {
                using (var context = new DataBaseContext())
                {
                    context.Doctors.Remove(SelectedDoctor);
                    context.SaveChanges();
                }
                Doctors.Remove(SelectedDoctor);
            }
        }
        private void EditDoctor()
        {
            if (SelectedDoctor != null)
            {
                using (var context = new DataBaseContext())
                {
                    var doctor = context.Doctors.Find(SelectedDoctor.Id);
                    if (doctor != null)
                    {
                        var doctorWindow = new EditDoctorWindow(doctor);
                        if (doctorWindow.ShowDialog() == true)
                        {
                            doctor.Id = doctorWindow.Doctor.Id;
                            doctor.Name = doctorWindow.Doctor.Name;
                            
                            doctor.ContactNo = doctorWindow.Doctor.ContactNo;
                            
                            LoadPatients();
                        }
                    }
                }
                
            }


        }

    }
}
