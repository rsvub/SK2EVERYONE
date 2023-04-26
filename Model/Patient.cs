﻿namespace SK2EVERYONE.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthNumber{ get; set; }
        public string HIHId { get; set; }
        public virtual HIH HIH { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
