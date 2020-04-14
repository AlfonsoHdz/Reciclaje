﻿using System;
using System.Collections.Generic;


namespace LVAReciclajeTPDA.Data
{
    public class EmployeeDetail: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int NumberPhone { get; set; }
        public char ContactEmail { get; set; }
        public char Contrasena { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string PlaceOfBirth { get; set; }
        public string HealthInsurance { get; set; }

        public Product Product { get; set; }
        public Employee Employee { get; set; }

    }
}
