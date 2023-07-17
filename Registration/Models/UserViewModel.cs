using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Input;

namespace Registration.Models
{
    public class UserViewModel : ObservableObject
    {
        private ObservableCollection<Patient> _patients = new ObservableCollection<Patient>();

        public ObservableCollection<Patient> Patients
        {
            get => _patients;
            set => SetProperty(ref _patients, value);
        }

        public UserViewModel()
        {
            LoadPatients();
            LoadDoctors();
        }

        private void LoadPatients()
        {
            using (var context = new DataBaseContext())
            {
                Patients.Clear();
                foreach (var product in context.Patients)
                {
                    Patients.Add(product);
                }
            }
        }
        private ObservableCollection<Doctor> _doctors= new ObservableCollection<Doctor>();
        public ObservableCollection<Doctor> Doctors
        {
            get => _doctors;
            set=> SetProperty(ref _doctors, value);

        }
        
        private void LoadDoctors()
        {
            using(var context = new DataBaseContext())
            {
                Doctors.Clear();
                foreach(var product in context.Doctors)
                {
                    Doctors.Add(product);
                }
            }
        }
    }
}
