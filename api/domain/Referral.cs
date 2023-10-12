﻿namespace Domain
{
    public class Referral
    {
        public int Id { get; set; }
        public string GPName { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DOB { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public bool PatientExists { get; set; }
    }
}