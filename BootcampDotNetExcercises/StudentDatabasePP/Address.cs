﻿namespace StudentDatabasePP
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string streetAddress, string city, string state, string zip)
        {
            StreetAddress = streetAddress; 
            City = city;
            State = state;
            ZipCode = zip;
        }

        public string GetHomeTown()
        {
            return $"{City},{State}";
        }
    }
}
