using System;
using System.Collections.Generic;
using System.Text;

namespace MobApplication.Model
{
    public class UserDetail
    {
        public string ProfileCreatedDate{get;set;}
        public int AccountNumber { get; set;}
        public string Name { get; set;}
        public string Type { get; set;}
        public string Email { get; set;}
        public long PhoneNumber { get; set;}
        public string Location { get; set; }
       public  UserDetail()
        {
            ProfileCreatedDate = "18 NOV 2018";
            AccountNumber = 12345678;
            Name="Ayush Aggarwal";
            Type = "Vendor";
            Email = "ayushagg@gmail.com";
            PhoneNumber = 9736826298;
            Location = "E 29 Noida, India";
        }

    }
}
