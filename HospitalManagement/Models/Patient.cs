﻿using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Patient
    {
        [Key]
        public int HSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public string Phone { get; set; }

        //DoctorId
        public User User { get; set; }
        public string UserUsername { get; set; } // where userLevel == doctors
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Appointment> Appointments { get; set; }


    }
}
